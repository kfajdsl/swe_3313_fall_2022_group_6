namespace CoffeePointOfSale.Forms
{
    partial class FormManagement
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
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OrderDrinkTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Go Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnClickBtnClose);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.button2.Font = new System.Drawing.Font("Lato", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(397, 158);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // OrderDrinkTitle
            // 
            this.OrderDrinkTitle.AutoSize = true;
            this.OrderDrinkTitle.Font = new System.Drawing.Font("Lato", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderDrinkTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderDrinkTitle.Location = new System.Drawing.Point(397, 11);
            this.OrderDrinkTitle.Name = "OrderDrinkTitle";
            this.OrderDrinkTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OrderDrinkTitle.Size = new System.Drawing.Size(540, 102);
            this.OrderDrinkTitle.TabIndex = 4;
            this.OrderDrinkTitle.Text = "Management";
            this.OrderDrinkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 682);
            this.Controls.Add(this.OrderDrinkTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagement";
            this.Text = "FormManagement";
            this.Load += new System.EventHandler(this.OnLoadFormManagement);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Button button2;
        private Label OrderDrinkTitle;
    }
}