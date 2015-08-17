﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                textBoxPATH.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            LocalProfile.SavePATH(textBoxPATH.Text);
        }
    }
}
