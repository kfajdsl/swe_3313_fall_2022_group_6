using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenu
{
    /// <summary>
    /// Private list containing all drinks.
    /// </summary>
    [JsonProperty("Drinks")]
    private readonly List<DrinkMenuDrink> _drinkList = new();

    /// <summary>
    /// Private list containing all customizations.
    /// </summary>
    [JsonProperty("Customizations")]
    private readonly List<DrinkMenuCustomization> _customizationList = new();

    /// <summary>
    /// Returns a readonly list of all drinks.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<DrinkMenuDrink> DrinkList => _drinkList;

    /// <summary>
    /// Returns a readonly list of all customizations.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<DrinkMenuCustomization> CustomizationList => _customizationList;
}
