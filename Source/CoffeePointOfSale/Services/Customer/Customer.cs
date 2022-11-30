using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "000-000-000";
    public const string AnonymousFirstName = "Anonymous";
    public const string AnonymousLastName = "Anonymous";


    private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    private int _rewardPoints = 0;
    private string _firstName = "";
    private string _lastName = "";

    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual int RewardPoints

    {
        get => _rewardPoints;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPoints = value;
        }
    }
    public virtual string FirstName
    {
        get => _firstName;
        set
        {
            if (IsAnonymous) return; //you cannot set name for the anonymous customer record
            _firstName = value;
        }
    }
    public virtual string LastName
    {
        get => _lastName;
        set
        {
            if (IsAnonymous) return; //you cannot set name for the anonymous customer record
            _lastName = value;
        }
    }


    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public override string ToString()
    {
        return IsAnonymous  
            ? "Anonymous Customer - No Reward Points"
            : $"{Phone}, Reward Points: {RewardPoints}";
    }
}