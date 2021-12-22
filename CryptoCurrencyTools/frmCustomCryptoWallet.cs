using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NobitexAPI.Sharp.Walets;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CryptoCurrencyTools
{
    public partial class frmCustomCryptoWallet : Form
    {
        public static Wallet WalletDatail { get; set; }
        public frmCustomCryptoWallet()
        {
            InitializeComponent();
        }
        ucTransactionHistory UcTransaction;
        private async void btnGetTransactionHistory_Click(object sender, EventArgs e)
        {
            GetDeposits getDeposits = new GetDeposits();
            var Deposits = await getDeposits.GetDepositsRequestAsync(API.Client, WalletDatail.id);
            GetTransactions getTransactions = new GetTransactions();
            var Transactions = await getTransactions.GetTransactionsRequestAsync(API.Client, WalletDatail.id);
            if (Deposits.status == "ok")
            {
                foreach (Deposit item in Deposits.deposits)
                {
                    UcTransaction = new ucTransactionHistory()
                    {
                        Dock = DockStyle.Top,
                        TransactionType = "واریز",
                        TransactionAmunt = item.amount,
                        TransactionDate = item.transaction.created_at.ToString("yyyy/MM/dd HH:mm:ss"),
                        TransactionCoinName = item.currency.ToUpper(),
                        TransactionDetailes = item.transaction.description,
                        TransactionFee = item.transaction.calculatedFee,
                        TransactionBalance = WalletDatail.rialBalance.ToString()
                    };
                    pnlShowData.Controls.Add(UcTransaction);
                }
                foreach (Withdraw item in Deposits.withdraws)
                {
                    UcTransaction = new ucTransactionHistory()
                    {
                        Dock = DockStyle.Top,
                        TransactionType = "برداشت",
                        TransactionAmunt = item.amount,
                        TransactionDate = item.createdAt.ToString("yyyy/MM/dd HH:mm:ss"),
                        TransactionCoinName = item.currency.ToUpper(),
                        TransactionDetailes = item.address,
                        TransactionFee = "کارمزد: -",
                        TransactionBalance = WalletDatail.rialBalance.ToString()
                    };
                    pnlShowData.Controls.Add(UcTransaction);
                }
            }
            if (Transactions.status == "ok")
            {
                foreach (Transaction item in Transactions.transactions)
                {
                    UcTransaction = new ucTransactionHistory()
                    {
                        Dock = DockStyle.Top,
                        TransactionType = "معامله",
                        TransactionAmunt = item.amount,
                        TransactionDate = item.created_at.ToString("yyyy/MM/dd HH:mm:ss"),
                        TransactionCoinName = item.currency.ToUpper(),
                        TransactionDetailes = item.description,
                        TransactionFee = "کارمزد: " + item.calculatedFee,
                        TransactionBalance = WalletDatail.rialBalance.ToString()
                    };
                    pnlShowData.Controls.Add(UcTransaction);
                }
            }
        }

        private void frmCustomCryptoWallet_Load(object sender, EventArgs e)
        {
            lblEnCoinName.Text = WalletDatail.currency.ToUpper();
            lblFaCoinName.Text = GetCurrencyName(WalletDatail.currency.ToUpper());
            lblBalance.Text = WalletDatail.balance;
            lblActiveBalance.Text = WalletDatail.activeBalance;
            lblInOrder.Text = WalletDatail.rialBalanceSell.ToString();
            lblRialBalance.Text = WalletDatail.rialBalance.ToString();
        }
        private string GetCurrencyName(string data)
        {
            if (data == "RLS")
            {
                this.picCoinLogo.Image = Properties.Resources.IRT;
                return $"تومان";
            }
            else if (data == "USDT")
            {
                this.picCoinLogo.Image = Properties.Resources.USDT;
                return $"تتر";
            }
            else if (data == "BTC")
            {
                this.picCoinLogo.Image = Properties.Resources.BTC;
                return $"بیت کوین";
            }
            else if (data == "ETH")
            {
                this.picCoinLogo.Image = Properties.Resources.ETH;
                return $"اتریوم";
            }
            else if (data == "LTC")
            {
                this.picCoinLogo.Image = Properties.Resources.LTC;
                return $"لایت کوین";
            }
            else if (data == "USD")
            {
                this.picCoinLogo.Image = Properties.Resources.USD;
                return $"دلار";
            }
            else if (data == "XRP")
            {
                this.picCoinLogo.Image = Properties.Resources.XRP;
                return $"ریپل";
            }
            else if (data == "BCH")
            {
                this.picCoinLogo.Image = Properties.Resources.BCH;
                return $"بیت کوین کش";
            }
            else if (data == "BNB")
            {
                this.picCoinLogo.Image = Properties.Resources.BNB;
                return $"بایننس کوین";
            }
            else if (data == "EOS")
            {
                this.picCoinLogo.Image = Properties.Resources.EOS;
                return $"ایاس";
            }
            else if (data == "DOGE")
            {
                this.picCoinLogo.Image = Properties.Resources.DOGE;
                return $"دوج کوین";
            }
            else if (data == "XLM")
            {
                this.picCoinLogo.Image = Properties.Resources.XLM;
                return $"استلار";
            }
            else if (data == "TRX")
            {
                this.picCoinLogo.Image = Properties.Resources.TRX;
                return $"ترون";
            }
            else if (data == "ADA")
            {
                this.picCoinLogo.Image = Properties.Resources.ADA;
                return $"کاردانو";
            }
            else if (data == "XMR")
            {
                this.picCoinLogo.Image = Properties.Resources.XMR;
                return $"مونرو";
            }
            else if (data == "XEM")
            {
                this.picCoinLogo.Image = Properties.Resources.XEM;
                return $"نم";
            }
            else if (data == "IOTA")
            {
                this.picCoinLogo.Image = Properties.Resources.IOTA;
                return $"آیوتا";
            }
            else if (data == "ETC")
            {
                this.picCoinLogo.Image = Properties.Resources.ETH;
                return $"اتریوم کلاسیک";
            }
            else if (data == "DASH")
            {
                this.picCoinLogo.Image = Properties.Resources.DASH;
                return $"دش کوین";
            }
            else if (data == "ZEC")
            {
                this.picCoinLogo.Image = Properties.Resources.ZEC;
                return $"زی کش";
            }
            else if (data == "NEO")
            {
                this.picCoinLogo.Image = Properties.Resources.NEO;
                return $"نئو";
            }
            else if (data == "QTUM")
            {
                this.picCoinLogo.Image = Properties.Resources.QTUM;
                return $"کوانتوم";
            }
            else if (data == "XTZ")
            {
                this.picCoinLogo.Image = Properties.Resources.XTZ;
                return $"تزوس";
            }
            else
            {
                this.picCoinLogo.Image = Properties.Resources.AC;
                return $"ارز ناشناس";
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
