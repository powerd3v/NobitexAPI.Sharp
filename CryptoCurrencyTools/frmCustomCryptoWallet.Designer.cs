
namespace CryptoCurrencyTools
{
    partial class frmCustomCryptoWallet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNobitexDesktopTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTopMenuBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlShowData = new System.Windows.Forms.Panel();
            this.pnlCoinData = new System.Windows.Forms.Panel();
            this.pnlDinamicData = new System.Windows.Forms.Panel();
            this.lblRialBalance = new System.Windows.Forms.Label();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.lblActiveBalance = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlStaticData = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtonBox = new System.Windows.Forms.Panel();
            this.btnGetTransactionHistory = new System.Windows.Forms.Button();
            this.pnlCoinProfile = new System.Windows.Forms.Panel();
            this.lblFaCoinName = new System.Windows.Forms.Label();
            this.lblEnCoinName = new System.Windows.Forms.Label();
            this.picCoinLogo = new System.Windows.Forms.PictureBox();
            this.pnlTopMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlCoinData.SuspendLayout();
            this.pnlDinamicData.SuspendLayout();
            this.pnlStaticData.SuspendLayout();
            this.pnlButtonBox.SuspendLayout();
            this.pnlCoinProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoinLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 443);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(388, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 443);
            this.panel2.TabIndex = 23;
            // 
            // lblNobitexDesktopTitle
            // 
            this.lblNobitexDesktopTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNobitexDesktopTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNobitexDesktopTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblNobitexDesktopTitle.Location = new System.Drawing.Point(45, 0);
            this.lblNobitexDesktopTitle.Name = "lblNobitexDesktopTitle";
            this.lblNobitexDesktopTitle.Size = new System.Drawing.Size(301, 25);
            this.lblNobitexDesktopTitle.TabIndex = 4;
            this.lblNobitexDesktopTitle.Text = "Coin Details";
            this.lblNobitexDesktopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNobitexDesktopTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNobitexDesktopTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimize.Location = new System.Drawing.Point(346, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "ــــــ";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(371, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTopMenuBar
            // 
            this.pnlTopMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.pnlTopMenuBar.Controls.Add(this.lblNobitexDesktopTitle);
            this.pnlTopMenuBar.Controls.Add(this.pictureBox1);
            this.pnlTopMenuBar.Controls.Add(this.btnMinimize);
            this.pnlTopMenuBar.Controls.Add(this.btnExit);
            this.pnlTopMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenuBar.Name = "pnlTopMenuBar";
            this.pnlTopMenuBar.Size = new System.Drawing.Size(396, 25);
            this.pnlTopMenuBar.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CryptoCurrencyTools.Properties.Resources.nobitex;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNobitexDesktopTitle_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(20)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 21);
            this.panel3.TabIndex = 25;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnlShowData);
            this.pnlForm.Controls.Add(this.pnlCoinData);
            this.pnlForm.Controls.Add(this.pnlCoinProfile);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(8, 25);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(380, 443);
            this.pnlForm.TabIndex = 26;
            // 
            // pnlShowData
            // 
            this.pnlShowData.AutoScroll = true;
            this.pnlShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowData.Location = new System.Drawing.Point(0, 290);
            this.pnlShowData.Name = "pnlShowData";
            this.pnlShowData.Padding = new System.Windows.Forms.Padding(10);
            this.pnlShowData.Size = new System.Drawing.Size(380, 153);
            this.pnlShowData.TabIndex = 2;
            // 
            // pnlCoinData
            // 
            this.pnlCoinData.Controls.Add(this.pnlDinamicData);
            this.pnlCoinData.Controls.Add(this.pnlStaticData);
            this.pnlCoinData.Controls.Add(this.pnlButtonBox);
            this.pnlCoinData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoinData.Location = new System.Drawing.Point(0, 112);
            this.pnlCoinData.Name = "pnlCoinData";
            this.pnlCoinData.Size = new System.Drawing.Size(380, 178);
            this.pnlCoinData.TabIndex = 1;
            // 
            // pnlDinamicData
            // 
            this.pnlDinamicData.Controls.Add(this.lblRialBalance);
            this.pnlDinamicData.Controls.Add(this.lblInOrder);
            this.pnlDinamicData.Controls.Add(this.lblActiveBalance);
            this.pnlDinamicData.Controls.Add(this.lblBalance);
            this.pnlDinamicData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDinamicData.Location = new System.Drawing.Point(0, 0);
            this.pnlDinamicData.Name = "pnlDinamicData";
            this.pnlDinamicData.Size = new System.Drawing.Size(222, 140);
            this.pnlDinamicData.TabIndex = 2;
            // 
            // lblRialBalance
            // 
            this.lblRialBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRialBalance.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.lblRialBalance.Location = new System.Drawing.Point(0, 105);
            this.lblRialBalance.Name = "lblRialBalance";
            this.lblRialBalance.Size = new System.Drawing.Size(222, 35);
            this.lblRialBalance.TabIndex = 9;
            this.lblRialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInOrder
            // 
            this.lblInOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInOrder.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.lblInOrder.Location = new System.Drawing.Point(0, 70);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(222, 35);
            this.lblInOrder.TabIndex = 8;
            this.lblInOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActiveBalance
            // 
            this.lblActiveBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveBalance.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.lblActiveBalance.Location = new System.Drawing.Point(0, 35);
            this.lblActiveBalance.Name = "lblActiveBalance";
            this.lblActiveBalance.Size = new System.Drawing.Size(222, 35);
            this.lblActiveBalance.TabIndex = 7;
            this.lblActiveBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalance
            // 
            this.lblBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBalance.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.lblBalance.Location = new System.Drawing.Point(0, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(222, 35);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStaticData
            // 
            this.pnlStaticData.Controls.Add(this.label4);
            this.pnlStaticData.Controls.Add(this.label3);
            this.pnlStaticData.Controls.Add(this.label2);
            this.pnlStaticData.Controls.Add(this.label1);
            this.pnlStaticData.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStaticData.Location = new System.Drawing.Point(222, 0);
            this.pnlStaticData.Name = "pnlStaticData";
            this.pnlStaticData.Size = new System.Drawing.Size(158, 140);
            this.pnlStaticData.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.label4.Location = new System.Drawing.Point(0, 105);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(158, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "ارزش تقریبی (تومان):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "در سفارش:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "در دسترس:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "موجودی:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtonBox
            // 
            this.pnlButtonBox.Controls.Add(this.btnGetTransactionHistory);
            this.pnlButtonBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonBox.Location = new System.Drawing.Point(0, 140);
            this.pnlButtonBox.Name = "pnlButtonBox";
            this.pnlButtonBox.Size = new System.Drawing.Size(380, 38);
            this.pnlButtonBox.TabIndex = 0;
            // 
            // btnGetTransactionHistory
            // 
            this.btnGetTransactionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnGetTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnGetTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetTransactionHistory.Font = new System.Drawing.Font("IRANSansDN", 11F);
            this.btnGetTransactionHistory.Location = new System.Drawing.Point(0, 0);
            this.btnGetTransactionHistory.Name = "btnGetTransactionHistory";
            this.btnGetTransactionHistory.Size = new System.Drawing.Size(380, 38);
            this.btnGetTransactionHistory.TabIndex = 1;
            this.btnGetTransactionHistory.Text = "تاریخچه تراکنش ها";
            this.btnGetTransactionHistory.UseVisualStyleBackColor = false;
            this.btnGetTransactionHistory.Click += new System.EventHandler(this.btnGetTransactionHistory_Click);
            // 
            // pnlCoinProfile
            // 
            this.pnlCoinProfile.Controls.Add(this.lblFaCoinName);
            this.pnlCoinProfile.Controls.Add(this.lblEnCoinName);
            this.pnlCoinProfile.Controls.Add(this.picCoinLogo);
            this.pnlCoinProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCoinProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlCoinProfile.Name = "pnlCoinProfile";
            this.pnlCoinProfile.Size = new System.Drawing.Size(380, 112);
            this.pnlCoinProfile.TabIndex = 0;
            // 
            // lblFaCoinName
            // 
            this.lblFaCoinName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFaCoinName.Font = new System.Drawing.Font("IRANSansDN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaCoinName.Location = new System.Drawing.Point(0, 56);
            this.lblFaCoinName.Name = "lblFaCoinName";
            this.lblFaCoinName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFaCoinName.Size = new System.Drawing.Size(222, 56);
            this.lblFaCoinName.TabIndex = 2;
            this.lblFaCoinName.Text = "نام";
            this.lblFaCoinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnCoinName
            // 
            this.lblEnCoinName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEnCoinName.Font = new System.Drawing.Font("IRANSansDN", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnCoinName.Location = new System.Drawing.Point(0, 0);
            this.lblEnCoinName.Name = "lblEnCoinName";
            this.lblEnCoinName.Size = new System.Drawing.Size(222, 56);
            this.lblEnCoinName.TabIndex = 1;
            this.lblEnCoinName.Text = "Name";
            this.lblEnCoinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCoinLogo
            // 
            this.picCoinLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCoinLogo.Location = new System.Drawing.Point(222, 0);
            this.picCoinLogo.Name = "picCoinLogo";
            this.picCoinLogo.Size = new System.Drawing.Size(158, 112);
            this.picCoinLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoinLogo.TabIndex = 0;
            this.picCoinLogo.TabStop = false;
            // 
            // frmCustomCryptoWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(396, 489);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopMenuBar);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomCryptoWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomCryptoWallet";
            this.Load += new System.EventHandler(this.frmCustomCryptoWallet_Load);
            this.pnlTopMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlCoinData.ResumeLayout(false);
            this.pnlDinamicData.ResumeLayout(false);
            this.pnlStaticData.ResumeLayout(false);
            this.pnlButtonBox.ResumeLayout(false);
            this.pnlCoinProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCoinLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNobitexDesktopTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTopMenuBar;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlShowData;
        private System.Windows.Forms.Panel pnlCoinData;
        private System.Windows.Forms.Panel pnlDinamicData;
        private System.Windows.Forms.Label lblRialBalance;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.Label lblActiveBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel pnlStaticData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtonBox;
        private System.Windows.Forms.Panel pnlCoinProfile;
        private System.Windows.Forms.Label lblFaCoinName;
        private System.Windows.Forms.Label lblEnCoinName;
        private System.Windows.Forms.PictureBox picCoinLogo;
        private System.Windows.Forms.Button btnGetTransactionHistory;
    }
}