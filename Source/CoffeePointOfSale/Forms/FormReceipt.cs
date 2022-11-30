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

        public FormReceipt(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void OrderNumberPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 88, 61);
        }

        private void ReceiptPanel_Paint(object sender, PaintEventArgs e)
        {
            OrderNumberLabel.Text = _customerService.CurrentOrder.OrderID;
            CustomerNameTitle.Text = _customerService.CurrentCustomer.FirstName;
            CustomerNameLabel.Text = _customerService.CurrentCustomer.LastName;

            SubtotalPriceLabel.Text = "$"+ _customerService.CurrentOrder.SubTotal;
            TaxPriceLabel.Text = "$"+ _customerService.CurrentOrder.Tax;
            TotalPriceLabel.Text = "$" + _customerService.CurrentOrder.Total;


            CreditCardNumberLabel.Text = "xxxx-xxxx-xxxx-";
            for (int i = 5; i > 0; i--)
                CreditCardNumberLabel.Text += "y";//_customerService.CurrentOrder.creditcard[];
        }

        private void CurrentDrinkOrderTable_Paint(object sender, PaintEventArgs e)
        {
            foreach (Drink i in
                _customerService.CurrentOrder.Drinks)
            {
                //Create empty Lables and gives format
                Label _label1 = new Label();
                Label _label2 = new Label();
                _label1.Font = _label2.Font = new Font("Arial", 16);
                _label1.TextAlign = _label2.TextAlign = ContentAlignment.TopCenter;

                _label1.Text = i.Name;
                _label2.Text = "$"+i.getTotal();

                CurrentDrinkOrderTable.Controls.Add(_label1);
                CurrentDrinkOrderTable.Controls.Add(_label2);
            }
        }

        private void ExampleDrinkItem_Click(object sender, EventArgs e)
        {

        }
    }
}
