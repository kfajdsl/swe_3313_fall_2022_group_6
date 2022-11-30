using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System.Diagnostics;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private readonly ICsvExtractService _csvExtractService;
    private IAppSettings _appSettings;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService, ICsvExtractService csvExtractService) : base(appSettings)
    {
        _customerService = customerService;
        _csvExtractService = csvExtractService;
        _appSettings = appSettings;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    private void GenReportBtn_Click(object sender, EventArgs e)
    {
        var sales = _customerService.Customers.OrderList.Select(o => o.ToSaleDate());

        var outputDirectory = Path.GetTempPath(); //find OS temp directory
        var filename = $"sales_report_temp_{DateTime.Now.Ticks}.csv";
        var fullPath = Path.Join(outputDirectory, filename);

        _csvExtractService.WriteCsvFile(sales, fullPath);

        //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
        try
        {
            var processStartInfo = new ProcessStartInfo(fullPath)
            {
                WorkingDirectory = outputDirectory,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open [{fullPath}]: {ex.Message}");
        }
    }

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
    }
}