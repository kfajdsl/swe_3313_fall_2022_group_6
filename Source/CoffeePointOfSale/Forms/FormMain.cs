using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    ICustomerService _customerService;
    Pen backgroundpen = new Pen(Color.FromArgb(255, 150, 159, 170), 500);
    public FormMain(ICustomerService customerService, IAppSettings appSettings) : base(appSettings)
    {
        _customerService = customerService;
        InitializeComponent();
    }

    //Buttons: Onclick

    private void OnClickBtnOrderDrink(object sender, EventArgs e)
    {
        _customerService.CurrentCustomer = _customerService.Customers[Customer.AnonymousCustomerId];
        Hide();
        FormFactory.Get<FormOrderDrink>().Show();
    }


    private void OnClickBtnCustomerList(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormCustomerList>().Show();
    }

    private void OnClickBtnManagementTools(object sender, EventArgs e)
    {
        Hide();
        FormFactory.Get<FormManagement>().Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }


    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawRectangle(backgroundpen, 0, 0, 460, 464);
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
        PictureBox pb1 = new PictureBox();
        pb1.ImageLocation = "https://emojipedia-us.s3.amazonaws.com/source/skype/289/laptop_1f4bb.png";
        pb1.Height = 194;
        pb1.Width = 215;
        pb1.SizeMode = PictureBoxSizeMode.StretchImage;
        pb1.Location = new Point(1027, 304);
        this.Controls.Add(pb1);
        pb1.BringToFront();
        e.Graphics.DrawRectangle(backgroundpen, 0, 0, 460, 464);
    }
    private void panel3_Paint(object sender, PaintEventArgs e)
    {
        PictureBox pb1 = new PictureBox();
        pb1.ImageLocation = "https://www.pngkey.com/png/full/23-239812_download-ai-file-coffee-cup-emoji-png.png";
        pb1.Height = 194;
        pb1.Width = 215;
        pb1.SizeMode = PictureBoxSizeMode.StretchImage;
        pb1.Location = new Point(108, 304);
        this.Controls.Add(pb1);
        pb1.BringToFront();
        e.Graphics.DrawRectangle(backgroundpen, 0, 0, 460, 464);
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }
}