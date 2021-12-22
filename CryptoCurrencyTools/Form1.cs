using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NobitexAPI.Sharp.Athentication;
using System.IO;
using NobitexAPI.Sharp;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CryptoCurrencyTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            bgWorker.RunWorkerAsync();
        }
        string path = Application.StartupPath + "\\nobitex.json";
        private void saveSettings(NobitexClient nobitex)
        {
            string data = JsonConvert.SerializeObject(nobitex);
            using (FileStream fs = File.Create(path))
            {
                fs.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
                fs.Flush(); fs.Dispose(); fs.Close();
            }
        }
        private async void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                API_Type _Type = API_Type.RealAccount;
                if (cbAPIType.Checked)
                    _Type = API_Type.TestNet;
                if (rbAccount.Checked)
                {
                    if (txtEmail.Text == "" || txtPassword.Text == "") return;
                    CreateToken TokenGenerator = new CreateToken();
                    var token = await TokenGenerator.CreateTokenRequestAsync(new TokenCeredinals()
                    {
                        UserName = txtEmail.Text,
                        Password = txtPassword.Text,
                        Captcha = CaptchaType.api,
                        LongTimeToken = RememberType.yes,
                        OTP = txtOTP.Text,
                        Nobitex_API_Type = _Type
                    });
                    if (cbRemember.Checked)
                    {
                        saveSettings(new NobitexClient(token.key, _Type));
                    }
                    MessageBox.Show($"Status:\r\n{token.status}\r\nDevice:{token.device}\r\nAPI KEY:\r\n{token.key}", "Your Token Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    API.Client = new NobitexClient(token.key,_Type);
                    Clipboard.SetText(token.key);
                }
                else
                {
                    API.Client = new NobitexClient(txtEmail.Text, _Type);
                    Clipboard.SetText(txtEmail.Text);
                    if (cbRemember.Checked)
                    {
                        saveSettings(new NobitexClient(txtEmail.Text, _Type));

                    }
                    this.Hide();
                    new frmMain().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnLogin.Enabled = true;
            this.Hide();
            new frmMain().Show();
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void rbAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAPI.Checked)
            {
                lblPassword.Visible = false;
                lblOtp.Visible = false;
                txtPassword.Visible = false;
                txtOTP.Visible = false;
                lblEmail.Text = "API Key:";
            }
            else
            {
                lblPassword.Visible = true;
                lblOtp.Visible = true;
                txtPassword.Visible = true;
                txtOTP.Visible = true;
                lblEmail.Text = "Email:";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
