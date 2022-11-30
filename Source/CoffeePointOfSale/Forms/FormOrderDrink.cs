using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
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
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private DrinkMenuService _drinkMenuService;
        private Customer _customer;
        private IAppSettings _appSettings;

        Pen backgroundpen = new Pen(Color.FromArgb(255, 242, 242, 242), 500);
        public FormOrderDrink()
        {
            InitializeComponent();
        }

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void SelectDrinkPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 500, 500);
        }

        private void DrinkCartPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 500, 500);
        }

        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            /*
            foreach (Drink d in _drinkMenuService.DrinkMenu.List)
            {
                Button newDrink = new Button();
                newDrink.Name = d.Name;
                newDrink.Text = d.Name;
                MenuTablePanel.Controls.Add(newDrink);
            }
            
            Label testBtn = new Label();
            testBtn.Name = "test";
            testBtn.Text = "test";
            MenuTablePanel.Controls.Add(testBtn);
            */
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //Adds drink with customizations to the current order
            //Leaves the current drink selection on the screen
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormReceipt>().Show(); //opens the receipt screen with the current order
        }

        private void btnDeleteDrinkItem_Click(object sender, EventArgs e)
        {
            //Removes the drink from the order
            //Clear the drink from the order table panel
        }
    }
}
