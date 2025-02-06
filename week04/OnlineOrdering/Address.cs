public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _zipCode;

    private string _country;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _province = "";
        _country = "USA";
    }

    public Address(string street, string city, string province, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _zipCode = zipCode;
        _country = country;
        _state = "";
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        if (_country == "USA")
        {
            return $"{_street}\n{_city}, {_state} {_zipCode}";
        }
        else
        {
            return $"{_street}\n{_city}, {_province} {_zipCode}\n{_country}";
        }
    }
}