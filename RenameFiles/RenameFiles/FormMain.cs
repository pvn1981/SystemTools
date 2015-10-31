using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.SelectedPath = textBoxFolderName.Text;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string folderPath = diag.SelectedPath;

                    textBoxFolderName.Text = folderPath;

                    Properties.Settings.Default.OldPath = folderPath;
                    Properties.Settings.Default.Save();

                    DirectoryInfo d = new DirectoryInfo(folderPath);
                    FileInfo[] infos = d.GetFiles();

                    foreach (FileInfo f in infos)
                    {
                        string fileName = f.Name;
                        int index = fileName.IndexOf(". ");

                        string numberString = fileName.Substring(0, index);

                        int allLength = fileName.Length;
                        int nameLength = allLength - (index + 2);

                        string namePlusExtantion = fileName.Substring(index + 2, nameLength);
                        int number = Convert.ToInt32(numberString);

                        string newFileName = number.ToString("000") + "_" + namePlusExtantion;
                        string newFullFileName = folderPath + "\\" + newFileName;

                        File.Move(f.FullName, newFullFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxFolderName.Text = Properties.Settings.Default.OldPath;
        }
    }
}
