using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Drinks;

public class Customization
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0.0M;

    public override string ToString()
    {
        return $"{Name}";
    }
}
