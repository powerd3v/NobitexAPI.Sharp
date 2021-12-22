using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class ucCryptoCurrencyWalletControl : UserControl
    {
        public Wallet wallet { get; set; }
        public ucCryptoCurrencyWalletControl(Wallet walletData)
        {
            InitializeComponent();
            wallet = walletData;
            var CurrencyNames = GetCurrencyName(walletData.currency.ToUpper());
            lblEnCurrency.Text = walletData.currency.ToUpper();
            txtFaCurrency.Text = walletData.rialBalance.ToString();
            txtEnCurrency.Text = walletData.balance;
            lblCryptoName.Text = CurrencyNames;
        }
        public event EventHandler click;
        private void btnShowCryptoInfo_Click(object sender, EventArgs e)
        {
            click(this, new EventArgs());
        }
        private string GetCurrencyName(string data)
        {
            if (data == "RLS")
            {
                this.picCryptoProfile.Image = Properties.Resources.IRT;
                return $"RLS (تومان)";
            }
            else if (data == "USDT")
            {
                this.picCryptoProfile.Image = Properties.Resources.USDT;
                return $"USDT (تتر)";
            }
            else if (data == "BTC")
            {
                this.picCryptoProfile.Image = Properties.Resources.BTC;
                return $"BTC (بیت کوین)";
            }
            else if (data == "ETH")
            {
                this.picCryptoProfile.Image = Properties.Resources.ETH;
                return $"ETH (اتریوم)";
            }
            else if (data == "LTC")
            {
                this.picCryptoProfile.Image = Properties.Resources.LTC;
                return $"LTC (لایت کوین)";
            }
            else if (data == "USD")
            {
                this.picCryptoProfile.Image = Properties.Resources.USD;
                return $"USD (دلار)";
            }
            else if (data == "XRP")
            {
                this.picCryptoProfile.Image = Properties.Resources.XRP;
                return $"XRP (ریپل)";
            }
            else if (data == "BCH")
            {
                this.picCryptoProfile.Image = Properties.Resources.BCH;
                return $"BCH (بیت کوین کش)";
            }
            else if (data == "BNB")
            {
                this.picCryptoProfile.Image = Properties.Resources.BNB;
                return $"BNB (بایننس کوین)";
            }
            else if (data == "EOS")
            {
                this.picCryptoProfile.Image = Properties.Resources.EOS;
                return $"EOS (ایاس)";
            }
            else if (data == "DOGE")
            {
                this.picCryptoProfile.Image = Properties.Resources.DOGE;
                return $"DOGE (دوج کوین)";
            }
            else if (data == "XLM")
            {
                this.picCryptoProfile.Image = Properties.Resources.XLM;
                return $"XLM (استلار)";
            }
            else if (data == "TRX")
            {
                this.picCryptoProfile.Image = Properties.Resources.TRX;
                return $"TRX (ترون)";
            }
            else if (data == "ADA")
            {
                this.picCryptoProfile.Image = Properties.Resources.ADA;
                return $"ADA (کاردانو)";
            }
            else if (data == "XMR")
            {
                this.picCryptoProfile.Image = Properties.Resources.XMR;
                return $"XMR (مونرو)";
            }
            else if (data == "XEM")
            {
                this.picCryptoProfile.Image = Properties.Resources.XEM;
                return $"XEM (نم)";
            }
            else if (data == "IOTA")
            {
                this.picCryptoProfile.Image = Properties.Resources.IOTA;
                return $"IOTA (آیوتا)";
            }
            else if (data == "ETC")
            {
                this.picCryptoProfile.Image = Properties.Resources.ETC;
                return $"ETC (اتریوم کلاسیک)";
            }
            else if (data == "DASH")
            {
                this.picCryptoProfile.Image = Properties.Resources.DASH;
                return $"DASH (دش کوین)";
            }
            else if (data == "ZEC")
            {
                this.picCryptoProfile.Image = Properties.Resources.ZEC;
                return $"ZEC (زی کش)";
            }
            else if (data == "NEO")
            {
                this.picCryptoProfile.Image = Properties.Resources.NEO;
                return $"NEO (نئو)";
            }
            else if (data == "QTUM")
            {
                this.picCryptoProfile.Image = Properties.Resources.QTUM;
                return $"QTUM (کوانتوم)";
            }
            else if (data == "XTZ")
            {
                this.picCryptoProfile.Image = Properties.Resources.XTZ;
                return $"XTZ (تزوس)";
            }
            else
            {
                this.picCryptoProfile.Image = Properties.Resources.AC;
                return $"ارز ناشناس";
            }
        }
    }
    public class Wallet
    {
        public string activeBalance { get; set; }
        public string blockedBalance { get; set; }
        public string user { get; set; }
        public string currency { get; set; }
        public int id { get; set; }
        public string balance { get; set; }
        public int rialBalance { get; set; }
        public int rialBalanceSell { get; set; }
        public object depositAddress { get; set; }
    }
}
