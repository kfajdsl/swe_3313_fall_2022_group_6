using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Drink
{
    public string Name { get; set; }
    public string BaseDescription { get; set; }
    public string Image { get; set; }
    public Decimal BasePrice { get; set; }

    public List<Customization> Customizations { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, BaseDescription: {BaseDescription}, Image: {Image}, BasePrice: {BasePrice}";
    }
}
