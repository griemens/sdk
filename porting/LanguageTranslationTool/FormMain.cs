using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace GResxExtract
{
    public partial class FormMain : Form
    {
        private string PathWakinside
        {
            get
            {
                return this.pTxtPathWalkinside.Text;
            }
            set
            {
                this.pTxtPathWalkinside.Text = value;
            }
        }

        private string PathOutput
        {
            get
            {
                return this.pTxtPathOutput.Text;
            }
            set
            {
                this.pTxtPathOutput.Text = value;
            }
        }

        private string FileResGen
        {
            get
            {
                return this.pTxtFileResgen.Text;
            }
            set
            {
                this.pTxtFileResgen.Text = value;
            }
        }

        private string FileAL
        {
            get
            {
                return this.pTxtFileAL.Text;
            }
            set
            {
                this.pTxtFileAL.Text = value;
            }
        }

        internal string Project
        {
            set
            {
                if (value == null)
                    return;
                if (System.IO.File.Exists(value))
                    this.LoadProject(value);
                else
                    MessageBox.Show("File '"+value+"' does not exists.");
            }
        }

        private string Language
        {
            get
            {
                return this.pCmboLanguage.Text;
            }
            set
            {
                this.pCmboLanguage.Text = value;
            }
        }

        public FormMain()
        {
            InitializeComponent();
            this.pCmboLanguage.Items.AddRange(CultureInfo.GetCultures(CultureTypes.AllCultures));
            this.pCmboLanguage.ValueMember = "Name";
            // How to detect propper location of al.exe ?
            string path = Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\Microsoft SDKs\\Windows\\v8.1A\\bin\\NETFX 4.5.1 Tools\\al.exe";
            if (!File.Exists(path))
                return;
            this.pTxtFileAL.Text = path;
        }


        private void pBtnBrowseWalkinside_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = this.PathWakinside;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            this.PathWakinside = folderBrowserDialog.SelectedPath;

        }

        private void pBtnBrowseResgen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = this.FileResGen;
            openFileDialog.Filter = "ResGen.exe|ResGen.exe";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.FileResGen = openFileDialog.FileName;

        }

        private void pBtnBrowseAL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = this.FileAL;
            openFileDialog.Filter = "AL.exe|AL.exe";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.FileAL = openFileDialog.FileName;
        }

        private void pBtnBrowseOutput_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = this.PathOutput;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            this.PathOutput = folderBrowserDialog.SelectedPath;

        }

        #region Check button implementation

        private void CreateNodesForFolders()
        {
            pTreeResources.Nodes.Clear();
            this.pTreeResources.Nodes.Add("Resources").Name = ".";
            foreach (var f in System.IO.Directory.GetDirectories(this.PathWakinside))
            {
                string directoryName = Helpers.MakeRelativePath(this.PathWakinside, f);
                TreeNode[] treeNodeArray = this.pTreeResources.Nodes.Find(directoryName, true);
                TreeNode treeNode1;
                if (treeNodeArray.Length != 1)
                {
                    int idx = directoryName.LastIndexOf(Path.DirectorySeparatorChar);
                    string nodename = directoryName.Substring(0, idx);
                    TreeNode[] nodes = this.pTreeResources.Nodes.Find(nodename, true);
                    treeNode1 = nodes[0].Nodes.Add(directoryName.Substring(idx + 1));
                    treeNode1.Name = directoryName;
                }
            }
        }

        private void pBtnCheck_Click(object sender, EventArgs e)
        {
            // This method is going to populate the tree view with all folders and dlls 
            // for wich resoures will be generated.

            // Add the folders to the treeview.
            CreateNodesForFolders();

            // Add all valid .Net assembly files.
            List<Assembly> allAssemblies = this.GetAllAssemblies(this.PathWakinside);
            foreach (Assembly assembly in allAssemblies)
            {
                string path = Helpers.MakeRelativePath(this.PathWakinside, new Uri(assembly.CodeBase).LocalPath);
                string directoryName = Path.GetDirectoryName(path);
                string fileName = Path.GetFileName(path);
                TreeNode[] treeNodeArray = this.pTreeResources.Nodes.Find(directoryName, true);
                TreeNode parentnode;
                if (treeNodeArray.Length != 1)
                {
                    int idx = directoryName.LastIndexOf(Path.DirectorySeparatorChar);
                    string nodename = directoryName.Substring(0, idx);
                    TreeNode[] nodes = this.pTreeResources.Nodes.Find(nodename, true);
                    parentnode = nodes[0].Nodes.Add(directoryName.Substring(idx + 1));
                    parentnode.Name = directoryName;
                }
                else
                    parentnode = treeNodeArray[0];

                TreeNode filenode = parentnode.Nodes.Add(fileName);
                filenode.Tag = (object)assembly;
                filenode.Name = directoryName + (object)Path.DirectorySeparatorChar + fileName;
            }

        }

        #endregion

        #region Generate button implementation

        private void pBtnGenerate_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in this.pTreeResources.Nodes[0].Nodes)
                this.GenerateResources(node);

        }

        private void GenerateResources(TreeNode node)
        {
            Assembly assem = node.Tag as Assembly;
            if (assem != null)
            {
                string name = node.Name;
                this.ExtractResX(assem, name);
            }
            foreach (TreeNode child in node.Nodes)
                this.GenerateResources(child);
        }

        private List<Assembly> GetAllAssemblies(string path)
        {
            List<Assembly> list = new List<Assembly>();
            foreach (string file in Directory.GetFiles(path, "*.dll", SearchOption.AllDirectories))
            {
                Assembly assembly = this.ValidateFile(file);
                if (assembly != null)
                    list.Add(assembly);
            }
            foreach (string file in Directory.GetFiles(path, "*.exe", SearchOption.AllDirectories))
            {
                Assembly assembly = this.ValidateFile(file);
                if (assembly != null)
                    list.Add(assembly);
            }
            return list;
        }

        private Assembly ValidateFile(string file)
        {
            try
            {
                return Assembly.LoadFile(file);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void ExtractResX(Assembly assem, string file)
        {
            string path = this.PathOutput + "\\" + file;
            Directory.CreateDirectory(path);
            foreach (string resource_name in assem.GetManifestResourceNames())
            {
                if (resource_name.EndsWith(".resources"))
                {
                    using (ResourceReader resourceReader = new ResourceReader(assem.GetManifestResourceStream(resource_name)))
                    {
                        string resource_filename = Path.ChangeExtension(resource_name, ".resx");
                        using (ResXResourceWriter resXresourceWriter = new ResXResourceWriter(path + "\\" + resource_filename))
                        {
                            foreach (DictionaryEntry dictionaryEntry in resourceReader)
                            {
                                object obj = dictionaryEntry.Value;
                                string name = dictionaryEntry.Key as string;
                                if (obj.GetType() == typeof(System.IO.UnmanagedMemoryStream))
                                    continue;
                                resXresourceWriter.AddResource(name, obj);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        private void pBtnCreate_Click(object sender, EventArgs e)
        {
            foreach (string folder in Directory.GetDirectories(this.PathOutput, "*", SearchOption.AllDirectories))
                this.CreateLanguageFile(folder);

        }

        private void CreateLanguageFile(string folder)
        {
            string[] resource_files = Directory.GetFiles(folder, "*." + this.Language + ".resx", SearchOption.TopDirectoryOnly);
            if (resource_files.Length == 0)
                return;
            foreach (string resource_file in resource_files)
            {
                Process process = Process.Start(new ProcessStartInfo("\"" + this.FileResGen + "\"", "\"" + resource_file + "\"")
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process.WaitForExit();
            }

            resource_files = Directory.GetFiles(folder, "*." + this.Language + ".resources", SearchOption.AllDirectories);
            if (resource_files.Length > 0)
            {
                string argument = "";
                foreach (string resource_file in resource_files)
                    argument = argument + "/embed:\"" + resource_file + "\" ";
                argument = "/t:lib " + argument + " /culture:" + this.Language;
                string pathWakinside = this.PathWakinside;
                int pathlength = folder.LastIndexOf(Path.DirectorySeparatorChar);
                string path = pathWakinside + folder.Substring(0, pathlength).Replace(this.PathOutput, "") + "\\" + this.Language;
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                int startIndex = folder.LastIndexOf('\\');
                string filename = folder.Substring(startIndex);
                int idx = filename.LastIndexOf('.');
                string filename_noextension = filename.Substring(0, idx);
                string arguments = argument + " /out:\"" + path + filename_noextension + ".resources.dll\"";
                Console.WriteLine(arguments);
                Process process = Process.Start(new ProcessStartInfo("\"" + this.FileAL + "\"", arguments)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
                process.WaitForExit();
            }
            foreach (string path in resource_files)
                File.Delete(path);
        }

        private void pToolSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog.Filter = "*.vrlanguage|*.vrlanguage";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            using (ResXResourceWriter resXresourceWriter = new ResXResourceWriter(saveFileDialog.FileName))
            {
                resXresourceWriter.AddResource("PathWakinside", this.PathWakinside);
                resXresourceWriter.AddResource("FileAL", this.FileAL);
                resXresourceWriter.AddResource("FileResGen", this.FileResGen);
                resXresourceWriter.AddResource("PathOutput", this.PathOutput);
                resXresourceWriter.AddResource("Language", this.Language);
            }
        }

        private void LoadProject(string file)
        {

            ResXResourceSet resXresourceSet = new ResXResourceSet(file);
            this.PathWakinside = resXresourceSet.GetString("PathWakinside");
            this.FileAL = resXresourceSet.GetString("FileAL");
            this.FileResGen = resXresourceSet.GetString("FileResGen");
            this.PathOutput = resXresourceSet.GetString("PathOutput");
            this.Language = resXresourceSet.GetString("Language");
        }

        private void pToolLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "*.vrlanguage|*.vrlanguage";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            this.LoadProject(openFileDialog.FileName);
        }
    }
}
