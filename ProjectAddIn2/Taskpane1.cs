using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectAddIn2
{
    public partial class Taskpane1 : UserControl
    {
        private string directoryPath = "C:\\Users\\junai\\Desktop\\xml\\Samples"; // Specify the directory path to search for XML files

        public Taskpane1()
        {
            InitializeComponent();
        }

        private void Taskpane1_Load(object sender, EventArgs e)
        {
            LoadXmlFiles();
        }

        private void LoadXmlFiles()
        {
            // Get all XML files in the specified directory and its subdirectories
            string[] xmlFiles = Directory.GetFiles(directoryPath, "*.xml", SearchOption.AllDirectories);

            // Clear any existing items in the ComboBox
            comboBoxFiles.Items.Clear();
            // Add only the file names (without the full path) to the ComboBox
            comboBoxFiles.Items.AddRange(xmlFiles.Select(Path.GetFileName).ToArray());
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
                        // Launch Microsoft Project with the XML file as a command-line argument
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