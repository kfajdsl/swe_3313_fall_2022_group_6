using CoffeePointOfSale.Services.Drinks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CoffeePointOfSale.Services.Customer;

public enum OrderPaymentMethod
{
    Unpaid, // should only be used while filling in order
    Credit,
    Rewards
}

public class Order
{
    public string OrderID { get; } = Guid.NewGuid().ToString();

    public string CustomerID { get; set; } = ""; // phone number

    public DateTime OrderDateTime { get; set; } = DateTime.Now;

    public decimal Total { get; set; } = 0.0M;

    public decimal Tax { get; set; } = 0.0M;

    public decimal SubTotal { get; set; } = 0.0M;

    public decimal PointsEarned { get; set; } = 0.0M;

    [JsonConverter(typeof(StringEnumConverter))]
    public OrderPaymentMethod PaymentMethod { get; set; } = OrderPaymentMethod.Unpaid;

    [JsonIgnore]
    public string CreditCardLast4Digits = ""; // HACK for passing betweeen payment screen and receipt screen

    public List<Drink> Drinks { get; set; } = new List<Drink>();
}

