using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace GZDML
{
    public partial class FormMain : Form
    {
        public string argMode = string.Empty;
        public string argHost = string.Empty;
        public string argPlayers = string.Empty;
        public string argMapNo = string.Empty;
        public string argIP = string.Empty;
         
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string GZDPath = Directory.GetCurrentDirectory();
            string appPath = Path.Combine(GZDPath, "gzdoom.exe");
            string args = string.Empty;
            Process.Start(appPath, args);
        }

        private void GetHostIP()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    IPInterfaceProperties properties = ni.GetIPProperties();
                    foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            tbIP.Text = ip.Address.ToString();
                        }
                    }
                }
            }
        }

        private void rbHost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHost.Checked)
            {
                labelIPJ.Enabled = false;
                tbIP.Enabled = false;
                GetHostIP();
            }
            else
            {
                labelIPJ.Enabled = true;
                tbIP.Enabled = true;
                tbIP.Text = string.Empty;
            }
        }

        private void rbJoin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJoin.Checked)
            {
                labelMode.Enabled = false;
                labelPlayers.Enabled = false;
                labelMapNo.Enabled = false;
                rbDM.Enabled = false;
                rbCoop.Enabled = false;
                numPlayers.Enabled = false;
                numMapNo.Enabled = false;
            }
            else
            {
                labelMode.Enabled = true;
                labelPlayers.Enabled = true;
                labelMapNo.Enabled = true;
                rbDM.Enabled = true;
                numPlayers.Enabled = true;
                numMapNo.Enabled = true;
                rbCoop .Enabled = true;
            }
        }
    }
}