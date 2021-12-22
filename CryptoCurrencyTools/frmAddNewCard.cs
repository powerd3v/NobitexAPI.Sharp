using NobitexAPI.Sharp.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class frmAddNewCard : Form
    {
        public frmAddNewCard()
        {
            InitializeComponent();
        }

        private void rbAddCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddAccount.Checked)
            {
                txtBank.ResetText();
                txtCard.ResetText();
                txtShaba.ResetText();
                lblShaba.Visible = true;
                txtShaba.Visible = true;
            }
            else
            {
                txtBank.ResetText();
                txtCard.ResetText();
                txtShaba.ResetText();
                lblShaba.Visible = false;
                txtShaba.Visible = false;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAddAccount.Checked)
                {
                    AddBankAccount bankAccount = new AddBankAccount();
                    var response = await bankAccount.AddBankAccountRequestAsync(API.Client, txtBank.Text, Convert.ToInt64(txtCard.Text), txtShaba.Text);
                    MessageBox.Show(response.status, "Adding Status!");
                }
                else
                {
                    AddCard bankAccount = new AddCard();
                    var response = await bankAccount.AddCardRequestAsync(API.Client, txtBank.Text, Convert.ToInt64(txtCard.Text));
                    MessageBox.Show(response.status, "Adding Status!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private void lblNobitexDesktopTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
