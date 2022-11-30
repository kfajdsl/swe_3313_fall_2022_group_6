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
    public partial class FormReceipt : Base.FormNoCloseBase
    {

        private readonly ICustomerService _customerService;
        Pen backgroundpen = new Pen(Color.FromArgb(255, 150, 159, 170), 6);


        //Constructor
        public FormReceipt(IAppSettings ap, ICustomerService customerService) : base(ap)
        {
            _customerService = customerService;
            InitializeComponent();

            //Add all the drinks and customizations to the receipt
            foreach (Drink i in
                _customerService.CurrentOrder.Drinks)
            {
                //Create empty Lables and gives format
                Label _label1 = new Label();
                Label _label2 = new Label();
                _label1.Font = _label2.Font = new Font("Arial", 16);
                _label1.TextAlign = _label2.TextAlign = ContentAlignment.TopLeft;

                _label1.Text = i.Name;
                _label2.Text = "$" + i.getTotal();

                foreach (Customization j in i.Customizations)
                {
                    _label1.Text += "\n\t - \t"+j.Name.Trim()+"";
                    _label2.Text += "\n\t\t" + "(" +j.Price+")";
                }
                _label1.Text += "\n";
                _label2.Text += "\n";

                _label1.AutoSize = true;
                _label2.AutoSize = true;


                CurrentDrinkOrderTable.Controls.Add(_label1);
                CurrentDrinkOrderTable.Controls.Add(_label2);
            }


            //Add all the general details to the receipt

            OrderNumberLabel.Text = _customerService.CurrentOrder.OrderID;
            CustomerNameTitle.Text = _customerService.CurrentCustomer.FirstName;
            CustomerNameLabel.Text = _customerService.CurrentCustomer.LastName;

            SubtotalPriceLabel.Text = "$" + _customerService.CurrentOrder.SubTotal;
            TaxPriceLabel.Text = "$" + _customerService.CurrentOrder.Tax;
            TotalPriceLabel.Text = "$" + _customerService.CurrentOrder.Total;

            if (_customerService.CurrentOrder.PaymentMethod == OrderPaymentMethod.Credit)   //Credit Card
            {
                TotalPaidLabel.Text = "$" + _customerService.CurrentOrder.Total;
                CreditCardNumberLabel.Text = "XXXX-XXXX-XXXX-" + _customerService.CurrentOrder.CreditCardLast4Digits;

                if (_customerService.CurrentCustomer.IsAnonymous)   //Anonimous customer, no rewards
                {
                    RewardsPointsRemainingTitle.Visible = false;
                    RewardsPointsLabel.Visible = false;
                }
                else //Regular costumer
                {
                    RewardsPointsLabel.Text = _customerService.CurrentCustomer.RewardPoints + "";
                }
            }
            else //Reward Points
            {
                CreditCardNumberLabel.Visible = false;
                TotalPaidLabel.Text = _customerService.CurrentOrder.PointsRedeemed + "";
                PaidWithLabel.Text = "Paid with Rewards";
                RewardsPointsLabel.Text = "" + _customerService.CurrentCustomer.RewardPoints;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _customerService.Write();
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void OrderNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 88, 61);
        }

        private void ReceiptPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CurrentDrinkOrderTable_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ExampleDrinkItem_Click(object sender, EventArgs e)
        {

        }

        private void RewardsPointsRemainingTitle_Click(object sender, EventArgs e)
        {

        }

        private void RewardsPointsLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaidWithLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
