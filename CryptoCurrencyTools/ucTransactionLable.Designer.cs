
namespace CryptoCurrencyTools
{
    partial class ucTransactionLable
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pbChart = new CryptoCurrencyTools.CustomProgressBar();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lblAmount);
            this.pnlContainer.Controls.Add(this.pbChart);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.ForeColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(255, 45);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmount.Location = new System.Drawing.Point(0, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(105, 45);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbChart
            // 
            this.pbChart.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pbChart.ChannelHeight = 20;
            this.pbChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbChart.ForeBackColor = System.Drawing.Color.Transparent;
            this.pbChart.ForeColor = System.Drawing.Color.White;
            this.pbChart.Location = new System.Drawing.Point(105, 0);
            this.pbChart.Name = "pbChart";
            this.pbChart.PriceNumber = 0D;
            this.pbChart.ShowMaximun = false;
            this.pbChart.ShowValue = CryptoCurrencyTools.TextPosition.Left;
            this.pbChart.Size = new System.Drawing.Size(150, 45);
            this.pbChart.SliderColor = System.Drawing.Color.Crimson;
            this.pbChart.SliderHeight = 20;
            this.pbChart.StopPainting = false;
            this.pbChart.SymbolAfter = "";
            this.pbChart.SymbolBefore = "";
            this.pbChart.TabIndex = 0;
            // 
            // ucTransactionLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("IRANSansDN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ucTransactionLable";
            this.Size = new System.Drawing.Size(255, 45);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private CustomProgressBar pbChart;
        private System.Windows.Forms.Label lblAmount;
    }
}
