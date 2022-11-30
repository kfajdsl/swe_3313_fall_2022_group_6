using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormAddCustomer : FormNoCloseBase
    {
        //Customer Service to add a new customer
        private ICustomerService _customerService;

        //Control the user input for every text field
        bool validFirstName = false, 
            validLastName = false, 
            validPhone = false;

        //Constructor
        public FormAddCustomer(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService= customerService;
            InitializeComponent();
        }

        //Change the color of the button if the input is valid
        private void updateBtnColor()
        {
            if (validFirstName && validLastName && validPhone)
                btnAddCustomer.BackColor = Color.FromArgb(119, 211, 83);
            else
                btnAddCustomer.BackColor = Color.DarkGray;
        }

        //Validates the First Name
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length == 0)
                validFirstName = false;
            else
                validFirstName = true;
            updateBtnColor();
        }

        //Validates the Last Name
        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text.Length == 0)
                validLastName = false;
            else
                validLastName = true;
            updateBtnColor();
        }

        //Validates the Phone Number
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            //Phone validation, 10 digits and 2 dashes, and not already on the Customers
            if (PhoneTextBox.Text.Length != 10 + 2 || _customerService.Customers[PhoneTextBox.Text] != null)
                validPhone = false;
            else
                validPhone = true;
            updateBtnColor();
        }

        //Goes back to the Main Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormMain>().Show();
        }

        //If the input is valid, Add the customer and continue to the Order Form
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (validFirstName && validLastName && validPhone) {
                //Creates a customer
                string firstName = FirstNameTextBox.Text.Trim(),
                    lastName = LastNameTextBox.Text.Trim(),
                    phone =PhoneTextBox.Text.Trim();
                Customer customer = new Customer
                {
                    Phone = phone,
                    RewardPoints = 0,
                    FirstName = firstName,
                    LastName = lastName
                };

                //Adds to the dictionary
                _customerService.Customers.Add(customer);
                //Saves to JSON
                _customerService.Write();

                //Goes back to the Order Form
                
                Hide();
                FormFactory.Get<FormOrderDrink>().Show();
            }
        }
    }
}
