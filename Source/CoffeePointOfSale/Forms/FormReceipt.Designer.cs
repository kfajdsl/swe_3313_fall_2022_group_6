namespace CoffeePointOfSale.Forms
{
    partial class FormReceipt
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
            this.ReceiptTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.OrderNumTitle = new System.Windows.Forms.Label();
            this.ReceiptPanel = new System.Windows.Forms.Panel();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DrinkCartPanel = new System.Windows.Forms.Panel();
            this.DrinksTotal = new System.Windows.Forms.Panel();
            this.RewardsPointsRemainingTitle = new System.Windows.Forms.Label();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.TotalPaidLabel = new System.Windows.Forms.Label();
            this.PaidWithLabel = new System.Windows.Forms.Label();
            this.TaxPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.SubtotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalTitle = new System.Windows.Forms.Label();
            this.TaxTitle = new System.Windows.Forms.Label();
            this.OrdersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DrinkItem = new System.Windows.Forms.Label();
            this.SubtotalTitle = new System.Windows.Forms.Label();
            this.CustomerNameTitle = new System.Windows.Forms.Label();
            this.OrderNumberPanel = new System.Windows.Forms.Panel();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.RewardsPointsLabel = new System.Windows.Forms.Label();
            this.ReceiptPanel.SuspendLayout();
            this.DrinkCartPanel.SuspendLayout();
            this.DrinksTotal.SuspendLayout();
            this.OrdersFlowLayout.SuspendLayout();
            this.OrderNumberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiptTitle
            // 
            this.ReceiptTitle.AutoSize = true;
            this.ReceiptTitle.Font = new System.Drawing.Font("Lato", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiptTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ReceiptTitle.Location = new System.Drawing.Point(488, 9);
            this.ReceiptTitle.Name = "ReceiptTitle";
            this.ReceiptTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReceiptTitle.Size = new System.Drawing.Size(326, 102);
            this.ReceiptTitle.TabIndex = 9;
            this.ReceiptTitle.Text = "Receipt";
            this.ReceiptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 70);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "← Go to Main";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OrderNumTitle
            // 
            this.OrderNumTitle.AutoSize = true;
            this.OrderNumTitle.BackColor = System.Drawing.Color.White;
            this.OrderNumTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNumTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderNumTitle.Location = new System.Drawing.Point(86, 16);
            this.OrderNumTitle.Name = "OrderNumTitle";
            this.OrderNumTitle.Size = new System.Drawing.Size(85, 25);
            this.OrderNumTitle.TabIndex = 12;
            this.OrderNumTitle.Text = "Order #";
            // 
            // ReceiptPanel
            // 
            this.ReceiptPanel.Controls.Add(this.CustomerNameLabel);
            this.ReceiptPanel.Controls.Add(this.DrinkCartPanel);
            this.ReceiptPanel.Controls.Add(this.CustomerNameTitle);
            this.ReceiptPanel.Controls.Add(this.OrderNumberPanel);
            this.ReceiptPanel.Controls.Add(this.OrderNumTitle);
            this.ReceiptPanel.Location = new System.Drawing.Point(220, 114);
            this.ReceiptPanel.Name = "ReceiptPanel";
            this.ReceiptPanel.Size = new System.Drawing.Size(878, 545);
            this.ReceiptPanel.TabIndex = 13;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerNameLabel.Location = new System.Drawing.Point(676, 70);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNameLabel.Size = new System.Drawing.Size(187, 35);
            this.CustomerNameLabel.TabIndex = 15;
            this.CustomerNameLabel.Text = "Walter White";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrinkCartPanel
            // 
            this.DrinkCartPanel.Controls.Add(this.DrinksTotal);
            this.DrinkCartPanel.Location = new System.Drawing.Point(82, 111);
            this.DrinkCartPanel.Name = "DrinkCartPanel";
            this.DrinkCartPanel.Size = new System.Drawing.Size(691, 422);
            this.DrinkCartPanel.TabIndex = 14;
            // 
            // DrinksTotal
            // 
            this.DrinksTotal.BackColor = System.Drawing.Color.White;
            this.DrinksTotal.Controls.Add(this.RewardsPointsLabel);
            this.DrinksTotal.Controls.Add(this.RewardsPointsRemainingTitle);
            this.DrinksTotal.Controls.Add(this.CreditCardNumberLabel);
            this.DrinksTotal.Controls.Add(this.TotalPaidLabel);
            this.DrinksTotal.Controls.Add(this.PaidWithLabel);
            this.DrinksTotal.Controls.Add(this.TaxPriceLabel);
            this.DrinksTotal.Controls.Add(this.TotalPriceLabel);
            this.DrinksTotal.Controls.Add(this.SubtotalPriceLabel);
            this.DrinksTotal.Controls.Add(this.TotalTitle);
            this.DrinksTotal.Controls.Add(this.TaxTitle);
            this.DrinksTotal.Controls.Add(this.OrdersFlowLayout);
            this.DrinksTotal.Controls.Add(this.SubtotalTitle);
            this.DrinksTotal.Location = new System.Drawing.Point(0, 0);
            this.DrinksTotal.Name = "DrinksTotal";
            this.DrinksTotal.Size = new System.Drawing.Size(691, 422);
            this.DrinksTotal.TabIndex = 0;
            // 
            // RewardsPointsRemainingTitle
            // 
            this.RewardsPointsRemainingTitle.AutoSize = true;
            this.RewardsPointsRemainingTitle.BackColor = System.Drawing.Color.White;
            this.RewardsPointsRemainingTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RewardsPointsRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsPointsRemainingTitle.Location = new System.Drawing.Point(4, 387);
            this.RewardsPointsRemainingTitle.Name = "RewardsPointsRemainingTitle";
            this.RewardsPointsRemainingTitle.Size = new System.Drawing.Size(256, 25);
            this.RewardsPointsRemainingTitle.TabIndex = 22;
            this.RewardsPointsRemainingTitle.Text = "Reward Points Remaining ";
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.BackColor = System.Drawing.Color.White;
            this.CreditCardNumberLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditCardNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(6, 352);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(228, 25);
            this.CreditCardNumberLabel.TabIndex = 21;
            this.CreditCardNumberLabel.Text = "XXXXXXXXXXXX1234";
            // 
            // TotalPaidLabel
            // 
            this.TotalPaidLabel.AutoSize = true;
            this.TotalPaidLabel.BackColor = System.Drawing.Color.White;
            this.TotalPaidLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPaidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalPaidLabel.Location = new System.Drawing.Point(614, 327);
            this.TotalPaidLabel.Name = "TotalPaidLabel";
            this.TotalPaidLabel.Size = new System.Drawing.Size(36, 25);
            this.TotalPaidLabel.TabIndex = 20;
            this.TotalPaidLabel.Text = "$0";
            // 
            // PaidWithLabel
            // 
            this.PaidWithLabel.AutoSize = true;
            this.PaidWithLabel.BackColor = System.Drawing.Color.White;
            this.PaidWithLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaidWithLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.PaidWithLabel.Location = new System.Drawing.Point(6, 327);
            this.PaidWithLabel.Name = "PaidWithLabel";
            this.PaidWithLabel.Size = new System.Drawing.Size(213, 25);
            this.PaidWithLabel.TabIndex = 19;
            this.PaidWithLabel.Text = "Paid with Credit Card";
            // 
            // TaxPriceLabel
            // 
            this.TaxPriceLabel.AutoSize = true;
            this.TaxPriceLabel.BackColor = System.Drawing.Color.White;
            this.TaxPriceLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxPriceLabel.Location = new System.Drawing.Point(614, 238);
            this.TaxPriceLabel.Name = "TaxPriceLabel";
            this.TaxPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TaxPriceLabel.TabIndex = 18;
            this.TaxPriceLabel.Text = "$0";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalPriceLabel.Location = new System.Drawing.Point(614, 273);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TotalPriceLabel.TabIndex = 17;
            this.TotalPriceLabel.Text = "$0";
            // 
            // SubtotalPriceLabel
            // 
            this.SubtotalPriceLabel.AutoSize = true;
            this.SubtotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.SubtotalPriceLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalPriceLabel.Location = new System.Drawing.Point(614, 204);
            this.SubtotalPriceLabel.Name = "SubtotalPriceLabel";
            this.SubtotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.SubtotalPriceLabel.TabIndex = 16;
            this.SubtotalPriceLabel.Text = "$0";
            // 
            // TotalTitle
            // 
            this.TotalTitle.AutoSize = true;
            this.TotalTitle.BackColor = System.Drawing.Color.White;
            this.TotalTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalTitle.Location = new System.Drawing.Point(4, 273);
            this.TotalTitle.Name = "TotalTitle";
            this.TotalTitle.Size = new System.Drawing.Size(58, 25);
            this.TotalTitle.TabIndex = 15;
            this.TotalTitle.Text = "Total";
            // 
            // TaxTitle
            // 
            this.TaxTitle.AutoSize = true;
            this.TaxTitle.BackColor = System.Drawing.Color.White;
            this.TaxTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxTitle.Location = new System.Drawing.Point(4, 238);
            this.TaxTitle.Name = "TaxTitle";
            this.TaxTitle.Size = new System.Drawing.Size(45, 25);
            this.TaxTitle.TabIndex = 2;
            this.TaxTitle.Text = "Tax";
            // 
            // OrdersFlowLayout
            // 
            this.OrdersFlowLayout.AutoScroll = true;
            this.OrdersFlowLayout.AutoSize = true;
            this.OrdersFlowLayout.Controls.Add(this.DrinkItem);
            this.OrdersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrdersFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.OrdersFlowLayout.Name = "OrdersFlowLayout";
            this.OrdersFlowLayout.Size = new System.Drawing.Size(691, 190);
            this.OrdersFlowLayout.TabIndex = 0;
            this.OrdersFlowLayout.WrapContents = false;
            // 
            // DrinkItem
            // 
            this.DrinkItem.AutoSize = true;
            this.DrinkItem.BackColor = System.Drawing.Color.Transparent;
            this.DrinkItem.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrinkItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.DrinkItem.Location = new System.Drawing.Point(3, 0);
            this.DrinkItem.Name = "DrinkItem";
            this.DrinkItem.Size = new System.Drawing.Size(106, 25);
            this.DrinkItem.TabIndex = 0;
            this.DrinkItem.Text = "DrinkItem";
            // 
            // SubtotalTitle
            // 
            this.SubtotalTitle.AutoSize = true;
            this.SubtotalTitle.BackColor = System.Drawing.Color.White;
            this.SubtotalTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalTitle.Location = new System.Drawing.Point(4, 204);
            this.SubtotalTitle.Name = "SubtotalTitle";
            this.SubtotalTitle.Size = new System.Drawing.Size(92, 25);
            this.SubtotalTitle.TabIndex = 1;
            this.SubtotalTitle.Text = "Subtotal";
            // 
            // CustomerNameTitle
            // 
            this.CustomerNameTitle.AutoSize = true;
            this.CustomerNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameTitle.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerNameTitle.Location = new System.Drawing.Point(640, 16);
            this.CustomerNameTitle.Name = "CustomerNameTitle";
            this.CustomerNameTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNameTitle.Size = new System.Drawing.Size(223, 35);
            this.CustomerNameTitle.TabIndex = 14;
            this.CustomerNameTitle.Text = "Customer Name";
            this.CustomerNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderNumberPanel
            // 
            this.OrderNumberPanel.Controls.Add(this.OrderNumberLabel);
            this.OrderNumberPanel.Location = new System.Drawing.Point(82, 44);
            this.OrderNumberPanel.Name = "OrderNumberPanel";
            this.OrderNumberPanel.Size = new System.Drawing.Size(88, 61);
            this.OrderNumberPanel.TabIndex = 13;
            this.OrderNumberPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderNumberPanel_Paint);
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderNumberLabel.Location = new System.Drawing.Point(31, 13);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(31, 33);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "0";
            // 
            // RewardsPointsLabel
            // 
            this.RewardsPointsLabel.AutoSize = true;
            this.RewardsPointsLabel.BackColor = System.Drawing.Color.White;
            this.RewardsPointsLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsPointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsPointsLabel.Location = new System.Drawing.Point(626, 387);
            this.RewardsPointsLabel.Name = "RewardsPointsLabel";
            this.RewardsPointsLabel.Size = new System.Drawing.Size(24, 25);
            this.RewardsPointsLabel.TabIndex = 23;
            this.RewardsPointsLabel.Text = "0";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.ReceiptPanel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ReceiptTitle);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.ReceiptPanel.ResumeLayout(false);
            this.ReceiptPanel.PerformLayout();
            this.DrinkCartPanel.ResumeLayout(false);
            this.DrinksTotal.ResumeLayout(false);
            this.DrinksTotal.PerformLayout();
            this.OrdersFlowLayout.ResumeLayout(false);
            this.OrdersFlowLayout.PerformLayout();
            this.OrderNumberPanel.ResumeLayout(false);
            this.OrderNumberPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ReceiptTitle;
        private Button btnClose;
        private Label OrderNumTitle;
        private Panel ReceiptPanel;
        private Panel OrderNumberPanel;
        private Label OrderNumberLabel;
        private Label CustomerNameLabel;
        private Panel DrinkCartPanel;
        private Panel DrinksTotal;
        private Label RewardsPointsRemainingTitle;
        private Label CreditCardNumberLabel;
        private Label TotalPaidLabel;
        private Label PaidWithLabel;
        private Label TaxPriceLabel;
        private Label TotalPriceLabel;
        private Label SubtotalPriceLabel;
        private Label TotalTitle;
        private Label TaxTitle;
        private FlowLayoutPanel OrdersFlowLayout;
        private Label DrinkItem;
        private Label SubtotalTitle;
        private Label CustomerNameTitle;
        private Label RewardsPointsLabel;
    }
}