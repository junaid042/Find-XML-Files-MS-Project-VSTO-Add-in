using Microsoft.Office.Tools.Ribbon;

namespace ProjectAddIn2
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Office.Tools.Ribbon.RibbonButton buttonXML;
        private Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        private Microsoft.Office.Tools.Ribbon.RibbonButton buttonMore;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.buttonXML = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.buttonMore = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.buttonXML);
            this.group1.Label = "Group 1";
            this.group1.Name = "group1";
            // 
            // buttonXML
            // 
            this.buttonXML.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonXML.Image = ((System.Drawing.Image)(resources.GetObject("buttonXML.Image")));
            this.buttonXML.Label = "XML Files with Folder";
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.ShowImage = true;
            this.buttonXML.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonXML_Click_1);
            // 
            // group2
            // 
            this.group2.Items.Add(this.buttonMore);
            this.group2.Label = "Group 2";
            this.group2.Name = "group2";
            // 
            // buttonMore
            // 
            this.buttonMore.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonMore.Image = ((System.Drawing.Image)(resources.GetObject("buttonMore.Image")));
            this.buttonMore.Label = "Open XML File";
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.ShowImage = true;
            this.buttonMore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMore_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Project.Project";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // Ribbon load event handler code
        }
      
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
