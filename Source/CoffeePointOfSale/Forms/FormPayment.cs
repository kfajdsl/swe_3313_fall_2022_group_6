using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.Drinks;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : Base.FormNoCloseBase
    {
        private ICustomerService _customerService;
        private IAppSettings _appSettings;

        private int _costInRewardsPoints;
        public FormPayment(ICustomerService customerService, IAppSettings appSettings) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            foreach (Drink d in _customerService.CurrentOrder.Drinks)
            {
                decimal subtotal = d.getTotal();
                decimal tax = Decimal.Round(Decimal.Multiply(subtotal, _appSettings.Tax.Rate), 2);
                decimal total = Decimal.Round(Decimal.Add(tax, subtotal), 2);

                Label DrinkItem = new Label();
                DrinkItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
                DrinkItem.AutoSize = true;
                DrinkItem.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                DrinkItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
                DrinkItem.Location = new System.Drawing.Point(94, 26);
                DrinkItem.Size = new System.Drawing.Size(95, 23);
                DrinkItem.TabIndex = 1;
                DrinkItem.Text = "" + d.Name + ": " + d + " $" + total;
                DrinkItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                CurrentDrinkOrderTable.Controls.Add(DrinkItem);
            }
            SubtotalPriceLabel.Text = "$" + _customerService.CurrentOrder.SubTotal;
            TaxPriceLabel.Text = "$" + _customerService.CurrentOrder.Tax;
            TotalPriceLabel.Text = "$" + _customerService.CurrentOrder.Total;

            Customer customer = _customerService.CurrentCustomer;
            _costInRewardsPoints = (int)Math.Ceiling(Decimal.Multiply(_customerService.CurrentOrder.Total, (decimal)_appSettings.Rewards.PointsPerDollar));
            if (customer.IsAnonymous)
            {
                RewardsPanel.Visible = false;
            } else
            {
                RewardsPanel.Visible = true;
                CustomerRewardsLabel.Text = ""+customer.RewardPoints;
                OrderRewardsCost.Text = ""+_costInRewardsPoints;
                if (customer.RewardPoints >= _costInRewardsPoints)
                {
                    btnPayWithRewards.Enabled = true;
                    btnPayWithRewards.BackColor = Color.FromArgb(119, 221, 83);
                }
            }

            CreditCardTextInput.Tag = CreditCardTextInput.Text;
            CreditCardTextInput.GotFocus += new EventHandler(this.PlaceholderGotFocus);
            CreditCardTextInput.LostFocus += new EventHandler(this.PlaceholderLostFocus);

            CVVTextBox.Tag = CVVTextBox.Text;
            CVVTextBox.GotFocus += new EventHandler(this.PlaceholderGotFocus);
            CVVTextBox.LostFocus += new EventHandler(this.PlaceholderLostFocus);

            //btnPayWithCard
            //btnPayWithRewards 
        }
        private void btnPayWithRewards_Click(object sender, EventArgs e)
        {
            _customerService.CurrentCustomer.RewardPoints -= _costInRewardsPoints;
            _customerService.CurrentOrder.PointsRedeemed = _costInRewardsPoints;
            Close(); //closes this form
            FormFactory.Get<FormReceipt>().Show(); //opens the receipt form
        }

        private void btnPayWithCard_Click(object sender, EventArgs e)
        {

        }
        
        
        public void PlaceholderGotFocus(object sender, EventArgs e)
        {
            var txtBox = (sender as TextBox);
            var placeholder = (txtBox.Tag as string);
            if (txtBox.Text == placeholder) 
            {
                txtBox.Text = "";
            }
        }
        
        public void PlaceholderLostFocus(object sender, EventArgs e)
        {
            var txtBox = (sender as TextBox);
            var placeholder = (txtBox.Tag as string);
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.Text = placeholder;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormOrderDrink>().Show(); //re-opens the order form
        }

    }
}
