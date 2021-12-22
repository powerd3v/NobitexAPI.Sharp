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
    public partial class ucBankAccountControl : UserControl
    {
        public ucBankAccountControl()
        {
            InitializeComponent();
        }
        private string uc_title = "حساب های بانکی";
        private string uc_card_number = "IR482823...";
        private string uc_card_name = "ملت";
        private string uc_card_status = "تایید شده";
        private Color uc_card_status_color = Color.LimeGreen;
        public string Uc_title
        {
            get => uc_title; set
            {
                uc_title = value;
                lblTitle.Text = Uc_title;
            }
        }
        public string Uc_card_number
        {
            get => uc_card_number; set
            {
                uc_card_number = value;
                lblCardNumber.Text = uc_card_number;
            }
        }
        public string Uc_card_name
        {
            get => uc_card_name; set
            {
                uc_card_name = value;
                lblCardName.Text = uc_card_name;
            }
        }
        public string Uc_card_status
        {
            get => uc_card_status; set
            {
                uc_card_status = value;
                lblCardStatus.Text = uc_card_status;
            }
        }
        public Color Uc_card_status_color
        {
            get => uc_card_status_color; set
            {
                uc_card_status_color = value;
                lblCardStatus.ForeColor = uc_card_status_color;
            }
        }
        public event EventHandler AddNewCard;
        void AddNewCardClick(object sender, EventArgs e)
        {
            AddNewCard(this, new EventArgs());
        }

        private void picRemoveThisCard_Click(object sender, EventArgs e)
        {
            AddNewCardClick(sender, e);
        }
    }
}
