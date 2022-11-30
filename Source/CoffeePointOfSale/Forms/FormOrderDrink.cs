using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Properties;
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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private IDrinkMenuService _drinkMenuService;
        private Customer _customer;
        private IAppSettings _appSettings;
        private Order newOrder = new Order();

        Pen backgroundpen = new Pen(Color.FromArgb(255, 242, 242, 242), 500);
        public FormOrderDrink(IAppSettings appSettings, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _drinkMenuService = drinkMenuService;
            _appSettings = appSettings;
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
        private void newDrink_Click(object sender, EventArgs e)
        {
            Button drinkButton = (sender as Button);
            int index = (int) drinkButton.Tag;
            Drink newDrink = _drinkMenuService.DrinkMenu.DrinkList[index].NewDrink();
        }
        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            int index = 0;
            foreach (DrinkMenuDrink d in _drinkMenuService.DrinkMenu.DrinkList)
            {
                Button newDrink = new Button();
                newDrink.Name = d.Name+index;
                newDrink.Text = d.Name;
                newDrink.Font = new Font("Lato", 20.25F);
                newDrink.BackColor = Color.FromArgb(90, 105, 120);
                newDrink.ForeColor = Color.White;
                newDrink.AutoSize = true;
                newDrink.Tag = index;
                newDrink.Anchor = AnchorStyles.None;
                MenuTablePanel.Controls.Add(newDrink);
                newDrink.Click += new EventHandler(this.newDrink_Click);
                index++;
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            
            
            Button drinkButton = (sender as Button);
            /*
            Button btnNewDeleteDrinkItem = new Button();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDrink));
            btnNewDeleteDrinkItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNewDeleteDrinkItem.BackColor = System.Drawing.Color.Transparent;
            btnNewDeleteDrinkItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnNewDeleteDrinkItem.FlatAppearance.BorderSize = 0;
            btnNewDeleteDrinkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewDeleteDrinkItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDrinkItem.Image")));
            btnNewDeleteDrinkItem.Location = new System.Drawing.Point(11, 3);
            btnNewDeleteDrinkItem.Name = "btnDeleteDrinkItem";
            btnNewDeleteDrinkItem.Size = new System.Drawing.Size(69, 69);
            btnNewDeleteDrinkItem.TabIndex = 0;
            btnNewDeleteDrinkItem.UseVisualStyleBackColor = false;
            btnNewDeleteDrinkItem.Click += new System.EventHandler(this.btnDeleteDrinkItem_Click);
            CurrentDrinkOrderTable.Controls.Add(btnNewDeleteDrinkItem);

            Label DrinkItem = new Label();
            DrinkItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            DrinkItem.AutoSize = true;
            DrinkItem.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DrinkItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            DrinkItem.Location = new System.Drawing.Point(94, 26);
            DrinkItem.Size = new System.Drawing.Size(95, 23);
            DrinkItem.TabIndex = 1;
            DrinkItem.Text = drinkButton.Name;
            DrinkItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CurrentDrinkOrderTable.Controls.Add(DrinkItem);

            Label NewDrinkPrice = new Label();
            NewDrinkPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            NewDrinkPrice.AutoSize = true;
            NewDrinkPrice.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewDrinkPrice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            NewDrinkPrice.Location = new System.Drawing.Point(438, 26);
            NewDrinkPrice.Name = "DrinkPrice";
            NewDrinkPrice.Size = new System.Drawing.Size(99, 23);
            NewDrinkPrice.TabIndex = 2;

            int index = 0;
            while (_drinkMenuService.DrinkMenu.List[index].Name.Equals(drinkButton.Name))
            {
                index++;
            }
            NewDrinkPrice.Text = "" + _drinkMenuService.DrinkMenu.List[index].BasePrice;
            NewDrinkPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CurrentDrinkOrderTable.Controls.Add(NewDrinkPrice);
            index = 0;
            */


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
