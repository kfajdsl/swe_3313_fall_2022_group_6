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

namespace CoffeePointOfSale.Forms
{
    public partial class FormAddCustomer : FormNoCloseBase
    {
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        private void CustomerListTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(  
                (textBox1).Text.Length > 0 &&
                (textBox2).Text.Length > 0 &&
                (textBox3).Text.Length > 0
            )
            {

            }
            else
            {

            }
        }
    }
}
