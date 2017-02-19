namespace GResxExtract
{
    using System.Windows.Forms;
    using System.Drawing;
    using System;

    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pBtnBrowseWalkinside = new System.Windows.Forms.Button();
            this.pBtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pTxtPathWalkinside = new System.Windows.Forms.TextBox();
            this.pGrpSettings = new System.Windows.Forms.GroupBox();
            this.pBtnBrowseAL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pTxtFileAL = new System.Windows.Forms.Button();
            this.pBtnBrowseResgen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pTxtFileResgen = new System.Windows.Forms.TextBox();
            this.pGrpResources = new System.Windows.Forms.GroupBox();
            this.pBtnCheck = new System.Windows.Forms.Button();
            this.pBtnGenerate = new System.Windows.Forms.Button();
            this.pTreeResources = new System.Windows.Forms.TreeView();
            this.pBtnBrowseOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pTxtPathOutput = new System.Windows.Forms.TextBox();
            this.pGrpApply = new System.Windows.Forms.GroupBox();
            this.pCmboLanguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pToolSave = new System.Windows.Forms.ToolStripButton();
            this.pToolLoad = new System.Windows.Forms.ToolStripButton();
            this.pGrpSettings.SuspendLayout();
            this.pGrpResources.SuspendLayout();
            this.pGrpApply.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBtnBrowseWalkinside
            // 
            this.pBtnBrowseWalkinside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBtnBrowseWalkinside.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnBrowseWalkinside.Location = new System.Drawing.Point(829, 21);
            this.pBtnBrowseWalkinside.Name = "pBtnBrowseWalkinside";
            this.pBtnBrowseWalkinside.Size = new System.Drawing.Size(75, 23);
            this.pBtnBrowseWalkinside.TabIndex = 0;
            this.pBtnBrowseWalkinside.Text = "Browse";
            this.pBtnBrowseWalkinside.UseVisualStyleBackColor = true;
            this.pBtnBrowseWalkinside.Click += new System.EventHandler(this.pBtnBrowseWalkinside_Click);
            // 
            // pBtnCreate
            // 
            this.pBtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnCreate.Location = new System.Drawing.Point(85, 63);
            this.pBtnCreate.Name = "pBtnCreate";
            this.pBtnCreate.Size = new System.Drawing.Size(75, 23);
            this.pBtnCreate.TabIndex = 1;
            this.pBtnCreate.Text = "Create";
            this.pBtnCreate.UseVisualStyleBackColor = true;
            this.pBtnCreate.Click += new System.EventHandler(this.pBtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Walkinside Path";
            // 
            // pTxtPathWalkinside
            // 
            this.pTxtPathWalkinside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTxtPathWalkinside.Location = new System.Drawing.Point(121, 21);
            this.pTxtPathWalkinside.Name = "pTxtPathWalkinside";
            this.pTxtPathWalkinside.Size = new System.Drawing.Size(702, 20);
            this.pTxtPathWalkinside.TabIndex = 3;
            // 
            // pGrpSettings
            // 
            this.pGrpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGrpSettings.Controls.Add(this.pBtnBrowseAL);
            this.pGrpSettings.Controls.Add(this.label3);
            this.pGrpSettings.Controls.Add(this.pTxtFileAL);
            this.pGrpSettings.Controls.Add(this.pBtnBrowseResgen);
            this.pGrpSettings.Controls.Add(this.label2);
            this.pGrpSettings.Controls.Add(this.pTxtFileResgen);
            this.pGrpSettings.Controls.Add(this.pBtnBrowseWalkinside);
            this.pGrpSettings.Controls.Add(this.label1);
            this.pGrpSettings.Controls.Add(this.pTxtPathWalkinside);
            this.pGrpSettings.Location = new System.Drawing.Point(12, 28);
            this.pGrpSettings.Name = "pGrpSettings";
            this.pGrpSettings.Size = new System.Drawing.Size(910, 129);
            this.pGrpSettings.TabIndex = 4;
            this.pGrpSettings.TabStop = false;
            this.pGrpSettings.Text = "Settings";
            // 
            // pBtnBrowseAL
            // 
            this.pBtnBrowseAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBtnBrowseAL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnBrowseAL.Location = new System.Drawing.Point(829, 77);
            this.pBtnBrowseAL.Name = "pBtnBrowseAL";
            this.pBtnBrowseAL.Size = new System.Drawing.Size(75, 23);
            this.pBtnBrowseAL.TabIndex = 7;
            this.pBtnBrowseAL.Text = "Browse";
            this.pBtnBrowseAL.UseVisualStyleBackColor = true;
            this.pBtnBrowseAL.Click += new System.EventHandler(this.pBtnBrowseAL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AL File";
            // 
            // pTxtFileAL
            // 
            this.pTxtFileAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTxtFileAL.Location = new System.Drawing.Point(121, 77);
            this.pTxtFileAL.Name = "pTxtFileAL";
            this.pTxtFileAL.Size = new System.Drawing.Size(702, 22);
            this.pTxtFileAL.TabIndex = 9;
            // 
            // pBtnBrowseResgen
            // 
            this.pBtnBrowseResgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBtnBrowseResgen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnBrowseResgen.Location = new System.Drawing.Point(829, 49);
            this.pBtnBrowseResgen.Name = "pBtnBrowseResgen";
            this.pBtnBrowseResgen.Size = new System.Drawing.Size(75, 23);
            this.pBtnBrowseResgen.TabIndex = 4;
            this.pBtnBrowseResgen.Text = "Browse";
            this.pBtnBrowseResgen.UseVisualStyleBackColor = true;
            this.pBtnBrowseResgen.Click += new System.EventHandler(this.pBtnBrowseResgen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ResGen File";
            // 
            // pTxtFileResgen
            // 
            this.pTxtFileResgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTxtFileResgen.Location = new System.Drawing.Point(121, 49);
            this.pTxtFileResgen.Name = "pTxtFileResgen";
            this.pTxtFileResgen.Size = new System.Drawing.Size(702, 20);
            this.pTxtFileResgen.TabIndex = 6;
            // 
            // pGrpResources
            // 
            this.pGrpResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGrpResources.Controls.Add(this.pBtnCheck);
            this.pGrpResources.Controls.Add(this.pBtnGenerate);
            this.pGrpResources.Controls.Add(this.pTreeResources);
            this.pGrpResources.Controls.Add(this.pBtnBrowseOutput);
            this.pGrpResources.Controls.Add(this.label4);
            this.pGrpResources.Controls.Add(this.pTxtPathOutput);
            this.pGrpResources.Location = new System.Drawing.Point(13, 163);
            this.pGrpResources.Name = "pGrpResources";
            this.pGrpResources.Size = new System.Drawing.Size(909, 293);
            this.pGrpResources.TabIndex = 5;
            this.pGrpResources.TabStop = false;
            this.pGrpResources.Text = "Resources";
            // 
            // pBtnCheck
            // 
            this.pBtnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnCheck.Location = new System.Drawing.Point(6, 264);
            this.pBtnCheck.Name = "pBtnCheck";
            this.pBtnCheck.Size = new System.Drawing.Size(75, 23);
            this.pBtnCheck.TabIndex = 16;
            this.pBtnCheck.Text = "Check";
            this.pBtnCheck.UseVisualStyleBackColor = true;
            this.pBtnCheck.Click += new System.EventHandler(this.pBtnCheck_Click);
            // 
            // pBtnGenerate
            // 
            this.pBtnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnGenerate.Location = new System.Drawing.Point(87, 264);
            this.pBtnGenerate.Name = "pBtnGenerate";
            this.pBtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.pBtnGenerate.TabIndex = 15;
            this.pBtnGenerate.Text = "Generate";
            this.pBtnGenerate.UseVisualStyleBackColor = true;
            this.pBtnGenerate.Click += new System.EventHandler(this.pBtnGenerate_Click);
            // 
            // pTreeResources
            // 
            this.pTreeResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTreeResources.Location = new System.Drawing.Point(8, 49);
            this.pTreeResources.Name = "pTreeResources";
            this.pTreeResources.Size = new System.Drawing.Size(895, 209);
            this.pTreeResources.TabIndex = 14;
            // 
            // pBtnBrowseOutput
            // 
            this.pBtnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBtnBrowseOutput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pBtnBrowseOutput.Location = new System.Drawing.Point(829, 21);
            this.pBtnBrowseOutput.Name = "pBtnBrowseOutput";
            this.pBtnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.pBtnBrowseOutput.TabIndex = 10;
            this.pBtnBrowseOutput.Text = "Browse";
            this.pBtnBrowseOutput.UseVisualStyleBackColor = true;
            this.pBtnBrowseOutput.Click += new System.EventHandler(this.pBtnBrowseOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output Path";
            // 
            // pTxtPathOutput
            // 
            this.pTxtPathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTxtPathOutput.Location = new System.Drawing.Point(120, 21);
            this.pTxtPathOutput.Name = "pTxtPathOutput";
            this.pTxtPathOutput.Size = new System.Drawing.Size(702, 20);
            this.pTxtPathOutput.TabIndex = 12;
            // 
            // pGrpApply
            // 
            this.pGrpApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGrpApply.Controls.Add(this.pCmboLanguage);
            this.pGrpApply.Controls.Add(this.label5);
            this.pGrpApply.Controls.Add(this.pBtnCreate);
            this.pGrpApply.Location = new System.Drawing.Point(12, 462);
            this.pGrpApply.Name = "pGrpApply";
            this.pGrpApply.Size = new System.Drawing.Size(909, 92);
            this.pGrpApply.TabIndex = 6;
            this.pGrpApply.TabStop = false;
            this.pGrpApply.Text = "Apply";
            // 
            // pCmboLanguage
            // 
            this.pCmboLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCmboLanguage.FormattingEnabled = true;
            this.pCmboLanguage.Location = new System.Drawing.Point(85, 24);
            this.pCmboLanguage.Name = "pCmboLanguage";
            this.pCmboLanguage.Size = new System.Drawing.Size(818, 21);
            this.pCmboLanguage.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Language";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolSave,
            this.pToolLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pToolSave
            // 
            this.pToolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pToolSave.Image = ((System.Drawing.Image)(resources.GetObject("pToolSave.Image")));
            this.pToolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pToolSave.Name = "pToolSave";
            this.pToolSave.Size = new System.Drawing.Size(35, 22);
            this.pToolSave.Text = "Save";
            this.pToolSave.Click += new System.EventHandler(this.pToolSave_Click);
            // 
            // pToolLoad
            // 
            this.pToolLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pToolLoad.Image = ((System.Drawing.Image)(resources.GetObject("pToolLoad.Image")));
            this.pToolLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pToolLoad.Name = "pToolLoad";
            this.pToolLoad.Size = new System.Drawing.Size(37, 22);
            this.pToolLoad.Text = "Load";
            this.pToolLoad.Click += new System.EventHandler(this.pToolLoad_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(934, 566);
            this.Controls.Add(this.pGrpResources);
            this.Controls.Add(this.pGrpSettings);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pGrpApply);
            this.Name = "FormMain";
            this.pGrpSettings.ResumeLayout(false);
            this.pGrpSettings.PerformLayout();
            this.pGrpResources.ResumeLayout(false);
            this.pGrpResources.PerformLayout();
            this.pGrpApply.ResumeLayout(false);
            this.pGrpApply.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button pBtnBrowseWalkinside;
        private Button pBtnCreate;
        private Label label1;
        private TextBox pTxtPathWalkinside;
        private GroupBox pGrpSettings;
        private Button pBtnBrowseResgen;
        private Label label2;
        private TextBox pTxtFileResgen;
        private Button pBtnBrowseAL;
        private Label label3;
        private Button pTxtFileAL;
        private GroupBox pGrpResources;
        private Button pBtnBrowseOutput;
        private Label label4;
        private TextBox pTxtPathOutput;
        private TreeView pTreeResources;
        private GroupBox pGrpApply;
        private ToolStrip toolStrip1;
        private ToolStripButton pToolSave;
        private ToolStripButton pToolLoad;
        private Button pBtnGenerate;
        private ComboBox pCmboLanguage;
        private Label label5;
        private Button pBtnCheck;
    }
}