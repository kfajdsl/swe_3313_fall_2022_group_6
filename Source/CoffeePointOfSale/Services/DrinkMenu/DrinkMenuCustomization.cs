using CoffeePointOfSale.Services.Drinks;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenuCustomization
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; } = 0.0M;

    public Customization NewCustomization()
    {
        return new Customization { Name = Name, Price = Price };
    }
}
