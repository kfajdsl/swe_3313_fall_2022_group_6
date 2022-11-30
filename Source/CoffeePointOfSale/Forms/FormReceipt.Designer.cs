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
            this.DrinksTotal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TaxPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.RewardsPointsLabel = new System.Windows.Forms.Label();
            this.SubtotalTitle = new System.Windows.Forms.Label();
            this.RewardsPointsRemainingTitle = new System.Windows.Forms.Label();
            this.TaxTitle = new System.Windows.Forms.Label();
            this.CreditCardNumberLabel = new System.Windows.Forms.Label();
            this.TotalTitle = new System.Windows.Forms.Label();
            this.PaidWithLabel = new System.Windows.Forms.Label();
            this.SubtotalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPaidLabel = new System.Windows.Forms.Label();
            this.CurrentDrinkOrderTable = new System.Windows.Forms.TableLayoutPanel();
            this.ExampleDrinkItem = new System.Windows.Forms.Label();
            this.DrinkPriceExample = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameTitle = new System.Windows.Forms.Label();
            this.OrderNumberPanel = new System.Windows.Forms.Panel();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.ReceiptPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.CurrentDrinkOrderTable.SuspendLayout();
            this.OrderNumberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceiptTitle
            // 
            this.ReceiptTitle.AutoSize = true;
            this.ReceiptTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiptTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ReceiptTitle.Location = new System.Drawing.Point(488, 9);
            this.ReceiptTitle.Name = "ReceiptTitle";
            this.ReceiptTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReceiptTitle.Size = new System.Drawing.Size(336, 96);
            this.ReceiptTitle.TabIndex = 9;
            this.ReceiptTitle.Text = "Receipt";
            this.ReceiptTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.OrderNumTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNumTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderNumTitle.Location = new System.Drawing.Point(86, 16);
            this.OrderNumTitle.Name = "OrderNumTitle";
            this.OrderNumTitle.Size = new System.Drawing.Size(84, 25);
            this.OrderNumTitle.TabIndex = 12;
            this.OrderNumTitle.Text = "Order #";
            // 
            // ReceiptPanel
            // 
            this.ReceiptPanel.Controls.Add(this.DrinksTotal);
            this.ReceiptPanel.Controls.Add(this.tableLayoutPanel1);
            this.ReceiptPanel.Controls.Add(this.CurrentDrinkOrderTable);
            this.ReceiptPanel.Controls.Add(this.CustomerNameLabel);
            this.ReceiptPanel.Controls.Add(this.CustomerNameTitle);
            this.ReceiptPanel.Controls.Add(this.OrderNumberPanel);
            this.ReceiptPanel.Controls.Add(this.OrderNumTitle);
            this.ReceiptPanel.Location = new System.Drawing.Point(220, 114);
            this.ReceiptPanel.Name = "ReceiptPanel";
            this.ReceiptPanel.Size = new System.Drawing.Size(867, 545);
            this.ReceiptPanel.TabIndex = 13;
            this.ReceiptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReceiptPanel_Paint);
            // 
            // DrinksTotal
            // 
            this.DrinksTotal.BackColor = System.Drawing.Color.White;
            this.DrinksTotal.Location = new System.Drawing.Point(868, 255);
            this.DrinksTotal.Name = "DrinksTotal";
            this.DrinksTotal.Size = new System.Drawing.Size(793, 422);
            this.DrinksTotal.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 573F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.TaxPriceLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotalPriceLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RewardsPointsLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SubtotalTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RewardsPointsRemainingTitle, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TaxTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreditCardNumberLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PaidWithLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SubtotalPriceLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalPaidLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(82, 309);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 236);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // TaxPriceLabel
            // 
            this.TaxPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaxPriceLabel.AutoSize = true;
            this.TaxPriceLabel.BackColor = System.Drawing.Color.White;
            this.TaxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxPriceLabel.Location = new System.Drawing.Point(646, 46);
            this.TaxPriceLabel.Name = "TaxPriceLabel";
            this.TaxPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TaxPriceLabel.TabIndex = 16;
            this.TaxPriceLabel.Text = "$0";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalPriceLabel.Location = new System.Drawing.Point(646, 85);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TotalPriceLabel.TabIndex = 18;
            this.TotalPriceLabel.Text = "$0";
            // 
            // RewardsPointsLabel
            // 
            this.RewardsPointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RewardsPointsLabel.AutoSize = true;
            this.RewardsPointsLabel.BackColor = System.Drawing.Color.White;
            this.RewardsPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsPointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsPointsLabel.Location = new System.Drawing.Point(658, 203);
            this.RewardsPointsLabel.Name = "RewardsPointsLabel";
            this.RewardsPointsLabel.Size = new System.Drawing.Size(24, 25);
            this.RewardsPointsLabel.TabIndex = 23;
            this.RewardsPointsLabel.Text = "0";
            // 
            // SubtotalTitle
            // 
            this.SubtotalTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SubtotalTitle.AutoSize = true;
            this.SubtotalTitle.BackColor = System.Drawing.Color.White;
            this.SubtotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalTitle.Location = new System.Drawing.Point(3, 7);
            this.SubtotalTitle.Name = "SubtotalTitle";
            this.SubtotalTitle.Size = new System.Drawing.Size(99, 25);
            this.SubtotalTitle.TabIndex = 1;
            this.SubtotalTitle.Text = "Subtotal";
            // 
            // RewardsPointsRemainingTitle
            // 
            this.RewardsPointsRemainingTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RewardsPointsRemainingTitle.AutoSize = true;
            this.RewardsPointsRemainingTitle.BackColor = System.Drawing.Color.White;
            this.RewardsPointsRemainingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RewardsPointsRemainingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.RewardsPointsRemainingTitle.Location = new System.Drawing.Point(3, 203);
            this.RewardsPointsRemainingTitle.Name = "RewardsPointsRemainingTitle";
            this.RewardsPointsRemainingTitle.Size = new System.Drawing.Size(289, 25);
            this.RewardsPointsRemainingTitle.TabIndex = 22;
            this.RewardsPointsRemainingTitle.Text = "Reward Points Remaining ";
            // 
            // TaxTitle
            // 
            this.TaxTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaxTitle.AutoSize = true;
            this.TaxTitle.BackColor = System.Drawing.Color.White;
            this.TaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxTitle.Location = new System.Drawing.Point(3, 46);
            this.TaxTitle.Name = "TaxTitle";
            this.TaxTitle.Size = new System.Drawing.Size(51, 25);
            this.TaxTitle.TabIndex = 2;
            this.TaxTitle.Text = "Tax";
            // 
            // CreditCardNumberLabel
            // 
            this.CreditCardNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreditCardNumberLabel.AutoSize = true;
            this.CreditCardNumberLabel.BackColor = System.Drawing.Color.White;
            this.CreditCardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreditCardNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CreditCardNumberLabel.Location = new System.Drawing.Point(3, 163);
            this.CreditCardNumberLabel.Name = "CreditCardNumberLabel";
            this.CreditCardNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreditCardNumberLabel.Size = new System.Drawing.Size(228, 25);
            this.CreditCardNumberLabel.TabIndex = 21;
            this.CreditCardNumberLabel.Text = "XXXXXXXXXXXX1234";
            // 
            // TotalTitle
            // 
            this.TotalTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalTitle.AutoSize = true;
            this.TotalTitle.BackColor = System.Drawing.Color.White;
            this.TotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalTitle.Location = new System.Drawing.Point(3, 85);
            this.TotalTitle.Name = "TotalTitle";
            this.TotalTitle.Size = new System.Drawing.Size(65, 25);
            this.TotalTitle.TabIndex = 15;
            this.TotalTitle.Text = "Total";
            // 
            // PaidWithLabel
            // 
            this.PaidWithLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PaidWithLabel.AutoSize = true;
            this.PaidWithLabel.BackColor = System.Drawing.Color.White;
            this.PaidWithLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaidWithLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.PaidWithLabel.Location = new System.Drawing.Point(3, 124);
            this.PaidWithLabel.Name = "PaidWithLabel";
            this.PaidWithLabel.Size = new System.Drawing.Size(235, 25);
            this.PaidWithLabel.TabIndex = 19;
            this.PaidWithLabel.Text = "Paid with Credit Card";
            // 
            // SubtotalPriceLabel
            // 
            this.SubtotalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SubtotalPriceLabel.AutoSize = true;
            this.SubtotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.SubtotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalPriceLabel.Location = new System.Drawing.Point(646, 7);
            this.SubtotalPriceLabel.Name = "SubtotalPriceLabel";
            this.SubtotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.SubtotalPriceLabel.TabIndex = 17;
            this.SubtotalPriceLabel.Text = "$0";
            // 
            // TotalPaidLabel
            // 
            this.TotalPaidLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalPaidLabel.AutoSize = true;
            this.TotalPaidLabel.BackColor = System.Drawing.Color.White;
            this.TotalPaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPaidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalPaidLabel.Location = new System.Drawing.Point(646, 124);
            this.TotalPaidLabel.Name = "TotalPaidLabel";
            this.TotalPaidLabel.Size = new System.Drawing.Size(36, 25);
            this.TotalPaidLabel.TabIndex = 20;
            this.TotalPaidLabel.Text = "$0";
            // 
            // CurrentDrinkOrderTable
            // 
            this.CurrentDrinkOrderTable.ColumnCount = 2;
            this.CurrentDrinkOrderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 573F));
            this.CurrentDrinkOrderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.CurrentDrinkOrderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CurrentDrinkOrderTable.Controls.Add(this.ExampleDrinkItem, 0, 2);
            this.CurrentDrinkOrderTable.Controls.Add(this.DrinkPriceExample, 1, 2);
            this.CurrentDrinkOrderTable.Location = new System.Drawing.Point(82, 111);
            this.CurrentDrinkOrderTable.Name = "CurrentDrinkOrderTable";
            this.CurrentDrinkOrderTable.RowCount = 3;
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.CurrentDrinkOrderTable.Size = new System.Drawing.Size(685, 204);
            this.CurrentDrinkOrderTable.TabIndex = 15;
            this.CurrentDrinkOrderTable.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentDrinkOrderTable_Paint);
            // 
            // ExampleDrinkItem
            // 
            this.ExampleDrinkItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExampleDrinkItem.AutoSize = true;
            this.ExampleDrinkItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExampleDrinkItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ExampleDrinkItem.Location = new System.Drawing.Point(3, 110);
            this.ExampleDrinkItem.Name = "ExampleDrinkItem";
            this.ExampleDrinkItem.Size = new System.Drawing.Size(88, 24);
            this.ExampleDrinkItem.TabIndex = 1;
            this.ExampleDrinkItem.Text = "DrinkItem";
            this.ExampleDrinkItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExampleDrinkItem.Click += new System.EventHandler(this.ExampleDrinkItem_Click);
            // 
            // DrinkPriceExample
            // 
            this.DrinkPriceExample.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DrinkPriceExample.AutoSize = true;
            this.DrinkPriceExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrinkPriceExample.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DrinkPriceExample.Location = new System.Drawing.Point(601, 110);
            this.DrinkPriceExample.Name = "DrinkPriceExample";
            this.DrinkPriceExample.Size = new System.Drawing.Size(55, 24);
            this.DrinkPriceExample.TabIndex = 2;
            this.DrinkPriceExample.Text = "$0.00";
            this.DrinkPriceExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CustomerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerNameLabel.Location = new System.Drawing.Point(615, 57);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNameLabel.Size = new System.Drawing.Size(241, 33);
            this.CustomerNameLabel.TabIndex = 15;
            this.CustomerNameLabel.Text = "First Last";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerNameTitle
            // 
            this.CustomerNameTitle.AutoSize = true;
            this.CustomerNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerNameTitle.Location = new System.Drawing.Point(615, 16);
            this.CustomerNameTitle.Name = "CustomerNameTitle";
            this.CustomerNameTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNameTitle.Size = new System.Drawing.Size(241, 33);
            this.CustomerNameTitle.TabIndex = 14;
            this.CustomerNameTitle.Text = "Customer Name";
            this.CustomerNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderNumberPanel
            // 
            this.OrderNumberPanel.Controls.Add(this.OrderNumberLabel);
            this.OrderNumberPanel.Location = new System.Drawing.Point(82, 44);
            this.OrderNumberPanel.Name = "OrderNumberPanel";
            this.OrderNumberPanel.Size = new System.Drawing.Size(522, 61);
            this.OrderNumberPanel.TabIndex = 13;
            this.OrderNumberPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderNumberPanel_Paint);
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(30, 31);
            this.OrderNumberLabel.TabIndex = 0;
            this.OrderNumberLabel.Text = "0";
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CurrentDrinkOrderTable.ResumeLayout(false);
            this.CurrentDrinkOrderTable.PerformLayout();
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
        private Panel DrinksTotal;
        private Label RewardsPointsRemainingTitle;
        private Label CreditCardNumberLabel;
        private Label TotalPaidLabel;
        private Label PaidWithLabel;
        private Label TotalPriceLabel;
        private Label SubtotalPriceLabel;
        private Label TaxPriceLabel;
        private Label TotalTitle;
        private Label TaxTitle;
        private Label SubtotalTitle;
        private Label CustomerNameTitle;
        private Label RewardsPointsLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel CurrentDrinkOrderTable;
        private Label ExampleDrinkItem;
        private Label DrinkPriceExample;
    }
}