namespace ProjectAddIn2
{
    partial class Taskpane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonBrowseFolder;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taskpane));
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.BackColor = System.Drawing.Color.Green;
            this.buttonBrowseFolder.FlatAppearance.BorderSize = 0;
            this.buttonBrowseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseFolder.ForeColor = System.Drawing.Color.White;
            this.buttonBrowseFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowseFolder.Image")));
            this.buttonBrowseFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowseFolder.Location = new System.Drawing.Point(73, 40);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonBrowseFolder.Size = new System.Drawing.Size(150, 35);
            this.buttonBrowseFolder.TabIndex = 0;
            this.buttonBrowseFolder.Text = "Browse Folder";
            this.buttonBrowseFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBrowseFolder.UseVisualStyleBackColor = false;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(8, 92);
            this.comboBoxFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(276, 28);
            this.comboBoxFiles.TabIndex = 1;
            this.comboBoxFiles.Text = "Select XML File";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.Green;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile.Location = new System.Drawing.Point(83, 144);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(128, 35);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // Taskpane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBrowseFolder);
            this.Controls.Add(this.comboBoxFiles);
            this.Controls.Add(this.buttonOpenFile);
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "Taskpane";
            this.Size = new System.Drawing.Size(300, 533);
            this.Load += new System.EventHandler(this.Taskpane_Load);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
