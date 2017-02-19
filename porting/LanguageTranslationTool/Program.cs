using System;
using System.Windows.Forms;

namespace GResxExtract
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain form = new FormMain();
            if (args.Length > 0)
                form.Project = args[0]; // expected to be a valid project file.
            Application.Run(form);
        }
    }
}
