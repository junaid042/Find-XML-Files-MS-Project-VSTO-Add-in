using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MSProject = Microsoft.Office.Interop.MSProject;
using Office = Microsoft.Office.Core;

namespace ProjectAddIn2
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Taskpane uc = new Taskpane();

            Microsoft.Office.Tools.CustomTaskPaneCollection customPaneCollection;
            customPaneCollection = Globals.Factory.CreateCustomTaskPaneCollection(null, null, "Panes", "Panes", this);
            Microsoft.Office.Tools.CustomTaskPane ctp = customPaneCollection.Add(uc, "Project AddIn");
            ctp.Width = 350;
            ctp.Visible = false;
        }
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
