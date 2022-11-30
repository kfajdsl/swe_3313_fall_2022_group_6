using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Customer;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : FormNoCloseBase
    {
        //Customer Service to read the customers
        private readonly ICustomerService _customerService;

        //Constructor
        public FormCustomerList(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        //When it loads add all the fields in the Customer table
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            //Create empty Lables and gives format
            Label _label1 = new Label();
            Label _label2 = new Label();
            Label _label3 = new Label();
            Label _label4 = new Label();
            _label1.Font = _label2.Font = _label3.Font = _label4.Font = new Font("Arial", 16);
            _label1.TextAlign = _label2.TextAlign = _label3.TextAlign = _label4.TextAlign = ContentAlignment.TopCenter;

            //Creates empty buttons and gives format and functionality
            Button _button = new Button();
            _button.Text = "Order";
            _button.Font = new Font("Arial", 16, FontStyle.Bold);
            _button.TextAlign = ContentAlignment.TopCenter;
            _button.BackColor = Color.FromArgb(119, 211, 83);
            _button.ForeColor = Color.White;

            //Adds every customer to the table
            foreach (Customer customer in
                _customerService.Customers.List)
            {
                _label1.Text = customer.LastName;
                _label2.Text = customer.FirstName;
                _label3.Text = customer.Phone;
                _label2.Text = customer.RewardPoints+"";
                
                tableLayoutPanel1.Controls.Add(_label1);
                tableLayoutPanel1.Controls.Add(_label2);
                tableLayoutPanel1.Controls.Add(_label3);
                tableLayoutPanel1.Controls.Add(_label4);

                tableLayoutPanel1.Controls.Add(_button);
            }
        }

        //Goes back to Main
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        //Goes to Add Customer Form
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormAddCustomer>().Show();
        }
    }
}
