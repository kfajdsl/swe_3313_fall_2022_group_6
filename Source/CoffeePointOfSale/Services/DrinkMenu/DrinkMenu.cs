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
    /// Private list containing all customizations.
    /// </summary>
    [JsonProperty("Sizes")]
    private readonly List<DrinkMenuCustomization> _sizeList = new();

    /// <summary>
    /// Returns a readonly list of all drinks.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<DrinkMenuDrink> DrinkList => _drinkList;

    /// <summary>
    /// Returns a readonly list of all customizations (except sizes, which are mutually exclusive).
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<DrinkMenuCustomization> CustomizationList => _customizationList;

    /// <summary>
    /// Returns a readonly list of all sizes.
    /// </summary>
    [JsonIgnore] //not written to JSON file... this is a list view of the dictionary, so only the dictionary is written
    public IReadOnlyList<DrinkMenuCustomization> SizeList => _sizeList;
}
