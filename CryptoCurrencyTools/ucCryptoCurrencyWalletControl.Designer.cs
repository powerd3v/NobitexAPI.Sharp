
namespace CryptoCurrencyTools
{
    partial class ucCryptoCurrencyWalletControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCryptoCurrencyWalletControl));
            this.picCryptoProfile = new System.Windows.Forms.PictureBox();
            this.lblCryptoName = new System.Windows.Forms.Label();
            this.pnlCryptoInfoContainer = new System.Windows.Forms.Panel();
            this.pnlEnCurrency = new System.Windows.Forms.Panel();
            this.txtEnCurrency = new System.Windows.Forms.TextBox();
            this.lblEnCurrency = new System.Windows.Forms.Label();
            this.pnlFaCurrency = new System.Windows.Forms.Panel();
            this.txtFaCurrency = new System.Windows.Forms.TextBox();
            this.lblFaCurrency = new System.Windows.Forms.Label();
            this.btnShowCryptoInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCryptoProfile)).BeginInit();
            this.pnlCryptoInfoContainer.SuspendLayout();
            this.pnlEnCurrency.SuspendLayout();
            this.pnlFaCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCryptoProfile
            // 
            this.picCryptoProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCryptoProfile.Location = new System.Drawing.Point(397, 0);
            this.picCryptoProfile.Name = "picCryptoProfile";
            this.picCryptoProfile.Size = new System.Drawing.Size(73, 74);
            this.picCryptoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCryptoProfile.TabIndex = 4;
            this.picCryptoProfile.TabStop = false;
            // 
            // lblCryptoName
            // 
            this.lblCryptoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lblCryptoName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCryptoName.Font = new System.Drawing.Font("IRANSansDN", 12F);
            this.lblCryptoName.Location = new System.Drawing.Point(255, 0);
            this.lblCryptoName.Name = "lblCryptoName";
            this.lblCryptoName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCryptoName.Size = new System.Drawing.Size(142, 74);
            this.lblCryptoName.TabIndex = 5;
            this.lblCryptoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCryptoInfoContainer
            // 
            this.pnlCryptoInfoContainer.Controls.Add(this.pnlEnCurrency);
            this.pnlCryptoInfoContainer.Controls.Add(this.pnlFaCurrency);
            this.pnlCryptoInfoContainer.Controls.Add(this.btnShowCryptoInfo);
            this.pnlCryptoInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCryptoInfoContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlCryptoInfoContainer.Name = "pnlCryptoInfoContainer";
            this.pnlCryptoInfoContainer.Size = new System.Drawing.Size(255, 74);
            this.pnlCryptoInfoContainer.TabIndex = 6;
            // 
            // pnlEnCurrency
            // 
            this.pnlEnCurrency.Controls.Add(this.txtEnCurrency);
            this.pnlEnCurrency.Controls.Add(this.lblEnCurrency);
            this.pnlEnCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnCurrency.Location = new System.Drawing.Point(30, 37);
            this.pnlEnCurrency.Name = "pnlEnCurrency";
            this.pnlEnCurrency.Size = new System.Drawing.Size(225, 37);
            this.pnlEnCurrency.TabIndex = 2;
            // 
            // txtEnCurrency
            // 
            this.txtEnCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtEnCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnCurrency.Font = new System.Drawing.Font("IRANSansDN Light", 15.75F);
            this.txtEnCurrency.ForeColor = System.Drawing.Color.White;
            this.txtEnCurrency.Location = new System.Drawing.Point(0, 0);
            this.txtEnCurrency.Name = "txtEnCurrency";
            this.txtEnCurrency.ReadOnly = true;
            this.txtEnCurrency.Size = new System.Drawing.Size(153, 33);
            this.txtEnCurrency.TabIndex = 2;
            this.txtEnCurrency.Text = "0";
            this.txtEnCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnCurrency
            // 
            this.lblEnCurrency.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEnCurrency.Font = new System.Drawing.Font("IRANSansDN Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnCurrency.Location = new System.Drawing.Point(153, 0);
            this.lblEnCurrency.Name = "lblEnCurrency";
            this.lblEnCurrency.Size = new System.Drawing.Size(72, 37);
            this.lblEnCurrency.TabIndex = 1;
            this.lblEnCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFaCurrency
            // 
            this.pnlFaCurrency.Controls.Add(this.txtFaCurrency);
            this.pnlFaCurrency.Controls.Add(this.lblFaCurrency);
            this.pnlFaCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFaCurrency.Location = new System.Drawing.Point(30, 0);
            this.pnlFaCurrency.Name = "pnlFaCurrency";
            this.pnlFaCurrency.Size = new System.Drawing.Size(225, 37);
            this.pnlFaCurrency.TabIndex = 1;
            // 
            // txtFaCurrency
            // 
            this.txtFaCurrency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtFaCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFaCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaCurrency.Font = new System.Drawing.Font("IRANSansDN Light", 15.75F);
            this.txtFaCurrency.ForeColor = System.Drawing.Color.White;
            this.txtFaCurrency.Location = new System.Drawing.Point(0, 0);
            this.txtFaCurrency.Name = "txtFaCurrency";
            this.txtFaCurrency.ReadOnly = true;
            this.txtFaCurrency.Size = new System.Drawing.Size(153, 33);
            this.txtFaCurrency.TabIndex = 1;
            this.txtFaCurrency.Text = "0";
            this.txtFaCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFaCurrency
            // 
            this.lblFaCurrency.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFaCurrency.Font = new System.Drawing.Font("IRANSansDN Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaCurrency.Location = new System.Drawing.Point(153, 0);
            this.lblFaCurrency.Name = "lblFaCurrency";
            this.lblFaCurrency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFaCurrency.Size = new System.Drawing.Size(72, 37);
            this.lblFaCurrency.TabIndex = 0;
            this.lblFaCurrency.Text = "تومان";
            this.lblFaCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowCryptoInfo
            // 
            this.btnShowCryptoInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnShowCryptoInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowCryptoInfo.FlatAppearance.BorderSize = 0;
            this.btnShowCryptoInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCryptoInfo.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCryptoInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCryptoInfo.Image")));
            this.btnShowCryptoInfo.Location = new System.Drawing.Point(0, 0);
            this.btnShowCryptoInfo.Name = "btnShowCryptoInfo";
            this.btnShowCryptoInfo.Size = new System.Drawing.Size(30, 74);
            this.btnShowCryptoInfo.TabIndex = 0;
            this.btnShowCryptoInfo.UseVisualStyleBackColor = false;
            this.btnShowCryptoInfo.Click += new System.EventHandler(this.btnShowCryptoInfo_Click);
            // 
            // ucCryptoCurrencyWalletControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.pnlCryptoInfoContainer);
            this.Controls.Add(this.lblCryptoName);
            this.Controls.Add(this.picCryptoProfile);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ucCryptoCurrencyWalletControl";
            this.Size = new System.Drawing.Size(470, 74);
            ((System.ComponentModel.ISupportInitialize)(this.picCryptoProfile)).EndInit();
            this.pnlCryptoInfoContainer.ResumeLayout(false);
            this.pnlEnCurrency.ResumeLayout(false);
            this.pnlEnCurrency.PerformLayout();
            this.pnlFaCurrency.ResumeLayout(false);
            this.pnlFaCurrency.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCryptoProfile;
        private System.Windows.Forms.Label lblCryptoName;
        private System.Windows.Forms.Panel pnlCryptoInfoContainer;
        private System.Windows.Forms.Panel pnlEnCurrency;
        private System.Windows.Forms.TextBox txtEnCurrency;
        private System.Windows.Forms.Label lblEnCurrency;
        private System.Windows.Forms.Panel pnlFaCurrency;
        private System.Windows.Forms.TextBox txtFaCurrency;
        private System.Windows.Forms.Label lblFaCurrency;
        private System.Windows.Forms.Button btnShowCryptoInfo;
    }
}
