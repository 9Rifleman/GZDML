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
        public string argAltDM = string.Empty;
        public string argTeams = string.Empty;
        public string argJump = string.Empty;
        public string argCrouch = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            HostGameDisable();
            JoinGameDisable();
            buttonStart.Visible = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string GZDPath = Directory.GetCurrentDirectory();
            string appPath = Path.Combine(GZDPath, "gzdoom.exe");
            GetHostArgs();
            GetJoinArgs();
            string args = argHost + argMode + argMapNo;
            if (rbHost.Checked)
                Process.Start(appPath, args);
            else
                Process.Start(appPath, "-join " + argIP);
            this.Close();
        }

        private void GetHostArgs()
        {
            if (rbHost.Checked)
            {
                argHost = "-host " + numPlayers.Value.ToString();

                if (rbDM.Checked)
                    argMode = " -deathmatch";
                else
                    argMode = " -coop";
                
                string map = numMapNo.Value.ToString();
                if (numMapNo.Value < 10)
                    map = "0" + numMapNo.Value.ToString();
                argMapNo = " -warp " + map;
            }
            else
                return;
        }

        private void GetJoinArgs()
        {
            if (rbJoin.Checked)
                argIP = tbIP.Text.ToString();
        }

        private void GetHostLANIP()
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

        private void HostGameEnable()
        {
            labelMode.Enabled = true;
            labelPlayers.Enabled = true;
            labelMapNo.Enabled = true;
            labelSkill.Enabled = true;
            rbDM.Enabled = true;
            numPlayers.Enabled = true;
            numMapNo.Enabled = true;
            numSkill.Enabled = true;
            rbCoop.Enabled = true;
            buttonStart.Visible = true;
            buttonStart.Text = "Host game";
            cbAltDM.Enabled = true;
            cbCrouch.Enabled = true;
            cbJump.Enabled = true;
            cbTeam.Enabled = true;
        }

        private void HostGameDisable()
        {
            labelMode.Enabled = false;
            labelPlayers.Enabled = false;
            labelMapNo.Enabled = false;
            labelSkill.Enabled = false;
            rbDM.Enabled = false;
            rbCoop.Enabled = false;
            numPlayers.Enabled = false;
            numMapNo.Enabled = false;
            numSkill.Enabled = false;
            cbAltDM.Enabled = false;
            cbCrouch.Enabled = false;
            cbJump.Enabled = false;
            cbTeam.Enabled = false;
        }

        private void JoinGameEnable()
        {
            //labelIPJ.Enabled = true;
            tbIP.Enabled = true;
            labelIPJ.Text = "IP address:";
            tbIP.Text = string.Empty;
            buttonStart.Visible = true;
            buttonStart.Text = "Join game";
        }

        private void JoinGameDisable()
        {
            //labelIPJ.Enabled = false;
            labelIPJ.Text = "    Host IP:";
            tbIP.Enabled = false;
            GetHostLANIP();
        }

        private void rbHost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHost.Checked && !rbJoin.Checked)
            {
                HostGameEnable();
                JoinGameDisable();
            }
            else
            {
                HostGameDisable();
                JoinGameEnable();
            }
        }

        private void rbJoin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJoin.Checked && !rbHost.Checked)
            {
                HostGameDisable();
                JoinGameEnable();
            }
            else
            {
                HostGameEnable();
                JoinGameDisable();
            }
        }
    }
}