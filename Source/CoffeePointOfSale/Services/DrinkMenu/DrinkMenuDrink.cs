using CoffeePointOfSale.Services.Drinks;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenuDrink
{
    public string Name { get; set; } = "";
    public string BaseDescription { get; set; } = "";
    public string Image { get; set; } = "";
    public decimal BasePrice { get; set; } = 0.0M;

    public Drink NewDrink()
    {
        return new Drink { Name = Name, BasePrice = BasePrice };
    }
}

