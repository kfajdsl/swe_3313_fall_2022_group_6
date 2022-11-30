using Newtonsoft.Json;
using System.Text;

namespace CoffeePointOfSale.Services.Drinks;

public class Drink
{
    public string Name { get; set; } = "";
    public decimal BasePrice { get; set; } = 0.0M;
    public List<Customization> Customizations { get; set; } = new List<Customization>();

    public override string ToString()
    {
        decimal totalPrice = BasePrice;
        StringBuilder customizationsBuilder = new();

        foreach (var customization in Customizations)
        {
            totalPrice += customization.Price;
            customizationsBuilder.AppendFormat("{0},", customization.ToString());
        }
        customizationsBuilder.Length--; // remove the comma after the last item

        return $"${totalPrice.ToString("F")} {Name} {customizationsBuilder.ToString()}";
    }
    public decimal getTotal()
    {
        decimal totalPrice = BasePrice;
        foreach (var customization in Customizations)
        {
            totalPrice += customization.Price;
        }
        return totalPrice;
    }
}
