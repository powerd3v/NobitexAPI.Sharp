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

namespace CryptoCurrencyTools
{
    public partial class frmWallets : Form
    {
        public frmWallets()
        {
            InitializeComponent();
        }
        ucCryptoCurrencyWalletControl walletControl;
        List<NobitexAPI.Sharp.Walets.Wallet> Wallets = new List<NobitexAPI.Sharp.Walets.Wallet>();
        private async void frmWallets_Load(object sender, EventArgs e)
        {
            try
            {
                GetWalets getWalets = new GetWalets();
                var Response = await getWalets.GetWaletsRequestAsync(API.Client);
                if (Response.status == "ok")
                {
                    Wallets.AddRange(Response.wallets);
                    foreach (var wallet in Response.wallets)
                    {
                        walletControl =
                        new ucCryptoCurrencyWalletControl(new Wallet()
                        {
                            activeBalance = wallet.activeBalance,
                            balance = wallet.balance,
                            blockedBalance = wallet.blockedBalance,
                            currency = wallet.currency,
                            depositAddress = wallet.depositAddress,
                            id = wallet.id,
                            rialBalance = wallet.rialBalance,
                            rialBalanceSell = wallet.rialBalanceSell,
                            user = wallet.user
                        })
                        {
                            Dock = DockStyle.Top
                        };
                        walletControl.click += WalletControl_click;
                        pnlWallets.Controls.Add(walletControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WalletControl_click(object sender, EventArgs e)
        {
            frmCustomCryptoWallet.WalletDatail = (sender as ucCryptoCurrencyWalletControl).wallet;
            new frmCustomCryptoWallet().ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchQuery.Text != "")
            {
                var wallet = Wallets.Where(x => x.currency == txtSearchQuery.Text).SingleOrDefault();
                walletControl =
                        new ucCryptoCurrencyWalletControl(new Wallet()
                        {
                            activeBalance = wallet.activeBalance,
                            balance = wallet.balance,
                            blockedBalance = wallet.blockedBalance,
                            currency = wallet.currency,
                            depositAddress = wallet.depositAddress,
                            id = wallet.id,
                            rialBalance = wallet.rialBalance,
                            rialBalanceSell = wallet.rialBalanceSell,
                            user = wallet.user
                        })
                        {
                            Dock = DockStyle.Top
                        };
                walletControl.click += WalletControl_click;
                pnlWallets.Controls.Add(walletControl);
            }
        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchQuery.Text == "")
            {
                pnlWallets.Controls.Clear();
                foreach (var wallet in Wallets)
                {
                    walletControl =
                    new ucCryptoCurrencyWalletControl(new Wallet()
                    {
                        activeBalance = wallet.activeBalance,
                        balance = wallet.balance,
                        blockedBalance = wallet.blockedBalance,
                        currency = wallet.currency,
                        depositAddress = wallet.depositAddress,
                        id = wallet.id,
                        rialBalance = wallet.rialBalance,
                        rialBalanceSell = wallet.rialBalanceSell,
                        user = wallet.user
                    })
                    {
                        Dock = DockStyle.Top
                    };
                    walletControl.click += WalletControl_click;
                    pnlWallets.Controls.Add(walletControl);
                }
            }
            else
            {
                var wallet = Wallets.Where(x => x.currency == txtSearchQuery.Text).SingleOrDefault();
                if (wallet !=null)
                {
                    pnlWallets.Controls.Clear();
                    walletControl =
                        new ucCryptoCurrencyWalletControl(new Wallet()
                        {
                            activeBalance = wallet.activeBalance,
                            balance = wallet.balance,
                            blockedBalance = wallet.blockedBalance,
                            currency = wallet.currency,
                            depositAddress = wallet.depositAddress,
                            id = wallet.id,
                            rialBalance = wallet.rialBalance,
                            rialBalanceSell = wallet.rialBalanceSell,
                            user = wallet.user
                        })
                        {
                            Dock = DockStyle.Top
                        };
                    walletControl.click += WalletControl_click;
                    pnlWallets.Controls.Add(walletControl);
                }
                
            }
        }
    }
}
