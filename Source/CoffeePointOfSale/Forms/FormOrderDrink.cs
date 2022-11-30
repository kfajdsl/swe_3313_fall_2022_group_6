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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms
{
    public partial class FormOrderDrink : Base.FormNoCloseBase
    {
        private IDrinkMenuService _drinkMenuService;
        private IAppSettings _appSettings;
        private ICustomerService _customerService;

        private Order newOrder = new Order();
        private Drink activeDrink = new Drink();

        Pen backgroundpen = new Pen(Color.FromArgb(255, 242, 242, 242), 500);
        public FormOrderDrink(ICustomerService customerService, IAppSettings appSettings, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _customerService = customerService;
            _drinkMenuService = drinkMenuService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void FormOrderDrink_Load(object sender, EventArgs e)
        {
            // Adds each drink item to the MenuTable
            foreach (DrinkMenuDrink d in _drinkMenuService.DrinkMenu.DrinkList)
            {
                // Creates a new button for a DrinkMenuItem
                Button newDrink = new Button();
                newDrink.Name = d.Name;
                newDrink.Text = d.Name;
                newDrink.Font = new Font("Lato", 20.25F);
                newDrink.BackColor = Color.FromArgb(90, 105, 120);
                newDrink.ForeColor = Color.White;
                newDrink.AutoSize = true;
                newDrink.Tag = d;
                newDrink.Anchor = AnchorStyles.None;
                MenuTablePanel.Controls.Add(newDrink);
                // Creates a new event handler for the DrinkMenuItem button
                newDrink.Click += new EventHandler(this.drinkButton_Click);
            }

            // Adds each customization to the CustomizationMenuTable
            foreach (DrinkMenuCustomization c in _drinkMenuService.DrinkMenu.CustomizationList)
            {
                // Creates a new button for a DrinkMenuCustomization
                Button newCustomization = new Button();
                newCustomization.Name = c.Name;
                newCustomization.Text = c.Name;
                newCustomization.Font = new Font("Lato", 20.25F);
                newCustomization.BackColor = Color.FromArgb(90, 105, 120);
                newCustomization.ForeColor = Color.White;
                newCustomization.AutoSize = true;
                newCustomization.Tag = c;
                newCustomization.Anchor = AnchorStyles.None;
                CustomizationsTablePanel.Controls.Add(newCustomization);
                // Creates a new event handler for the DrinkMenuCustomization button
                newCustomization.Click += new EventHandler(this.customizationButton_Click);
            }

            foreach (DrinkMenuCustomization s in _drinkMenuService.DrinkMenu.SizeList)
            {
                // Radio controls for each size
                RadioButton newSize = new RadioButton();
                newSize.Name = s.Name;
                newSize.Text = s.Name;
                newSize.AutoSize = true;
                newSize.Tag = s;
                SizeTablePanel.Controls.Add(newSize);
                SizeTablePanel.RowCount++;
                SizeTablePanel.RowStyles.Add(new RowStyle());
            }
        }

        private void SelectDrinkPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 500, 500);
        }

        private void DrinkCartPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(backgroundpen, 0, 0, 500, 500);
        }
        private void drinkButton_Click(object sender, EventArgs e)
        {
            // Adds the drink button pressed as an object
            Button drinkButton = (sender as Button);
            // Creates a new drink with base size
            activeDrink = ((DrinkMenuDrink) drinkButton.Tag).NewDrink();
            activeDrink.Customizations.Add(_drinkMenuService.DrinkMenu.SizeList[0].NewCustomization());
            // Unhides the customizations pannel
            CustomizationPanel.Enabled = true;
            CustomizationPanel.Visible = true;
            CustomizationPanel.BackColor = Color.White;
            CustomizationLabel.Text = drinkButton.Text;
        }
        private void customizationButton_Click(object sender, EventArgs e)
        {
            // Adds the customization button pressed as an object
            Button customizationButton = (sender as Button);
            // Adds the new customization to the active drink
            Customization newCustomization = ((DrinkMenuCustomization) customizationButton.Tag).NewCustomization();
            activeDrink.Customizations.Add(newCustomization);
            customizationButton.BackColor = Color.FromArgb(119, 221, 83);
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            RadioButton sizeRadio = (sender as RadioButton);
            Customization newSize = ((DrinkMenuCustomization)sizeRadio.Tag).NewCustomization();
            activeDrink.Customizations[0] = newSize; // HACK we can always just assume that the first element is the size
        }
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            // Creates the delete drink button
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

            // Creates the drink info label
            decimal subtotal = activeDrink.getTotal();
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
            DrinkItem.Text = "" + activeDrink.Name + ": " + activeDrink + " $" + total;
            DrinkItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Sets tag to the drink and label
            btnNewDeleteDrinkItem.Tag = new {drinkItem = activeDrink, drinkLabel = DrinkItem};
            // Adds the delete button and item label
            CurrentDrinkOrderTable.Controls.Add(btnNewDeleteDrinkItem);
            CurrentDrinkOrderTable.Controls.Add(DrinkItem);

            newOrder.Drinks.Add(activeDrink);
            newOrder.Total += total;
            newOrder.Tax += tax;
            newOrder.SubTotal += subtotal;
            SubtotalPriceLabel.Text = "$" + newOrder.SubTotal;
            TaxPriceLabel.Text = "$" + newOrder.Tax;
            TotalPriceLabel.Text = "$" + newOrder.Total;
            activeDrink = new Drink();

            // Enables pay button
            btnProceedToPayment.Enabled = true;
            btnProceedToPayment.BackColor = Color.FromArgb(119, 221, 83);
            // Disables customization menu
            CustomizationPanel.Enabled = false;
            CustomizationPanel.Visible = false;

        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            _customerService.CurrentOrder = newOrder;
            newOrder = new Order();
            Close(); //closes this form
            FormFactory.Get<FormReceipt>().Show(); //opens the receipt screen with the current order
        }

        private void btnDeleteDrinkItem_Click(object sender, EventArgs e)
        {
            Button deleteButton = (sender as Button);
            Drink deleteDrink = ((dynamic)deleteButton.Tag).drinkItem;
            Label deleteLabel = ((dynamic)deleteButton.Tag).drinkLabel;
            newOrder.Drinks.Remove(deleteDrink);
            newOrder.SubTotal -= deleteDrink.getTotal();
            newOrder.Tax -= Decimal.Round(Decimal.Multiply(deleteDrink.getTotal(), _appSettings.Tax.Rate), 2);
            newOrder.Total -= (deleteDrink.getTotal() + Decimal.Round(Decimal.Multiply(deleteDrink.getTotal(), _appSettings.Tax.Rate), 2));
            CurrentDrinkOrderTable.Controls.Remove(deleteLabel);
            CurrentDrinkOrderTable.Controls.Remove(deleteButton);

            //Updates Order Price Labels
            SubtotalPriceLabel.Text = "$" + newOrder.SubTotal;
            TaxPriceLabel.Text = "$" + newOrder.Tax;
            TotalPriceLabel.Text = "$" + newOrder.Total;
            //Disables pay button if order is now empty
            if (newOrder.Drinks.Count == 0)
            {
                btnProceedToPayment.Enabled = false;
                btnProceedToPayment.BackColor = Color.LightGray;
            }
        }

        private void btnCustomization_Click(object sender, EventArgs e)
        {

        }

        private void SizeTablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
