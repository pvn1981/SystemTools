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

        #region Constructor

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handler

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            string folderPath = ChooseFolder();

            textBoxFolderName.Text = folderPath;

            Properties.Settings.Default.OldPath = folderPath;
            Properties.Settings.Default.Save();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxFolderName.Text = Properties.Settings.Default.OldPath;
        }

        async private void buttonApply_Click(object sender, EventArgs e)
        {
            await Rename(Properties.Settings.Default.OldPath);
        }

        #endregion

        #region Methods

        string ChooseFolder()
        {
            StringBuilder sb = new StringBuilder();

            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.SelectedPath = textBoxFolderName.Text;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sb.Append(diag.SelectedPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return sb.ToString();
        }

        async Task Rename(string folderPath)
        {
            await Task.Run(() =>
            {
                DirectoryInfo d = new DirectoryInfo(folderPath);
                FileInfo[] infos = d.GetFiles("*.mkv");

                //  Названия в папке: "1. Фотографии.mkv", 
                //                    "84. Ветка.mkv", 
                //                    "101. Песня ветра.mkv"
                //
                //  Должно быть:      "001_Фотографии.mkv" итд

                progressBarMain.Minimum = 0;
                progressBarMain.Maximum = infos.Count();

                foreach (FileInfo f in infos)
                {
                    string fileName = f.Name;

                    string patternSearch = ". ";
                    int patternLength = patternSearch.Length;

                    int startPatternAddress = fileName.IndexOf(patternSearch);
                    int endPatternAddress = startPatternAddress + patternLength;

                    string numberString = fileName.Substring(0, startPatternAddress);

                    int allLength = fileName.Length;
                    int nameLength = allLength - endPatternAddress;

                    string namePlusExtention = fileName.Substring(endPatternAddress, nameLength);
                    int number = Convert.ToInt32(numberString);

                    string newFileName = number.ToString("000") + "_" + namePlusExtention;
                    string newFullFileName = folderPath + "\\" + newFileName;

                    File.Move(f.FullName, newFullFileName);

                    progressBarMain.Value += 1;
                }
            });
        }

        #endregion
    }
}
