namespace CoffeePointOfSale.Services.Customer;

public class SaleData
{
    public string CustomerId { get; set; } = "";
    public DateTime TransactionDateTime { get; set; } = DateTime.MinValue;
    public decimal SubTotal { get; set; } = 0.0M;
    public decimal Tax { get; set; } = 0.0M;
    public decimal Total { get; set; } = 0.0M;
    public string Payment { get; set; } = "";
    public int RewardsPointsRedeemed { get; set; } = 0;
    public string OrderDescription { get; set; } = "";
}
