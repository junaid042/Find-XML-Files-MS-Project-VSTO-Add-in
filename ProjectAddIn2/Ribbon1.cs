using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectAddIn2
{
    public partial class Ribbon1
    {
        private Taskpane taskPane;
        private Taskpane1 taskPane1;
        private Microsoft.Office.Tools.CustomTaskPane currentTaskPane;

        private void buttonXML_Click_1(object sender, RibbonControlEventArgs e)
        {
            if (currentTaskPane != null && currentTaskPane.Control is Taskpane)
            {
                // The currently active task pane is Taskpane, no action needed
                return;
            }

            // Close the current task pane
            CloseCurrentTaskPane();

            taskPane = new Taskpane();
            Microsoft.Office.Tools.CustomTaskPaneCollection customPaneCollection;
            customPaneCollection = Globals.Factory.CreateCustomTaskPaneCollection(null, null, "Panes", "Panes", this);
            currentTaskPane = customPaneCollection.Add(taskPane, "Find XML With Folder");
            currentTaskPane.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.20);
            currentTaskPane.Visible = true;
        }

        private void buttonMore_Click(object sender, RibbonControlEventArgs e)
        {
            if (currentTaskPane != null && currentTaskPane.Control is Taskpane1)
            {
                // The currently active task pane is Taskpane1, no action needed
                return;
            }

            // Close the current task pane
            CloseCurrentTaskPane();

            taskPane1 = new Taskpane1();
            Microsoft.Office.Tools.CustomTaskPaneCollection customPaneCollection;
            customPaneCollection = Globals.Factory.CreateCustomTaskPaneCollection(null, null, "Panes", "Panes", this);
            currentTaskPane = customPaneCollection.Add(taskPane1, "Find XML Files");
            currentTaskPane.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.20);
            currentTaskPane.Visible = true;
        }

        private void CloseCurrentTaskPane()
        {
            if (currentTaskPane != null)
            {
                currentTaskPane.Visible = false;
                currentTaskPane.Dispose();
                currentTaskPane = null;
            }
        }
    }
}
