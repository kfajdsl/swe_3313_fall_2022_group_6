namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.CustomerListLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.RewardPointsLabel = new System.Windows.Forms.Label();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 11);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 70);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustomerListLable
            // 
            this.CustomerListLable.AutoSize = true;
            this.CustomerListLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerListLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerListLable.Location = new System.Drawing.Point(388, 2);
            this.CustomerListLable.Name = "CustomerListLable";
            this.CustomerListLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerListLable.Size = new System.Drawing.Size(578, 96);
            this.CustomerListLable.TabIndex = 10;
            this.CustomerListLable.Text = "Customer List";
            this.CustomerListLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PhoneLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RewardPointsLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(88, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 489);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(634, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(4, 1);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(128, 34);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLabel.Location = new System.Drawing.Point(448, 1);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(179, 34);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Phone Number";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(139, 1);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(131, 34);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RewardPointsLabel
            // 
            this.RewardPointsLabel.AutoSize = true;
            this.RewardPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RewardPointsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardPointsLabel.Location = new System.Drawing.Point(277, 1);
            this.RewardPointsLabel.Name = "RewardPointsLabel";
            this.RewardPointsLabel.Size = new System.Drawing.Size(164, 34);
            this.RewardPointsLabel.TabIndex = 14;
            this.RewardPointsLabel.Text = "Reward Points";
            this.RewardPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(211)))), ((int)(((byte)(83)))));
            this.btnCreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(436, 610);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(550, 60);
            this.btnCreateNewCustomer.TabIndex = 13;
            this.btnCreateNewCustomer.Text = "Create New Customer and Order";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = false;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // FormCustomerList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.btnCreateNewCustomer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CustomerListLable);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormCustomerList2";
            this.Text = "FormCustomerList2";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Label CustomerListLable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LastNameLabel;
        private Label PhoneLabel;
        private Label FirstNameLabel;
        private Label RewardPointsLabel;
        private Button btnCreateNewCustomer;
        private Label label1;
    }
}