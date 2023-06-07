using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectAddIn2
{
    public partial class Taskpane : UserControl
    {
        private string directoryPath; // Variable to store the selected folder path

        public Taskpane()
        {
            InitializeComponent();
        }

        private void Taskpane_Load(object sender, EventArgs e)
        {
            // Set the initial value for the directory path
            directoryPath = "";

            // Disable the button if no folder path is selected
            buttonOpenFile.Enabled = false;
        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // Show the folder browser dialog
                DialogResult result = folderDialog.ShowDialog();

                // Check if a folder was selected
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    // Set the selected folder path
                    directoryPath = folderDialog.SelectedPath;

                    // Enable the button since a folder path is selected
                    buttonOpenFile.Enabled = true;

                    // Use the folder path to load .xml and .pp files
                    LoadXmlAndPpFilesFromFolder(directoryPath);
                }
            }
        }

        private void LoadXmlAndPpFilesFromFolder(string folderPath)
        {
            // Get all .xml and .pp files in the specified folder
            string[] xmlFiles = Directory.GetFiles(folderPath, "*.xml", SearchOption.AllDirectories);
            string[] ppFiles = Directory.GetFiles(folderPath, "*.mpp", SearchOption.AllDirectories);

            // Combine the arrays of file paths
            string[] allFiles = xmlFiles.Concat(ppFiles).ToArray();

            // Clear any existing items in the ComboBox
            comboBoxFiles.Items.Clear();
            // Add only the file names (without the full path) to the ComboBox
            comboBoxFiles.Items.AddRange(allFiles.Select(Path.GetFileName).ToArray());
        }

        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            if (comboBoxFiles.SelectedItem != null)
            {
                string selectedFileName = comboBoxFiles.SelectedItem.ToString();

                string selectedFilePath = Path.Combine(directoryPath, selectedFileName);

                if (File.Exists(selectedFilePath))
                {
                    try
                    {
                        // Launch Microsoft Project with the file as a command-line argument
                        System.Diagnostics.Process.Start("WINPROJ.EXE", "\"" + selectedFilePath + "\"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Selected file does not exist: " + selectedFilePath);
                }
            }
        }
    }
}
