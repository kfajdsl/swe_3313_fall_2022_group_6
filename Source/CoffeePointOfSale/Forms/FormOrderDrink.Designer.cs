namespace CoffeePointOfSale.Forms
{
    partial class FormOrderDrink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDrink));
            this.OrderDrinkTitle = new System.Windows.Forms.Label();
            this.SelectDrinkPanel = new System.Windows.Forms.Panel();
            this.MenuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.CustomizationPanel = new System.Windows.Forms.Panel();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.CustomizationLabel = new System.Windows.Forms.Label();
            this.SizeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomizationsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrinkCartPanel = new System.Windows.Forms.Panel();
            this.CurrentOrderPanel = new System.Windows.Forms.Panel();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
            this.TaxPriceLabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.CurrentDrinkOrderTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteDrinkItem = new System.Windows.Forms.Button();
            this.ExampleDrinkItem = new System.Windows.Forms.Label();
            this.SubtotalPriceLabel = new System.Windows.Forms.Label();
            this.CurrentOrderTitle = new System.Windows.Forms.Label();
            this.TotalTitle = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SelectDrinkPanel.SuspendLayout();
            this.CustomizationPanel.SuspendLayout();
            this.DrinkCartPanel.SuspendLayout();
            this.CurrentOrderPanel.SuspendLayout();
            this.CurrentDrinkOrderTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDrinkTitle
            // 
            this.OrderDrinkTitle.AutoSize = true;
            this.OrderDrinkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderDrinkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderDrinkTitle.Location = new System.Drawing.Point(451, -11);
            this.OrderDrinkTitle.Name = "OrderDrinkTitle";
            this.OrderDrinkTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDrinkTitle.Size = new System.Drawing.Size(489, 96);
            this.OrderDrinkTitle.TabIndex = 2;
            this.OrderDrinkTitle.Text = "Order Drink";
            this.OrderDrinkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDrinkPanel
            // 
            this.SelectDrinkPanel.Controls.Add(this.MenuTablePanel);
            this.SelectDrinkPanel.Controls.Add(this.MenuTitle);
            this.SelectDrinkPanel.Controls.Add(this.CustomizationPanel);
            this.SelectDrinkPanel.Location = new System.Drawing.Point(22, 112);
            this.SelectDrinkPanel.Name = "SelectDrinkPanel";
            this.SelectDrinkPanel.Size = new System.Drawing.Size(627, 521);
            this.SelectDrinkPanel.TabIndex = 5;
            this.SelectDrinkPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectDrinkPanel_Paint);
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.AutoScroll = true;
            this.MenuTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuTablePanel.ColumnCount = 2;
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTablePanel.Location = new System.Drawing.Point(11, 64);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.RowCount = 3;
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.Size = new System.Drawing.Size(604, 165);
            this.MenuTablePanel.TabIndex = 10;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.MenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.MenuTitle.Location = new System.Drawing.Point(21, 5);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitle.Size = new System.Drawing.Size(144, 54);
            this.MenuTitle.TabIndex = 8;
            this.MenuTitle.Text = "Menu";
            this.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomizationPanel
            // 
            this.CustomizationPanel.BackColor = System.Drawing.Color.White;
            this.CustomizationPanel.Controls.Add(this.btnAddToOrder);
            this.CustomizationPanel.Controls.Add(this.CustomizationLabel);
            this.CustomizationPanel.Controls.Add(this.SizeTablePanel);
            this.CustomizationPanel.Controls.Add(this.CustomizationsTablePanel);
            this.CustomizationPanel.Enabled = false;
            this.CustomizationPanel.Location = new System.Drawing.Point(11, 243);
            this.CustomizationPanel.Name = "CustomizationPanel";
            this.CustomizationPanel.Size = new System.Drawing.Size(604, 266);
            this.CustomizationPanel.TabIndex = 13;
            this.CustomizationPanel.Visible = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(324, 184);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(263, 73);
            this.btnAddToOrder.TabIndex = 8;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // CustomizationLabel
            // 
            this.CustomizationLabel.AutoSize = true;
            this.CustomizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomizationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomizationLabel.Location = new System.Drawing.Point(10, 5);
            this.CustomizationLabel.Name = "CustomizationLabel";
            this.CustomizationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomizationLabel.Size = new System.Drawing.Size(333, 54);
            this.CustomizationLabel.TabIndex = 9;
            this.CustomizationLabel.Text = "Customization";
            this.CustomizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeTablePanel
            // 
            this.SizeTablePanel.AutoScroll = true;
            this.SizeTablePanel.ColumnCount = 1;
            this.SizeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SizeTablePanel.Location = new System.Drawing.Point(333, 64);
            this.SizeTablePanel.Name = "SizeTablePanel";
            this.SizeTablePanel.RowCount = 1;
            this.SizeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SizeTablePanel.Size = new System.Drawing.Size(263, 93);
            this.SizeTablePanel.TabIndex = 12;
            this.SizeTablePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SizeTablePanel_Paint);
            // 
            // CustomizationsTablePanel
            // 
            this.CustomizationsTablePanel.AutoScroll = true;
            this.CustomizationsTablePanel.BackColor = System.Drawing.Color.White;
            this.CustomizationsTablePanel.ColumnCount = 2;
            this.CustomizationsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CustomizationsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.CustomizationsTablePanel.Location = new System.Drawing.Point(10, 64);
            this.CustomizationsTablePanel.Name = "CustomizationsTablePanel";
            this.CustomizationsTablePanel.RowCount = 3;
            this.CustomizationsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CustomizationsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CustomizationsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CustomizationsTablePanel.Size = new System.Drawing.Size(292, 186);
            this.CustomizationsTablePanel.TabIndex = 11;
            // 
            // DrinkCartPanel
            // 
            this.DrinkCartPanel.Controls.Add(this.CurrentOrderPanel);
            this.DrinkCartPanel.Location = new System.Drawing.Point(680, 112);
            this.DrinkCartPanel.Name = "DrinkCartPanel";
            this.DrinkCartPanel.Size = new System.Drawing.Size(627, 521);
            this.DrinkCartPanel.TabIndex = 6;
            this.DrinkCartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrinkCartPanel_Paint);
            // 
            // CurrentOrderPanel
            // 
            this.CurrentOrderPanel.Controls.Add(this.btnProceedToPayment);
            this.CurrentOrderPanel.Controls.Add(this.TaxPriceLabel);
            this.CurrentOrderPanel.Controls.Add(this.TotalPriceLabel);
            this.CurrentOrderPanel.Controls.Add(this.CurrentDrinkOrderTable);
            this.CurrentOrderPanel.Controls.Add(this.SubtotalPriceLabel);
            this.CurrentOrderPanel.Controls.Add(this.CurrentOrderTitle);
            this.CurrentOrderPanel.Controls.Add(this.TotalTitle);
            this.CurrentOrderPanel.Controls.Add(this.TaxLabel);
            this.CurrentOrderPanel.Controls.Add(this.SubtotalLabel);
            this.CurrentOrderPanel.Location = new System.Drawing.Point(21, 17);
            this.CurrentOrderPanel.Name = "CurrentOrderPanel";
            this.CurrentOrderPanel.Size = new System.Drawing.Size(587, 483);
            this.CurrentOrderPanel.TabIndex = 0;
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.LightGray;
            this.btnProceedToPayment.Enabled = false;
            this.btnProceedToPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToPayment.ForeColor = System.Drawing.Color.White;
            this.btnProceedToPayment.Location = new System.Drawing.Point(300, 365);
            this.btnProceedToPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(263, 73);
            this.btnProceedToPayment.TabIndex = 14;
            this.btnProceedToPayment.Text = "Proceed to Payment";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // TaxPriceLabel
            // 
            this.TaxPriceLabel.AutoSize = true;
            this.TaxPriceLabel.BackColor = System.Drawing.Color.White;
            this.TaxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxPriceLabel.Location = new System.Drawing.Point(170, 386);
            this.TaxPriceLabel.Name = "TaxPriceLabel";
            this.TaxPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TaxPriceLabel.TabIndex = 22;
            this.TaxPriceLabel.Text = "$0";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalPriceLabel.Location = new System.Drawing.Point(170, 418);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.TotalPriceLabel.TabIndex = 21;
            this.TotalPriceLabel.Text = "$0";
            // 
            // CurrentDrinkOrderTable
            // 
            this.CurrentDrinkOrderTable.AutoScroll = true;
            this.CurrentDrinkOrderTable.ColumnCount = 2;
            this.CurrentDrinkOrderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.CurrentDrinkOrderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.CurrentDrinkOrderTable.Controls.Add(this.btnDeleteDrinkItem, 0, 0);
            this.CurrentDrinkOrderTable.Controls.Add(this.ExampleDrinkItem, 1, 0);
            this.CurrentDrinkOrderTable.Location = new System.Drawing.Point(13, 47);
            this.CurrentDrinkOrderTable.Name = "CurrentDrinkOrderTable";
            this.CurrentDrinkOrderTable.RowCount = 4;
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CurrentDrinkOrderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CurrentDrinkOrderTable.Size = new System.Drawing.Size(561, 284);
            this.CurrentDrinkOrderTable.TabIndex = 14;
            // 
            // btnDeleteDrinkItem
            // 
            this.btnDeleteDrinkItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteDrinkItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteDrinkItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteDrinkItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteDrinkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDrinkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDrinkItem.Image")));
            this.btnDeleteDrinkItem.Location = new System.Drawing.Point(11, 3);
            this.btnDeleteDrinkItem.Name = "btnDeleteDrinkItem";
            this.btnDeleteDrinkItem.Size = new System.Drawing.Size(69, 65);
            this.btnDeleteDrinkItem.TabIndex = 0;
            this.btnDeleteDrinkItem.UseVisualStyleBackColor = false;
            this.btnDeleteDrinkItem.Visible = false;
            this.btnDeleteDrinkItem.Click += new System.EventHandler(this.btnDeleteDrinkItem_Click);
            // 
            // ExampleDrinkItem
            // 
            this.ExampleDrinkItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExampleDrinkItem.AutoSize = true;
            this.ExampleDrinkItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExampleDrinkItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ExampleDrinkItem.Location = new System.Drawing.Point(94, 23);
            this.ExampleDrinkItem.Name = "ExampleDrinkItem";
            this.ExampleDrinkItem.Size = new System.Drawing.Size(88, 24);
            this.ExampleDrinkItem.TabIndex = 1;
            this.ExampleDrinkItem.Text = "DrinkItem";
            this.ExampleDrinkItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExampleDrinkItem.Visible = false;
            // 
            // SubtotalPriceLabel
            // 
            this.SubtotalPriceLabel.AutoSize = true;
            this.SubtotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.SubtotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalPriceLabel.Location = new System.Drawing.Point(170, 355);
            this.SubtotalPriceLabel.Name = "SubtotalPriceLabel";
            this.SubtotalPriceLabel.Size = new System.Drawing.Size(36, 25);
            this.SubtotalPriceLabel.TabIndex = 20;
            this.SubtotalPriceLabel.Text = "$0";
            // 
            // CurrentOrderTitle
            // 
            this.CurrentOrderTitle.AutoSize = true;
            this.CurrentOrderTitle.BackColor = System.Drawing.Color.Transparent;
            this.CurrentOrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentOrderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CurrentOrderTitle.Location = new System.Drawing.Point(0, -12);
            this.CurrentOrderTitle.Name = "CurrentOrderTitle";
            this.CurrentOrderTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentOrderTitle.Size = new System.Drawing.Size(326, 54);
            this.CurrentOrderTitle.TabIndex = 14;
            this.CurrentOrderTitle.Text = "Current Order";
            this.CurrentOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalTitle
            // 
            this.TotalTitle.AutoSize = true;
            this.TotalTitle.BackColor = System.Drawing.Color.White;
            this.TotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TotalTitle.Location = new System.Drawing.Point(16, 418);
            this.TotalTitle.Name = "TotalTitle";
            this.TotalTitle.Size = new System.Drawing.Size(60, 25);
            this.TotalTitle.TabIndex = 19;
            this.TotalTitle.Text = "Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.BackColor = System.Drawing.Color.White;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.TaxLabel.Location = new System.Drawing.Point(13, 386);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(48, 25);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.BackColor = System.Drawing.Color.White;
            this.SubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.SubtotalLabel.Location = new System.Drawing.Point(13, 352);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(91, 25);
            this.SubtotalLabel.TabIndex = 1;
            this.SubtotalLabel.Text = "Subtotal";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 70);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // FormOrderDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DrinkCartPanel);
            this.Controls.Add(this.OrderDrinkTitle);
            this.Controls.Add(this.SelectDrinkPanel);
            this.Name = "FormOrderDrink";
            this.Text = "FormOrderDrink";
            this.Load += new System.EventHandler(this.FormOrderDrink_Load);
            this.SelectDrinkPanel.ResumeLayout(false);
            this.SelectDrinkPanel.PerformLayout();
            this.CustomizationPanel.ResumeLayout(false);
            this.CustomizationPanel.PerformLayout();
            this.DrinkCartPanel.ResumeLayout(false);
            this.CurrentOrderPanel.ResumeLayout(false);
            this.CurrentOrderPanel.PerformLayout();
            this.CurrentDrinkOrderTable.ResumeLayout(false);
            this.CurrentDrinkOrderTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MenuTitle;
        private Panel panel1;
        private Panel panel2;
        private Label OrderDrinkTitle;
        private Panel SelectDrinkPanel;
        private Panel DrinkCartPanel;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel MenuTablePanel;
        private Label CustomizationLabel;
        private Button btnAddToOrder;
        private Panel CustomizationPanel;
        private Panel CurrentOrderPanel;
        private Label CurrentOrderTitle;
        private Label TaxLabel;
        private Label SubtotalLabel;
        private Button btnProceedToOrder;
        private Label TaxPriceLabel;
        private Label TotalPriceLabel;
        private Label SubtotalPriceLabel;
        private Label TotalLabel;
        private TableLayoutPanel CurrentDrinkOrderTable;
        private Button btnDeleteDrinkItem;
        private Label ExampleDrinkItem;
        private Label TotalTitle;
        private Button btnProceedToPayment;
        private TableLayoutPanel SizeTablePanel;
        private TableLayoutPanel CustomizationsTablePanel;
    }
}