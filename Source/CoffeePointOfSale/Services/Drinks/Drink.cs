using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Drinks;

public class Drink
{
    public string Name { get; set; }
    public string BaseDescription { get; set; }
    public string Image { get; set; }
    public decimal BasePrice { get; set; }

    public List<Customization> Customizations { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, BaseDescription: {BaseDescription}, Image: {Image}, BasePrice: {BasePrice}";
    }
}
