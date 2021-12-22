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
    public partial class ucTransactionHistory : UserControl
    {
        public ucTransactionHistory()
        {
            InitializeComponent();
        }
        string txtTransactionType;
        public string TransactionType
        {
            get
            {
                return txtTransactionType;
            }
            set
            {
                txtTransactionType = value;
                lblTransactionType.Text = txtTransactionType;
            }
        }
        string txtTransactionAmunt;
        public string TransactionAmunt
        {
            get
            {
                return txtTransactionAmunt;
            }
            set
            {
                txtTransactionAmunt = value;
                lblTransactionAmunt.Text = txtTransactionAmunt;
            }
        }
        string txtTransactionDate;
        public string TransactionDate
        {
            get
            {
                return txtTransactionDate;
            }
            set
            {
                txtTransactionDate = value;
                lblTransactionDate.Text = txtTransactionDate;
            }
        }
        string txtTransactionCoinName;
        public string TransactionCoinName
        {
            get
            {
                return txtTransactionCoinName;
            }
            set
            {
                txtTransactionCoinName = value;
                lblTransactionCoinName.Text = txtTransactionCoinName;
            }
        }
        string txtTransactionDetailes;
        public string TransactionDetailes
        {
            get
            {
                return txtTransactionDetailes;
            }
            set
            {
                txtTransactionDetailes = value;
                lblTransactionDetailes.Text = txtTransactionDetailes;
            }
        }
        string txtTransactionBalance;
        public string TransactionBalance
        {
            get
            {
                return txtTransactionBalance;
            }
            set
            {
                txtTransactionBalance = value;
                lblTransactionBalance.Text = txtTransactionBalance;
            }
        }
        string txtTransactionFee;
        public string TransactionFee
        {
            get
            {
                return txtTransactionFee;
            }
            set
            {
                txtTransactionFee = value;
                lblTransactionFee.Text = txtTransactionFee;
            }
        }
    }
}
