using System.Diagnostics;
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
        public string argFLimit = string.Empty;
        public string argTLimit = string.Empty;
        public string argNoMonsters = string.Empty;
        public string argIWAD = string.Empty;
        public string argPWAD1 = string.Empty;
        public string argPWAD2 = string.Empty;

        public FormMain()
        {
            InitializeComponent();
            FindIWADS();
            HostGameDisable();
            JoinGameDisable();

            buttonStart.Visible = false;
            buttonPWAD1.Enabled = false;
            buttonPWAD2.Enabled = false;
            labelPWAD.Enabled = false;
            labelIWAD.Enabled = false;
            cbClose.Visible = false;
            comboxIWAD.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            GetHostArgs();
            GetJoinArgs();

            string GZDPath = Directory.GetCurrentDirectory();
            string appPath = Path.Combine(GZDPath, "gzdoom.exe");
            string args = "-iwad " + argIWAD + " -file " + argPWAD1 + argPWAD2 + argHost + argMode + argMapNo + argFLimit + argTLimit + argAltDM + argJump + argCrouch + argNoMonsters;
            string args2 = "-iwad" + argIWAD + " -file " + argPWAD1 + argPWAD2 + " -join " + argIP;
            //File.WriteAllText(@"C:\args_log.txt", args);    //Log

            if (rbHost.Checked)
                Process.Start(appPath, args);
            else
                Process.Start(appPath, args2);

            if (cbClose.Checked)
                this.Close();
        }

        private void GetHostArgs()
        {
            if (rbHost.Checked)
            {
                argHost = " -host " + numPlayers.Value.ToString();   //Host & Players

                if (rbDM.Checked)                                   //Mode
                    argMode = " -deathmatch";
                else
                    argMode = " -coop";

                string map = numMapNo.Value.ToString();             //Map no.
                if (numMapNo.Value < 10)
                    map = "0" + numMapNo.Value.ToString();
                argMapNo = " -warp " + map;

                if (cbAltDM.Checked)                                //Alternate DM flags
                    argAltDM = " -altdeath";

                if (cbJump.Checked)                                 //Allow jumps
                    argJump = " +sv_allowjump 1";

                if (cbCrouch.Checked)                               //Allow duck
                    argCrouch = " +sv_allowcrouch 1";

                if (numFLimit.Value > 0)                            //Fraglimit
                    argFLimit = " +fraglimit " + numFLimit.Value.ToString();

                if (numTLimit.Value > 0)                            //Time limit
                    argTLimit = " +timelimit " + numTLimit.Value.ToString();

                if (cbMonsters.Checked)                             //No monsters
                    argNoMonsters = " +sv_nomonsters 1";

                switch (comboxIWAD.SelectedItem)
                {
                    case "DOOM":
                        argIWAD = "doom.wad";
                        break;
                    case "DOOM 2":
                        argIWAD = "doom 2.wad";
                        break;
                    case "Heretic":
                        argIWAD = "heretic.wad";
                        break;
                    case "Hexen":
                        argIWAD = "hexen.wad";
                        break;
                    case "Hexen DD":
                        argIWAD = "hexdd.wad";
                        break;
                    case "Strife":
                        argIWAD = "strife1.wad";
                        break;
                }
            }
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
            labelFLimit.Enabled = true;
            labelTLimit.Enabled = true;
            labelPWAD.Enabled = true;
            labelIWAD.Enabled = true;
            rbDM.Enabled = true;
            numPlayers.Enabled = true;
            numMapNo.Enabled = true;
            numSkill.Enabled = true;
            numFLimit.Enabled = true;
            numTLimit.Enabled = true;
            rbCoop.Enabled = true;
            buttonStart.Visible = true;
            buttonStart.Text = "Host game";
            buttonPWAD1.Enabled = true;
            buttonPWAD2.Enabled = true;
            cbAltDM.Enabled = true;
            cbCrouch.Enabled = true;
            cbJump.Enabled = true;
            cbMonsters.Enabled = true;
            cbClose.Visible = true;
            comboxIWAD.Enabled = true;
        }

        private void HostGameDisable()
        {
            labelMode.Enabled = false;
            labelPlayers.Enabled = false;
            labelMapNo.Enabled = false;
            labelSkill.Enabled = false;
            labelFLimit.Enabled = false;
            labelTLimit.Enabled = false;
            rbDM.Enabled = false;
            rbCoop.Enabled = false;
            numPlayers.Enabled = false;
            numMapNo.Enabled = false;
            numSkill.Enabled = false;
            numFLimit.Enabled = false;
            numTLimit.Enabled = false;
            cbAltDM.Enabled = false;
            cbCrouch.Enabled = false;
            cbJump.Enabled = false;
            cbMonsters.Enabled = false;
        }

        private void JoinGameEnable()
        {
            //labelIPJ.Enabled = true;
            tbIP.Enabled = true;
            labelIPJ.Text = "IP address:";
            labelPWAD.Enabled = true;
            labelIWAD.Enabled = true;
            tbIP.Text = string.Empty;
            buttonStart.Visible = true;
            buttonStart.Text = "Join game";
            buttonPWAD1.Enabled = true;
            buttonPWAD2.Enabled = true;
            cbClose.Visible = true;
            comboxIWAD.Enabled = true;
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

        private void buttonPWAD1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pwad = new OpenFileDialog();
            if (pwad.ShowDialog() == DialogResult.OK)
            {
                argPWAD1 = pwad.FileName;
                buttonPWAD1.Text = Path.GetFileName(argPWAD1);
                argPWAD1 = buttonPWAD1.Text;
                if (argPWAD1.Contains(" "))
                    argPWAD1 = "\"" + argPWAD1 + "\"";
            }
        }

        private void buttonPWAD2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pwad = new OpenFileDialog();
            if (pwad.ShowDialog() == DialogResult.OK)
            {
                argPWAD2 = pwad.FileName;
                buttonPWAD2.Text = Path.GetFileName(argPWAD2);
                argPWAD2 = buttonPWAD2.Text;
                if (argPWAD2.Contains(" "))
                    argPWAD2 = "\"" + argPWAD2 + "\"";
            }
        }

        private void FindIWADS()
        {
            string iwadPath = Directory.GetCurrentDirectory();
            if (File.Exists("doom.wad"))
                comboxIWAD.Items.Add("DOOM");
            if (File.Exists("doom2.wad"))
                comboxIWAD.Items.Add("DOOM 2");
            if (File.Exists("heretic.wad"))
                comboxIWAD.Items.Add("Heretic");
            if (File.Exists("hexen.wad"))
                comboxIWAD.Items.Add("Hexen");
            if (File.Exists("hexdd.wad"))
                comboxIWAD.Items.Add("Hexen DD");
            if (File.Exists("strife1.wad"))
                comboxIWAD.Items.Add("Strife");
        }
    }
}