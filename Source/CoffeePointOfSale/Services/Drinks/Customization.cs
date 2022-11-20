using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Drinks;

public class Customization
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name}, Price: {Price}";
    }
}
