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
            this.OrderDrinkTitle = new System.Windows.Forms.Label();
            this.SelectDrinkPanel = new System.Windows.Forms.Panel();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SizeButton2 = new System.Windows.Forms.RadioButton();
            this.SizeButton3 = new System.Windows.Forms.RadioButton();
            this.SizeButton1 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.CustomizationPanel = new System.Windows.Forms.Panel();
            this.CustomizationLabel = new System.Windows.Forms.Label();
            this.DrinkCartPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SelectDrinkPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.CustomizationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDrinkTitle
            // 
            this.OrderDrinkTitle.AutoSize = true;
            this.OrderDrinkTitle.Font = new System.Drawing.Font("Lato", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderDrinkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderDrinkTitle.Location = new System.Drawing.Point(451, -11);
            this.OrderDrinkTitle.Name = "OrderDrinkTitle";
            this.OrderDrinkTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDrinkTitle.Size = new System.Drawing.Size(497, 102);
            this.OrderDrinkTitle.TabIndex = 2;
            this.OrderDrinkTitle.Text = "Order Drink";
            this.OrderDrinkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectDrinkPanel
            // 
            this.SelectDrinkPanel.Controls.Add(this.btnAddToOrder);
            this.SelectDrinkPanel.Controls.Add(this.tableLayoutPanel2);
            this.SelectDrinkPanel.Controls.Add(this.tableLayoutPanel1);
            this.SelectDrinkPanel.Controls.Add(this.MenuTablePanel);
            this.SelectDrinkPanel.Controls.Add(this.MenuTitle);
            this.SelectDrinkPanel.Controls.Add(this.CustomizationPanel);
            this.SelectDrinkPanel.Location = new System.Drawing.Point(22, 112);
            this.SelectDrinkPanel.Name = "SelectDrinkPanel";
            this.SelectDrinkPanel.Size = new System.Drawing.Size(627, 521);
            this.SelectDrinkPanel.TabIndex = 5;
            this.SelectDrinkPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectDrinkPanel_Paint);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(83)))));
            this.btnAddToOrder.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddToOrder.Location = new System.Drawing.Point(344, 430);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(263, 73);
            this.btnAddToOrder.TabIndex = 8;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SizeButton2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.SizeButton3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SizeButton1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(344, 317);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 93);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // SizeButton2
            // 
            this.SizeButton2.AutoSize = true;
            this.SizeButton2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeButton2.Location = new System.Drawing.Point(3, 34);
            this.SizeButton2.Name = "SizeButton2";
            this.SizeButton2.Size = new System.Drawing.Size(65, 23);
            this.SizeButton2.TabIndex = 0;
            this.SizeButton2.TabStop = true;
            this.SizeButton2.Text = "Large";
            this.SizeButton2.UseVisualStyleBackColor = true;
            // 
            // SizeButton3
            // 
            this.SizeButton3.AutoSize = true;
            this.SizeButton3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeButton3.Location = new System.Drawing.Point(3, 65);
            this.SizeButton3.Name = "SizeButton3";
            this.SizeButton3.Size = new System.Drawing.Size(66, 23);
            this.SizeButton3.TabIndex = 1;
            this.SizeButton3.TabStop = true;
            this.SizeButton3.Text = "Mega";
            this.SizeButton3.UseVisualStyleBackColor = true;
            // 
            // SizeButton1
            // 
            this.SizeButton1.AutoSize = true;
            this.SizeButton1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeButton1.Location = new System.Drawing.Point(3, 3);
            this.SizeButton1.Name = "SizeButton1";
            this.SizeButton1.Size = new System.Drawing.Size(79, 23);
            this.SizeButton1.TabIndex = 2;
            this.SizeButton1.TabStop = true;
            this.SizeButton1.Text = "Regular";
            this.SizeButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 186);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // MenuTablePanel
            // 
            this.MenuTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuTablePanel.ColumnCount = 2;
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuTablePanel.Location = new System.Drawing.Point(21, 88);
            this.MenuTablePanel.Name = "MenuTablePanel";
            this.MenuTablePanel.RowCount = 3;
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MenuTablePanel.Size = new System.Drawing.Size(586, 149);
            this.MenuTablePanel.TabIndex = 10;
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.MenuTitle.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.MenuTitle.Location = new System.Drawing.Point(20, 16);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitle.Size = new System.Drawing.Size(146, 56);
            this.MenuTitle.TabIndex = 8;
            this.MenuTitle.Text = "Menu";
            this.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomizationPanel
            // 
            this.CustomizationPanel.Controls.Add(this.CustomizationLabel);
            this.CustomizationPanel.Location = new System.Drawing.Point(11, 243);
            this.CustomizationPanel.Name = "CustomizationPanel";
            this.CustomizationPanel.Size = new System.Drawing.Size(604, 266);
            this.CustomizationPanel.TabIndex = 13;
            // 
            // CustomizationLabel
            // 
            this.CustomizationLabel.AutoSize = true;
            this.CustomizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.CustomizationLabel.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomizationLabel.Location = new System.Drawing.Point(10, 5);
            this.CustomizationLabel.Name = "CustomizationLabel";
            this.CustomizationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomizationLabel.Size = new System.Drawing.Size(328, 56);
            this.CustomizationLabel.TabIndex = 9;
            this.CustomizationLabel.Text = "Customization";
            this.CustomizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrinkCartPanel
            // 
            this.DrinkCartPanel.Location = new System.Drawing.Point(680, 112);
            this.DrinkCartPanel.Name = "DrinkCartPanel";
            this.DrinkCartPanel.Size = new System.Drawing.Size(627, 521);
            this.DrinkCartPanel.TabIndex = 6;
            this.DrinkCartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrinkCartPanel_Paint);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.CustomizationPanel.ResumeLayout(false);
            this.CustomizationPanel.PerformLayout();
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
        private RadioButton SizeButton2;
        private RadioButton SizeButton3;
        private RadioButton SizeButton1;
        private Panel CustomizationPanel;
    }
}