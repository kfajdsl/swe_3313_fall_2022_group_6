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
            int costInRewardsPoints = (int)Math.Ceiling(Decimal.Multiply(_customerService.CurrentOrder.Total, (decimal)_appSettings.Rewards.PointsPerDollar));
            if (customer.IsAnonymous)
            {
                RewardsPanel.Visible = false;
            } else
            {
                CustomerRewardsLabel.Text = ""+customer.RewardPoints;
                OrderRewardsCost.Text = ""+costInRewardsPoints;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormOrderDrink>().Show(); //re-opens the main form
        }
    }
}
