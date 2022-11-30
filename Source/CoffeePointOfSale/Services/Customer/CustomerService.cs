using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Services.Customer;


/// <summary>
/// Service to load the customer database from JSON and to write changes to the customer database.
/// </summary>

public class CustomerService : ICustomerService
{
    private readonly IStorageService _storageService;
    public Customers Customers { get; init; }

    // MUST BE SET PROPERLY BEFORE USE
    public Customer CurrentCustomer { get; set; }

    // MUST BE SET PROPERLY BEFORE USE
    public Order CurrentOrder { get; set; } = new Order();

    public CustomerService(IStorageService storageService)
    {
        _storageService = storageService;
        Customers = _storageService.Read<Customers>(); //load customers from JSON file

        CreateAnonymousCustomer();
        CurrentCustomer = Customers[Customer.AnonymousCustomerId]; // decent default
    }

    private void CreateAnonymousCustomer()
    {
        if (Customers[Customer.AnonymousCustomerId] != null) return; //exists
        Customers.Add(new Customer() { Phone = Customer.AnonymousCustomerId, FirstName = "anonymous", LastName = "anonymous" });
        Write();
    }

    public void Write() => _storageService.Write(Customers);
}