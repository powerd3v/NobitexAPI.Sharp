using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NobitexAPI.Sharp.PublicMarket;
using NobitexAPI.Sharp.Market;
using System.Windows.Forms;

namespace CryptoCurrencyTools
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            cmbOrderType.SelectedIndex = 0;
            cmbSymbols.SelectedIndex = 1;
            worker.Start();
        }

        private async void worker_Tick(object sender, EventArgs e)
        {
            GetOrders orders = new GetOrders();
            var response = await orders.GetOrdersRequestAsync(API.Client,symbolsType);
            var mojodi = await new NobitexAPI.Sharp.Walets.Balance().GetBalanceRequestAsync(API.Client, CurrencyType.rls);
            pnlBidsOrders.Controls.Clear();
            pnlAsksOrders.Controls.Clear();
            if (lblMojodi.InvokeRequired)
            {
                lblMojodi.Invoke(new Action(() =>
                {
                    lblMojodi.Text = mojodi.balance;
                }));
            }
            else
            {
                lblMojodi.Text = mojodi.balance;
            }
            if (response is OrderBookResponse)
            {
                await SetOrders(response as OrderBookResponse);
            }
            else
            {
                var result = response as OrderBookAllResponse;
                foreach (var order in result.Orders())
                {
                    await SetOrders(order);
                }
            }
        }
        private async Task SetOrders(IOrder order)
        {
            await Task.Run(new Action(() =>
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        var item = order.asks[i];
                        int value = Convert.ToInt32((Convert.ToDouble(item[1]) * Convert.ToDouble(item[0]) * 100) / 5000000000);
                        if (value >= 100)
                            value = 100;
                        var control = new ucTransactionLable()
                        {
                            Dock = DockStyle.Top,
                            Transaction_lable_back_color = Color.FromArgb(30, 30, 30),
                            Transaction_lable_fore_color = Color.White,
                            Transaction_lable_progress_color = Color.LimeGreen,
                            Transaction_lable_tl_data = new TL_Data()
                            {
                                Amount = Convert.ToDouble(item[1]),
                                Maximum = 100,
                                Price = Convert.ToDouble(item[0]),
                                ProgressValue = value
                            }

                        };
                        pnlBidsOrders.Invoke(new Action(() =>
                        {
                            pnlBidsOrders.Controls.Add(control);
                        }));
                    }
                }
                catch (Exception ex)
                {
                    worker.Stop();
                    MessageBox.Show(ex.Message);
                }
            }));
            await Task.Run(new Action(() =>
            {
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        var item = order.bids[i];
                        int value = Convert.ToInt32((Convert.ToDouble(item[1]) * Convert.ToDouble(item[0]) * 100) / 5000000000);
                        if (value >= 100)
                            value = 100;
                        var control = new ucTransactionLable()
                        {
                            Dock = DockStyle.Top,
                            Transaction_lable_back_color = Color.FromArgb(30, 30, 30),
                            Transaction_lable_fore_color = Color.White,
                            Transaction_lable_progress_color = Color.Crimson,
                            Transaction_lable_tl_data = new TL_Data()
                            {
                                Amount = Convert.ToDouble(item[1]),
                                Maximum = 100,
                                Price = Convert.ToDouble(item[0]),
                                ProgressValue = value
                            }

                        };
                        pnlAsksOrders.Invoke(new Action(() =>
                        {
                            pnlAsksOrders.Controls.Add(control);
                        }));
                    }
                }
                catch (Exception ex)
                {
                    worker.Stop();
                    MessageBox.Show(ex.Message);
                }
            }));
        }
        SymbolsType symbolsType;
        private void cmbSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSymbols.Text != "all")
            {
                lblPrice.Text = $"قیمت ({cmbSymbols.Text.Split('-')[1]})";
                lblAmount.Text = $"مقدار ({cmbSymbols.Text.Split('-')[0]})";
                foreach (var item in (SymbolsType[])Enum.GetValues(typeof(SymbolsType)))
                {
                    var symbol = cmbSymbols.Text.Split('-');
                    if (symbol[0] + symbol[1] == item.ToString())
                    {
                        symbolsType = item;
                        break;
                    }
                }
                worker.Interval = 4000;
            }
            else
            {
                lblPrice.Text = $"قیمت (all)";
                lblAmount.Text = $"مقدار (all)";
                symbolsType = SymbolsType.all;
                worker.Interval = 60000;
            }
        }

        private void rbAsk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAsk.Checked)
            {
                btnDoTransaction.BackColor = Color.FromArgb(128, 255, 128);
                btnDoTransaction.Text = "خرید";
            }
        }

        private void rbBid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBid.Checked)
            {
                btnDoTransaction.BackColor = Color.FromArgb(255, 128, 128);
                btnDoTransaction.Text = "فروش";
            }
        }

        private async void btnDoTransaction_Click(object sender, EventArgs e)
        {
            var AddNewOrder = new AddOrder();
            CurrencyType currencydst = CurrencyType.rls;
            foreach (var item in Enum.GetValues(typeof(CurrencyType)) as CurrencyType[])
            {
                var symbol = cmbSymbols.Text.Split('-');
                if (symbol[1].ToLower() == item.ToString())
                {
                    currencydst = item;
                    break;
                }
            }
            CurrencyType currencysrc = CurrencyType.btc;
            foreach (var item in Enum.GetValues(typeof(CurrencyType)) as CurrencyType[])
            {
                var symbol = cmbSymbols.Text.Split('-');
                if (symbol[0].ToLower() == item.ToString())
                {
                    currencysrc = item;
                    break;
                }
            }
            OrderExecution execution = OrderExecution.limit;
            if (cmbOrderType.Text.Contains("محدود")) execution = OrderExecution.limit;
            else execution = OrderExecution.market;
            OrderType orderType = OrderType.buy;
            if (rbAsk.Checked) orderType = OrderType.buy;
            else orderType = OrderType.sell;
            AddOrderResponse response = await AddNewOrder.AddOrderRequestAsync(API.Client, new OrderCeredinals()
            {
                Type = orderType,
                DestonationCurrency = currencydst,
                SourceCurrency = currencysrc,
                Execution = execution,
                Amount = Convert.ToDouble("txtAmount"),
                Price = Convert.ToDouble("txtAmount")
            });
            if (response.status == "ok") MessageBox.Show(response.order.status);
            else MessageBox.Show(response.status);
        }
    }
}
