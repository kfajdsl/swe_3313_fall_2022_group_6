namespace CoffeePointOfSale.Services.Customer;

public interface ICustomerService
{
    Customers Customers { get; init; }

    // MUST BE SET PROPERLY BEFORE USE
    Customer CurrentCustomer { get; set; }

    // MUST BE SET PROPERLY BEFORE USE
    Order CurrentOrder { get; set; }

    void Write();
}