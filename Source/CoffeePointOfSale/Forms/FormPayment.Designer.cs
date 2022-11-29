namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.DrinkCartPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.TaxPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.SubtotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalTitle = new System.Windows.Forms.Label();
            this.CurrentOrderTitle = new System.Windows.Forms.Label();
            this.TaxTitle = new System.Windows.Forms.Label();
            this.OrdersFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DrinkItem = new System.Windows.Forms.Label();
            this.SubtotalTitle = new System.Windows.Forms.Label();
            this.PaymentTitle = new System.Windows.Forms.Label();
            this.SelectDrinkPanel = new System.Windows.Forms.Panel();
            this.btnPayWithRewards = new System.Windows.Forms.Button();
            this.OrderRewardsCost = new System.Windows.Forms.Label();
            this.CustomerRewardsLabel = new System.Windows.Forms.Label();
            this.RewardsPriceTitle = new System.Windows.Forms.Label();
            this.CustomerRewardsPointsTitle = new System.Windows.Forms.Label();
            this.CardCVVDropdown = new System.Windows.Forms.ComboBox();
            this.CardYearDropdown = new System.Windows.Forms.ComboBox();
            this.CardMonthDropdown = new System.Windows.Forms.ComboBox();
            this.CreditCardTextInput = new System.Windows.Forms.TextBox();
            this.btnPayWithCard = new System.Windows.Forms.Button();
            this.RewardsTitle = new System.Windows.Forms.Label();
            this.CreditCardTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.DrinkCartPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.OrdersFlowLayout.SuspendLayout();
            this.SelectDrinkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrinkCartPanel
            // 
            this.DrinkCartPanel.Controls.Add(this.panel3);
            this.DrinkCartPanel.Location = new System.Drawing.Point(25, 130);
            this.DrinkCartPanel.Name = "DrinkCartPanel";
            this.DrinkCartPanel.Size = new System.Drawing.Size(627, 521);
            this.DrinkCartPanel.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnEditOrder);
            this.panel3.Controls.Add(this.TaxPriceLabel);
            this.panel3.Controls.Add(this.TotalPriceLabel);
            this.panel3.Controls.Add(this.SubtotalPriceLabel);
            this.panel3.Controls.Add(this.TotalTitle);
            this.panel3.Controls.Add(this.CurrentOrderTitle);
            this.panel3.Controls.Add(this.TaxTitle);
            this.panel3.Controls.Add(this.OrdersFlowLayout);
            this.panel3.Controls.Add(this.SubtotalTitle);
            this.panel3.Location = new System.Drawing.Point(21, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 483);
            this.panel3.TabIndex = 0;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.btnEditOrder.Enabled = false;
            this.btnEditOrder.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(298, 403);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(263, 61);
            this.btnEditOrder.TabIndex = 14;
            this.btnEditOrder.Text = "Edit Order";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            // 
            // TaxPriceLabel
            // 
            this.TaxPriceLabel.AutoSize = true;
            this.TaxPriceLabel.BackColor = System.Drawing.Color.White;
            this.TaxPriceLabel.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxPriceLabel.Location = new System.Drawing.Point(164, 414);
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
            this.TotalPriceLabel.Location = new System.Drawing.Point(164, 449);
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
            this.SubtotalPriceLabel.Location = new System.Drawing.Point(164, 380);
            this.SubtotalPriceLabel.Name = "SubtotalPriceLabel";
            this.SubtotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.SubtotalPriceLabel.TabIndex = 16;
            this.SubtotalPriceLabel.Text = "$0";
            // 
            // TotalTitle
            // 
            this.TotalTitle.AutoSize = true;
            this.TotalTitle.BackColor = System.Drawing.Color.White;
            this.TotalTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalTitle.Location = new System.Drawing.Point(10, 449);
            this.TotalTitle.Name = "TotalTitle";
            this.TotalTitle.Size = new System.Drawing.Size(56, 25);
            this.TotalTitle.TabIndex = 15;
            this.TotalTitle.Text = "Total";
            // 
            // CurrentOrderTitle
            // 
            this.CurrentOrderTitle.AutoSize = true;
            this.CurrentOrderTitle.BackColor = System.Drawing.Color.Transparent;
            this.CurrentOrderTitle.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentOrderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CurrentOrderTitle.Location = new System.Drawing.Point(0, -11);
            this.CurrentOrderTitle.Name = "CurrentOrderTitle";
            this.CurrentOrderTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentOrderTitle.Size = new System.Drawing.Size(322, 56);
            this.CurrentOrderTitle.TabIndex = 14;
            this.CurrentOrderTitle.Text = "Current Order";
            this.CurrentOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaxTitle
            // 
            this.TaxTitle.AutoSize = true;
            this.TaxTitle.BackColor = System.Drawing.Color.White;
            this.TaxTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxTitle.Location = new System.Drawing.Point(10, 414);
            this.TaxTitle.Name = "TaxTitle";
            this.TaxTitle.Size = new System.Drawing.Size(42, 25);
            this.TaxTitle.TabIndex = 2;
            this.TaxTitle.Text = "Tax";
            // 
            // OrdersFlowLayout
            // 
            this.OrdersFlowLayout.AutoScroll = true;
            this.OrdersFlowLayout.AutoSize = true;
            this.OrdersFlowLayout.Controls.Add(this.DrinkItem);
            this.OrdersFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrdersFlowLayout.Location = new System.Drawing.Point(10, 47);
            this.OrdersFlowLayout.Name = "OrdersFlowLayout";
            this.OrdersFlowLayout.Size = new System.Drawing.Size(568, 330);
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
            this.SubtotalTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalTitle.Location = new System.Drawing.Point(10, 380);
            this.SubtotalTitle.Name = "SubtotalTitle";
            this.SubtotalTitle.Size = new System.Drawing.Size(90, 25);
            this.SubtotalTitle.TabIndex = 1;
            this.SubtotalTitle.Text = "Subtotal";
            // 
            // PaymentTitle
            // 
            this.PaymentTitle.AutoSize = true;
            this.PaymentTitle.Font = new System.Drawing.Font("Lato", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaymentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.PaymentTitle.Location = new System.Drawing.Point(471, -1);
            this.PaymentTitle.Name = "PaymentTitle";
            this.PaymentTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaymentTitle.Size = new System.Drawing.Size(378, 102);
            this.PaymentTitle.TabIndex = 8;
            this.PaymentTitle.Text = "Payment";
            this.PaymentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDrinkPanel
            // 
            this.SelectDrinkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SelectDrinkPanel.Controls.Add(this.btnPayWithRewards);
            this.SelectDrinkPanel.Controls.Add(this.OrderRewardsCost);
            this.SelectDrinkPanel.Controls.Add(this.CustomerRewardsLabel);
            this.SelectDrinkPanel.Controls.Add(this.RewardsPriceTitle);
            this.SelectDrinkPanel.Controls.Add(this.CustomerRewardsPointsTitle);
            this.SelectDrinkPanel.Controls.Add(this.CardCVVDropdown);
            this.SelectDrinkPanel.Controls.Add(this.CardYearDropdown);
            this.SelectDrinkPanel.Controls.Add(this.CardMonthDropdown);
            this.SelectDrinkPanel.Controls.Add(this.CreditCardTextInput);
            this.SelectDrinkPanel.Controls.Add(this.btnPayWithCard);
            this.SelectDrinkPanel.Controls.Add(this.RewardsTitle);
            this.SelectDrinkPanel.Controls.Add(this.CreditCardTitle);
            this.SelectDrinkPanel.Location = new System.Drawing.Point(677, 130);
            this.SelectDrinkPanel.Name = "SelectDrinkPanel";
            this.SelectDrinkPanel.Size = new System.Drawing.Size(627, 521);
            this.SelectDrinkPanel.TabIndex = 9;
            // 
            // btnPayWithRewards
            // 
            this.btnPayWithRewards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.btnPayWithRewards.Enabled = false;
            this.btnPayWithRewards.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayWithRewards.ForeColor = System.Drawing.Color.White;
            this.btnPayWithRewards.Location = new System.Drawing.Point(153, 448);
            this.btnPayWithRewards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayWithRewards.Name = "btnPayWithRewards";
            this.btnPayWithRewards.Size = new System.Drawing.Size(303, 61);
            this.btnPayWithRewards.TabIndex = 22;
            this.btnPayWithRewards.Text = "Pay with Rewards";
            this.btnPayWithRewards.UseVisualStyleBackColor = false;
            // 
            // OrderRewardsCost
            // 
            this.OrderRewardsCost.AutoSize = true;
            this.OrderRewardsCost.BackColor = System.Drawing.Color.Transparent;
            this.OrderRewardsCost.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderRewardsCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderRewardsCost.Location = new System.Drawing.Point(452, 397);
            this.OrderRewardsCost.Name = "OrderRewardsCost";
            this.OrderRewardsCost.Size = new System.Drawing.Size(32, 35);
            this.OrderRewardsCost.TabIndex = 21;
            this.OrderRewardsCost.Text = "0";
            // 
            // CustomerRewardsLabel
            // 
            this.CustomerRewardsLabel.AutoSize = true;
            this.CustomerRewardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerRewardsLabel.Font = new System.Drawing.Font("Lato", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerRewardsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerRewardsLabel.Location = new System.Drawing.Point(452, 354);
            this.CustomerRewardsLabel.Name = "CustomerRewardsLabel";
            this.CustomerRewardsLabel.Size = new System.Drawing.Size(32, 35);
            this.CustomerRewardsLabel.TabIndex = 19;
            this.CustomerRewardsLabel.Text = "0";
            // 
            // RewardsPriceTitle
            // 
            this.RewardsPriceTitle.AutoSize = true;
            this.RewardsPriceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RewardsPriceTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RewardsPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsPriceTitle.Location = new System.Drawing.Point(58, 405);
            this.RewardsPriceTitle.Name = "RewardsPriceTitle";
            this.RewardsPriceTitle.Size = new System.Drawing.Size(227, 25);
            this.RewardsPriceTitle.TabIndex = 20;
            this.RewardsPriceTitle.Text = "Price in Reward Points:";
            // 
            // CustomerRewardsPointsTitle
            // 
            this.CustomerRewardsPointsTitle.AutoSize = true;
            this.CustomerRewardsPointsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CustomerRewardsPointsTitle.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerRewardsPointsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerRewardsPointsTitle.Location = new System.Drawing.Point(58, 354);
            this.CustomerRewardsPointsTitle.Name = "CustomerRewardsPointsTitle";
            this.CustomerRewardsPointsTitle.Size = new System.Drawing.Size(327, 25);
            this.CustomerRewardsPointsTitle.TabIndex = 19;
            this.CustomerRewardsPointsTitle.Text = "Customer\'s Total Rewards Points: ";
            // 
            // CardCVVDropdown
            // 
            this.CardCVVDropdown.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardCVVDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(165)))));
            this.CardCVVDropdown.FormattingEnabled = true;
            this.CardCVVDropdown.Location = new System.Drawing.Point(386, 148);
            this.CardCVVDropdown.Name = "CardCVVDropdown";
            this.CardCVVDropdown.Size = new System.Drawing.Size(115, 33);
            this.CardCVVDropdown.TabIndex = 19;
            // 
            // CardYearDropdown
            // 
            this.CardYearDropdown.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardYearDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(165)))));
            this.CardYearDropdown.FormattingEnabled = true;
            this.CardYearDropdown.Location = new System.Drawing.Point(284, 148);
            this.CardYearDropdown.Name = "CardYearDropdown";
            this.CardYearDropdown.Size = new System.Drawing.Size(86, 33);
            this.CardYearDropdown.TabIndex = 18;
            // 
            // CardMonthDropdown
            // 
            this.CardMonthDropdown.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardMonthDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(165)))));
            this.CardMonthDropdown.FormattingEnabled = true;
            this.CardMonthDropdown.Location = new System.Drawing.Point(102, 148);
            this.CardMonthDropdown.Name = "CardMonthDropdown";
            this.CardMonthDropdown.Size = new System.Drawing.Size(163, 33);
            this.CardMonthDropdown.TabIndex = 17;
            // 
            // CreditCardTextInput
            // 
            this.CreditCardTextInput.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditCardTextInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(144)))), ((int)(((byte)(165)))));
            this.CreditCardTextInput.Location = new System.Drawing.Point(102, 79);
            this.CreditCardTextInput.Name = "CreditCardTextInput";
            this.CreditCardTextInput.Size = new System.Drawing.Size(399, 33);
            this.CreditCardTextInput.TabIndex = 16;
            this.CreditCardTextInput.Text = "XXXX-XXXX-XXXX-XXXX";
            this.CreditCardTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayWithCard
            // 
            this.btnPayWithCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.btnPayWithCard.Enabled = false;
            this.btnPayWithCard.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayWithCard.ForeColor = System.Drawing.Color.White;
            this.btnPayWithCard.Location = new System.Drawing.Point(153, 208);
            this.btnPayWithCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayWithCard.Name = "btnPayWithCard";
            this.btnPayWithCard.Size = new System.Drawing.Size(303, 61);
            this.btnPayWithCard.TabIndex = 15;
            this.btnPayWithCard.Text = "Pay with Credit Card";
            this.btnPayWithCard.UseVisualStyleBackColor = false;
            // 
            // RewardsTitle
            // 
            this.RewardsTitle.AutoSize = true;
            this.RewardsTitle.BackColor = System.Drawing.Color.Transparent;
            this.RewardsTitle.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RewardsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsTitle.Location = new System.Drawing.Point(204, 277);
            this.RewardsTitle.Name = "RewardsTitle";
            this.RewardsTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RewardsTitle.Size = new System.Drawing.Size(204, 56);
            this.RewardsTitle.TabIndex = 9;
            this.RewardsTitle.Text = "Rewards";
            this.RewardsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditCardTitle
            // 
            this.CreditCardTitle.AutoSize = true;
            this.CreditCardTitle.BackColor = System.Drawing.Color.Transparent;
            this.CreditCardTitle.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreditCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CreditCardTitle.Location = new System.Drawing.Point(173, 3);
            this.CreditCardTitle.Name = "CreditCardTitle";
            this.CreditCardTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreditCardTitle.Size = new System.Drawing.Size(263, 56);
            this.CreditCardTitle.TabIndex = 8;
            this.CreditCardTitle.Text = "Credit Card";
            this.CreditCardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cancel Order";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.SelectDrinkPanel);
            this.Controls.Add(this.PaymentTitle);
            this.Controls.Add(this.DrinkCartPanel);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.DrinkCartPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.OrdersFlowLayout.ResumeLayout(false);
            this.OrdersFlowLayout.PerformLayout();
            this.SelectDrinkPanel.ResumeLayout(false);
            this.SelectDrinkPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel DrinkCartPanel;
        private Panel panel3;
        private Button btnEditOrder;
        private Label TaxPriceLabel;
        private Label TotalPriceLabel;
        private Label SubtotalPriceLabel;
        private Label TotalTitle;
        private Label CurrentOrderTitle;
        private Label TaxTitle;
        private FlowLayoutPanel OrdersFlowLayout;
        private Label DrinkItem;
        private Label SubtotalTitle;
        private Label PaymentTitle;
        private Panel SelectDrinkPanel;
        private Label CreditCardTitle;
        private Label RewardsTitle;
        private Label CustomerRewardsPointsTitle;
        private ComboBox CardCVVDropdown;
        private ComboBox CardYearDropdown;
        private ComboBox CardMonthDropdown;
        private TextBox CreditCardTextInput;
        private Button btnPayWithCard;
        private Label OrderRewardsCost;
        private Label CustomerRewardsLabel;
        private Label RewardsPriceTitle;
        private Button btnPayWithRewards;
        private Button btnClose;
    }
}