using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RDP
{
    public partial class RDC : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsh, int wparam, int lparam);
        public RDC()
        {
            InitializeComponent();
        }

        private void axMsRdpClient8NotSafeForScripting1_OnConnecting(object sender, EventArgs e)
        {

        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            axMsRdpClient8NotSafeForScripting1.Server = "ip";
            axMsRdpClient8NotSafeForScripting1.UserName = "login";
            axMsRdpClient8NotSafeForScripting1.AdvancedSettings2.ClearTextPassword = "senha";
            axMsRdpClient8NotSafeForScripting1.AdvancedSettings7.EnableCredSspSupport = true;


            //optional
            axMsRdpClient8NotSafeForScripting1.ColorDepth = 16;
            axMsRdpClient8NotSafeForScripting1.DesktopWidth = 1366;
            axMsRdpClient8NotSafeForScripting1.DesktopHeight = 768;
            //axMsRdpClient8NotSafeForScripting1.SecuredSettings.StartProgram = @"c:\windows\System32\calc.exe";
            axMsRdpClient8NotSafeForScripting1.Connect();


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (axMsRdpClient8NotSafeForScripting1.Connected.ToString() == "1")
                axMsRdpClient8NotSafeForScripting1.Disconnect();
        }

        private void bt00_Click(object sender, EventArgs e)
        {
            try
            {
                axMsRdpClient8NotSafeForScripting1.SecuredSettings.WorkDir.StartsWith(@"C:\windows\System32\calc.exe");
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void PnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
