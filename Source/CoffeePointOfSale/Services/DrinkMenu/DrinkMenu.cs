using Newtonsoft.Json;
using CoffeePointOfSale.Services.Drinks;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenu
{
    /// <summary>
    /// Private list containing all drinks.
    /// </summary>
    [JsonProperty("DrinkMenu")]
    private readonly List<Drink> _drinkList = new();

    /// <summary>
    /// Returns a readonly list of all drinks.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<Drink> List =>
        _drinkList;
}
