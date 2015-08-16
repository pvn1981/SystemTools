using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ChangerMTU
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int ReadMTU(string networkInterfaceId)
        {
            RegistryKey keyMTU = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + networkInterfaceId, true);
            int mtu = (int)keyMTU.GetValue("MTU", -1);
            keyMTU.Close();

            return mtu;
        }

        bool SetMTU(string networkInterfaceId, int mtu)
        {
            bool result = true;

            RegistryKey keyMTU = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + networkInterfaceId, true);
            int mtu32 = Convert.ToInt32(textBoxCurrentMTU.Text);
            keyMTU.SetValue("MTU", mtu32, RegistryValueKind.DWord);
            keyMTU.Close();

            return result;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            bool findActiveNetworkConection = false;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == 
                    NetworkInterfaceType.Wireless80211 || 
                    ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    if (ni.OperationalStatus == OperationalStatus.Up)
                    {
                        if (!findActiveNetworkConection)
                        {
                            string MTU = string.Format("{0}", ReadMTU(ni.Id));

                            toolStripStatusLabel.Text = ni.Description;
                            
                            textBoxCurrentMTU.Text = MTU;

                            if (MTU != "-1")
                            {
                                findActiveNetworkConection = true;
                            }
                        }

                        comboBoxActiveNetworkConnection.Items.Add(ni.Name);
                    }
                }
                else
                {
                }

            }

            if (findActiveNetworkConection)
            {
                comboBoxActiveNetworkConnection.SelectedIndex = 0;
            }  
        }



        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboBoxActiveNetworkConnection.Items.Count != 0)
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.NetworkInterfaceType ==
                        NetworkInterfaceType.Wireless80211 ||
                        ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        if (ni.OperationalStatus == OperationalStatus.Up)
                        {
                            if (ni.Name == (string)comboBoxActiveNetworkConnection.Items[comboBoxActiveNetworkConnection.SelectedIndex])
                            {
                                int mtu = Convert.ToInt32(textBoxCurrentMTU.Text);

                                if(SetMTU(ni.Id, mtu))
                                    MessageBox.Show("Перезагрузите компьютер, чтобы изменения вступили в силу!");
                                else
                                    MessageBox.Show("Не удалось установить MTU");
                            }
                        }
                    }
                    else
                    {
                    }

                }
            }
            else
            {
                MessageBox.Show("У вас не найден ни один сетевой интерфейс, чего тычешь?");
            }
        }

        private void comboBoxActiveNetworkConnection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.Name == (string)comboBoxActiveNetworkConnection.Items[comboBoxActiveNetworkConnection.SelectedIndex])
                {
                    string MTU = string.Format("{0}", ReadMTU(ni.Id));
                    textBoxCurrentMTU.Text = MTU;
                }
            }
        }
    }
}
