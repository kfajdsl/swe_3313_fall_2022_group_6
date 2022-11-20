using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Customization
{
    public string Name { get; set; }
    public Decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name}, Price: {Price}";
    }
}
