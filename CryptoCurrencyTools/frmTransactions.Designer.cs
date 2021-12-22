
namespace CryptoCurrencyTools
{
    partial class frmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTopToolBar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbSymbols = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGetOpenOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbBid = new System.Windows.Forms.RadioButton();
            this.rbAsk = new System.Windows.Forms.RadioButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlNobitexOrders = new System.Windows.Forms.Panel();
            this.pnlAsksOrders = new System.Windows.Forms.Panel();
            this.pnlBidsOrders = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlCreateOrder = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnDoTransaction = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblMojodi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn100Percent = new System.Windows.Forms.Button();
            this.btn75Percent = new System.Windows.Forms.Button();
            this.btn50Percent = new System.Windows.Forms.Button();
            this.btn25Percent = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.worker = new System.Windows.Forms.Timer(this.components);
            this.pnlTopToolBar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlNobitexOrders.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCreateOrder.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopToolBar
            // 
            this.pnlTopToolBar.Controls.Add(this.panel4);
            this.pnlTopToolBar.Controls.Add(this.panel1);
            this.pnlTopToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopToolBar.Name = "pnlTopToolBar";
            this.pnlTopToolBar.Size = new System.Drawing.Size(510, 62);
            this.pnlTopToolBar.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 62);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cmbSymbols);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 62);
            this.panel6.TabIndex = 1;
            // 
            // cmbSymbols
            // 
            this.cmbSymbols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSymbols.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSymbols.FormattingEnabled = true;
            this.cmbSymbols.Items.AddRange(new object[] {
            "all",
            "BTC-IRT",
            "ETH-IRT",
            "LTC-IRT",
            "XRP-IRT",
            "BCH-IRT",
            "BNB-IRT",
            "EOS-IRT",
            "XLM-IRT",
            "ETC-IRT",
            "TRX-IRT",
            "DOGE-IRT",
            "UNI-IRT",
            "DAI-IRT",
            "LINK-IRT",
            "DOT-IRT",
            "AAVE-IRT",
            "ADA-IRT",
            "SHIB-IRT",
            "USDT-IRT",
            "BTC-USDT",
            "ETH-USDT",
            "LTC-USDT",
            "XRP-USDT",
            "BCH-USDT",
            "BNB-USDT",
            "EOS-USDT",
            "XLM-USDT",
            "ETC-USDT",
            "TRX-USDT",
            "PMN-USDT",
            "DOGE-USDT",
            "UNI-USDT",
            "DAI-USDT",
            "LINK-USDT",
            "DOT-USDT",
            "AAVE-USDT",
            "ADA-USDT",
            "SHIB-USDT"});
            this.cmbSymbols.Location = new System.Drawing.Point(8, 17);
            this.cmbSymbols.Name = "cmbSymbols";
            this.cmbSymbols.Size = new System.Drawing.Size(113, 33);
            this.cmbSymbols.TabIndex = 2;
            this.cmbSymbols.SelectedIndexChanged += new System.EventHandler(this.cmbSymbols_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGetOpenOrders);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(128, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 62);
            this.panel5.TabIndex = 2;
            // 
            // btnGetOpenOrders
            // 
            this.btnGetOpenOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGetOpenOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetOpenOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGetOpenOrders.FlatAppearance.BorderSize = 5;
            this.btnGetOpenOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOpenOrders.Font = new System.Drawing.Font("IRANSansDN", 13F);
            this.btnGetOpenOrders.ForeColor = System.Drawing.Color.White;
            this.btnGetOpenOrders.Location = new System.Drawing.Point(0, 0);
            this.btnGetOpenOrders.Name = "btnGetOpenOrders";
            this.btnGetOpenOrders.Size = new System.Drawing.Size(127, 62);
            this.btnGetOpenOrders.TabIndex = 2;
            this.btnGetOpenOrders.Text = "سفارشات باز";
            this.btnGetOpenOrders.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(255, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbBid);
            this.panel3.Controls.Add(this.rbAsk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 62);
            this.panel3.TabIndex = 1;
            // 
            // rbBid
            // 
            this.rbBid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbBid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbBid.Font = new System.Drawing.Font("IRANSansDN", 15.25F);
            this.rbBid.Location = new System.Drawing.Point(0, 0);
            this.rbBid.Name = "rbBid";
            this.rbBid.Padding = new System.Windows.Forms.Padding(10);
            this.rbBid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbBid.Size = new System.Drawing.Size(128, 62);
            this.rbBid.TabIndex = 2;
            this.rbBid.Text = "فروش";
            this.rbBid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBid.UseVisualStyleBackColor = false;
            this.rbBid.CheckedChanged += new System.EventHandler(this.rbBid_CheckedChanged);
            // 
            // rbAsk
            // 
            this.rbAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rbAsk.Checked = true;
            this.rbAsk.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbAsk.Font = new System.Drawing.Font("IRANSansDN", 15.25F);
            this.rbAsk.Location = new System.Drawing.Point(128, 0);
            this.rbAsk.Name = "rbAsk";
            this.rbAsk.Padding = new System.Windows.Forms.Padding(10);
            this.rbAsk.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbAsk.Size = new System.Drawing.Size(127, 62);
            this.rbAsk.TabIndex = 1;
            this.rbAsk.TabStop = true;
            this.rbAsk.Text = "خرید";
            this.rbAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAsk.UseVisualStyleBackColor = false;
            this.rbAsk.CheckedChanged += new System.EventHandler(this.rbAsk_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlNobitexOrders);
            this.pnlContainer.Controls.Add(this.pnlCreateOrder);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 62);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(510, 488);
            this.pnlContainer.TabIndex = 1;
            // 
            // pnlNobitexOrders
            // 
            this.pnlNobitexOrders.Controls.Add(this.pnlAsksOrders);
            this.pnlNobitexOrders.Controls.Add(this.pnlBidsOrders);
            this.pnlNobitexOrders.Controls.Add(this.panel2);
            this.pnlNobitexOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNobitexOrders.Font = new System.Drawing.Font("IRANSansDN", 12F);
            this.pnlNobitexOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlNobitexOrders.Name = "pnlNobitexOrders";
            this.pnlNobitexOrders.Size = new System.Drawing.Size(255, 488);
            this.pnlNobitexOrders.TabIndex = 1;
            // 
            // pnlAsksOrders
            // 
            this.pnlAsksOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsksOrders.Location = new System.Drawing.Point(0, 263);
            this.pnlAsksOrders.Name = "pnlAsksOrders";
            this.pnlAsksOrders.Size = new System.Drawing.Size(255, 225);
            this.pnlAsksOrders.TabIndex = 1;
            // 
            // pnlBidsOrders
            // 
            this.pnlBidsOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBidsOrders.Location = new System.Drawing.Point(0, 38);
            this.pnlBidsOrders.Name = "pnlBidsOrders";
            this.pnlBidsOrders.Size = new System.Drawing.Size(255, 225);
            this.pnlBidsOrders.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 38);
            this.panel2.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(0, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmount.Size = new System.Drawing.Size(128, 38);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "مقدار (TRX)";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrice.Location = new System.Drawing.Point(128, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(127, 38);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "قیمت (USDT)";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCreateOrder
            // 
            this.pnlCreateOrder.Controls.Add(this.panel13);
            this.pnlCreateOrder.Controls.Add(this.panel12);
            this.pnlCreateOrder.Controls.Add(this.panel11);
            this.pnlCreateOrder.Controls.Add(this.panel10);
            this.pnlCreateOrder.Controls.Add(this.panel9);
            this.pnlCreateOrder.Controls.Add(this.panel8);
            this.pnlCreateOrder.Controls.Add(this.panel7);
            this.pnlCreateOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCreateOrder.Font = new System.Drawing.Font("IRANSansDN", 12F);
            this.pnlCreateOrder.Location = new System.Drawing.Point(255, 0);
            this.pnlCreateOrder.Name = "pnlCreateOrder";
            this.pnlCreateOrder.Size = new System.Drawing.Size(255, 488);
            this.pnlCreateOrder.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnDoTransaction);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 406);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10);
            this.panel13.Size = new System.Drawing.Size(255, 82);
            this.panel13.TabIndex = 8;
            // 
            // btnDoTransaction
            // 
            this.btnDoTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDoTransaction.FlatAppearance.BorderSize = 4;
            this.btnDoTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoTransaction.Font = new System.Drawing.Font("IRANSansDN", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnDoTransaction.Location = new System.Drawing.Point(10, 10);
            this.btnDoTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoTransaction.Name = "btnDoTransaction";
            this.btnDoTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDoTransaction.Size = new System.Drawing.Size(235, 62);
            this.btnDoTransaction.TabIndex = 6;
            this.btnDoTransaction.Text = "خرید";
            this.btnDoTransaction.UseVisualStyleBackColor = false;
            this.btnDoTransaction.Click += new System.EventHandler(this.btnDoTransaction_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblMojodi);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 331);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(255, 75);
            this.panel12.TabIndex = 7;
            // 
            // lblMojodi
            // 
            this.lblMojodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMojodi.Location = new System.Drawing.Point(0, 0);
            this.lblMojodi.Name = "lblMojodi";
            this.lblMojodi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblMojodi.Size = new System.Drawing.Size(157, 75);
            this.lblMojodi.TabIndex = 3;
            this.lblMojodi.Text = "0";
            this.lblMojodi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(157, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(98, 75);
            this.label6.TabIndex = 3;
            this.label6.Text = "در دسترس :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn100Percent);
            this.panel11.Controls.Add(this.btn75Percent);
            this.panel11.Controls.Add(this.btn50Percent);
            this.panel11.Controls.Add(this.btn25Percent);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 276);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(255, 55);
            this.panel11.TabIndex = 6;
            // 
            // btn100Percent
            // 
            this.btn100Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn100Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn100Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn100Percent.FlatAppearance.BorderSize = 5;
            this.btn100Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100Percent.Font = new System.Drawing.Font("IRANSansDN", 9.5F);
            this.btn100Percent.ForeColor = System.Drawing.Color.Yellow;
            this.btn100Percent.Location = new System.Drawing.Point(0, 0);
            this.btn100Percent.Name = "btn100Percent";
            this.btn100Percent.Size = new System.Drawing.Size(66, 55);
            this.btn100Percent.TabIndex = 7;
            this.btn100Percent.Text = "100%";
            this.btn100Percent.UseVisualStyleBackColor = false;
            // 
            // btn75Percent
            // 
            this.btn75Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn75Percent.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn75Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn75Percent.FlatAppearance.BorderSize = 5;
            this.btn75Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn75Percent.Font = new System.Drawing.Font("IRANSansDN", 9.5F);
            this.btn75Percent.ForeColor = System.Drawing.Color.Yellow;
            this.btn75Percent.Location = new System.Drawing.Point(66, 0);
            this.btn75Percent.Name = "btn75Percent";
            this.btn75Percent.Size = new System.Drawing.Size(63, 55);
            this.btn75Percent.TabIndex = 6;
            this.btn75Percent.Text = "75%";
            this.btn75Percent.UseVisualStyleBackColor = false;
            // 
            // btn50Percent
            // 
            this.btn50Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn50Percent.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn50Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn50Percent.FlatAppearance.BorderSize = 5;
            this.btn50Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50Percent.Font = new System.Drawing.Font("IRANSansDN", 9.5F);
            this.btn50Percent.ForeColor = System.Drawing.Color.Yellow;
            this.btn50Percent.Location = new System.Drawing.Point(129, 0);
            this.btn50Percent.Name = "btn50Percent";
            this.btn50Percent.Size = new System.Drawing.Size(63, 55);
            this.btn50Percent.TabIndex = 5;
            this.btn50Percent.Text = "50%";
            this.btn50Percent.UseVisualStyleBackColor = false;
            // 
            // btn25Percent
            // 
            this.btn25Percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn25Percent.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn25Percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn25Percent.FlatAppearance.BorderSize = 5;
            this.btn25Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25Percent.Font = new System.Drawing.Font("IRANSansDN", 9.5F);
            this.btn25Percent.ForeColor = System.Drawing.Color.Yellow;
            this.btn25Percent.Location = new System.Drawing.Point(192, 0);
            this.btn25Percent.Name = "btn25Percent";
            this.btn25Percent.Size = new System.Drawing.Size(63, 55);
            this.btn25Percent.TabIndex = 4;
            this.btn25Percent.Text = "25%";
            this.btn25Percent.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button5);
            this.panel10.Controls.Add(this.button6);
            this.panel10.Controls.Add(this.textBox3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 207);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(255, 69);
            this.panel10.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(204, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(9, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 33);
            this.button6.TabIndex = 3;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 33);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "مجموع (USDT)";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.button4);
            this.panel9.Controls.Add(this.textBox2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 138);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(255, 69);
            this.panel9.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(204, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(9, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 33);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "مقدار (TRX)";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 69);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 69);
            this.panel8.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(204, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IRANSansDN", 16F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(7, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "قیمت (USDT)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmbOrderType);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 69);
            this.panel7.TabIndex = 2;
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "سفارش محدود",
            "سفارش سریع"});
            this.cmbOrderType.Location = new System.Drawing.Point(9, 18);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(234, 33);
            this.cmbOrderType.TabIndex = 2;
            // 
            // worker
            // 
            this.worker.Interval = 2000;
            this.worker.Tick += new System.EventHandler(this.worker_Tick);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(510, 550);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTopToolBar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(510, 550);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.pnlTopToolBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlNobitexOrders.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCreateOrder.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopToolBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbSymbols;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGetOpenOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbBid;
        private System.Windows.Forms.RadioButton rbAsk;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlNobitexOrders;
        private System.Windows.Forms.Panel pnlAsksOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Panel pnlCreateOrder;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblMojodi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn25Percent;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Panel pnlBidsOrders;
        private System.Windows.Forms.Timer worker;
        private System.Windows.Forms.Button btnDoTransaction;
        private System.Windows.Forms.Button btn100Percent;
        private System.Windows.Forms.Button btn75Percent;
        private System.Windows.Forms.Button btn50Percent;
    }
}