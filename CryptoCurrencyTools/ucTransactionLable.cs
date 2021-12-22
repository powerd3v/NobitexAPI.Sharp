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
    public partial class ucTransactionLable : UserControl
    {
        public ucTransactionLable()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private Color transaction_lable_back_color;
        private Color transaction_lable_fore_color;
        private Color transaction_lable_progress_color;
        private TL_Data transaction_lable_tl_data = new TL_Data();

        [Category("Power Developer")]
        public Color Transaction_lable_back_color
        {
            get => transaction_lable_back_color;
            set
            {
                transaction_lable_back_color = value;
                this.BackColor = transaction_lable_back_color;
                lblAmount.BackColor = transaction_lable_back_color;
                pbChart.BackColor = transaction_lable_back_color;
                pbChart.ChannelColor = transaction_lable_back_color;
            }
        }
        [Category("Power Developer")]
        public Color Transaction_lable_fore_color
        {
            get => transaction_lable_fore_color;
            set
            {
                transaction_lable_fore_color = value;
                this.ForeColor = transaction_lable_fore_color;
                lblAmount.ForeColor = transaction_lable_fore_color;
                pbChart.ForeColor = transaction_lable_fore_color;
            }
        }
        [Category("Power Developer")]
        public Color Transaction_lable_progress_color
        {
            get => transaction_lable_progress_color;
            set
            {
                transaction_lable_progress_color = value;
                pbChart.SliderColor = transaction_lable_progress_color;
            }
        }
        [Category("Power Developer")]
        public TL_Data Transaction_lable_tl_data
        {
            get => transaction_lable_tl_data;
            set
            {
                transaction_lable_tl_data = value;
                pbChart.Value = transaction_lable_tl_data.ProgressValue;
                pbChart.PriceNumber = transaction_lable_tl_data.Price;
                lblAmount.Text = transaction_lable_tl_data.Amount.ToString();
                pbChart.Maximum = transaction_lable_tl_data.Maximum;
            }
        }
    }
    [Serializable()]
    public class TL_Data
    {
        public double Amount { get; set; }
        public double Price { get; set; }
        public int ProgressValue { get; set; }
        public int Maximum { get; set; }
    }
}
