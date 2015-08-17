using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChangeProfilePATH
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Personal;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxPATH.Text += ";" + folderBrowserDialog.SelectedPath;

                // Хак чтобы он выровнил по правому краю
                textBoxPATH.SelectAll();

                buttonApply.BackColor = SystemColors.Control;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            buttonApply.BackColor = SystemColors.Control;
            buttonApply.Update();

            try
            {
                LocalProfile.SavePATH(textBoxPATH.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            buttonApply.BackColor = Color.LightGreen;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxPATH.Text = LocalProfile.ReadPATH();
        }
    }
}
