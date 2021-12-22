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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DesigningCodes Designer = new DesigningCodes();
        private void frmMain_Load(object sender, EventArgs e)
        {
            Invoke((Action)(() => { Designer.FormShow(new frmHome(), pnlChangeForms); }));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pnlProfile_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblProfile, picProfile, pnlProfile, true);
        }

        private void pnlProfile_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblProfile, picProfile, pnlProfile, false);
        }

        private void pnlWalets_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblWalets, picWalets, pnlWalets, true);
        }

        private void pnlWalets_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblWalets, picWalets, pnlWalets, false);
        }

        private void pnlHome_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblHome, picHome, pnlHome, true);
        }

        private void pnlHome_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblHome, picHome, pnlHome, false);
        }

        private void pnlTransactions_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblTransactions, picTransactions, pnlTransactions, true);
        }

        private void pnlTransactions_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblTransactions, picTransactions, pnlTransactions, false);
        }

        private void pnlMarkets_MouseEnter(object sender, EventArgs e)
        {
            Designer.changeColor(lblMarkets, picMarkets, pnlMarkets, true);
        }

        private void pnlMarkets_MouseLeave(object sender, EventArgs e)
        {
            Designer.changeColor(lblMarkets, picMarkets, pnlMarkets, false);
        }
        private void TopWindowButtons_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void TopWindowButtons_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frnProfile(), pnlChangeForms);
        }

        private void pnlWalets_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmWallets(), pnlChangeForms);
        }

        private void pnlHome_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmHome(), pnlChangeForms);
        }

        private void pnlTransactions_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmTransactions(), pnlChangeForms);
        }

        private void pnlMarkets_Click(object sender, EventArgs e)
        {
            Designer.FormShow(new frmMarkets(), pnlChangeForms);
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

        private void btnExit_MouseClick(object sender, MouseEventArgs e)
        {
            btnExit.ForeColor = Color.White;
            btnMinimize.ForeColor = Color.White;
            btnMaximize.ForeColor = Color.White;
        }
    }
}
