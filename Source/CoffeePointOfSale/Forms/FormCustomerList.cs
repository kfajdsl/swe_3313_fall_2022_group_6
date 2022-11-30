using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms
{
    public partial class FormCustomerList : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;

        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void DemonstrateGettingCustomerList()
        {
            var customerList = _customerService.Customers.List;
            for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
            {
                var customer = customerList[customerIdx];
            }
        }

        private void OnLoadFormManagement(object sender, EventArgs e)
        {
            DemonstrateGettingCustomerList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        private void customerListTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
