using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Threading;

namespace ServiceStatus
{
    public partial class FormMain : Form
    {
        private System.ServiceProcess.ServiceController[] services;

        public FormMain()
        {
            InitializeComponent();
            RefreshServiceList();
        }

        protected void RefreshServiceList()
        {
            services = ServiceController.GetServices();
            listBoxServices.DisplayMember = "DisplayName";
            listBoxServices.DataSource = services;
        }

        private void buttonfind_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (ServiceController controllerCurrent in services)
            {
                if (controllerCurrent.DisplayName == "Служба времени Windows")
                    break;

                index++;
            }

            listBoxServices.SelectedIndex = index;

            ServiceController controller = (ServiceController)listBoxServices.SelectedItem;

            if (controller.Status == ServiceControllerStatus.Running)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
            }

            if (controller.Status == ServiceControllerStatus.Stopped)
            {
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
            }

            toolStripStatusLabelMain.Text = controller.DisplayName;
        }

        void UpdateStatusService()
        {
            ServiceController controller = (ServiceController)listBoxServices.SelectedItem;

            controller.Refresh();

            if (controller.Status == ServiceControllerStatus.Running)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;

                toolStripStatusLabelMain.Text = controller.DisplayName + " работает";
            }

            if (controller.Status == ServiceControllerStatus.Stopped)
            {
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;

                toolStripStatusLabelMain.Text = controller.DisplayName + " остановлена";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateStatusService();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ServiceController controller = (ServiceController)listBoxServices.SelectedItem;

            if (controller.Status != ServiceControllerStatus.Running)
                controller.Start();

            Thread.Sleep(100);

            UpdateStatusService();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ServiceController controller = (ServiceController)listBoxServices.SelectedItem;

            if (controller.Status == ServiceControllerStatus.Running)
                controller.Stop();

            Thread.Sleep(100);

            UpdateStatusService();
        }
    }
}
