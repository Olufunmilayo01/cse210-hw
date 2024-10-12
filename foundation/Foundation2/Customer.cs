public class Customer
{
    private string _name;
    private Address _address;

    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check if the customer is in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Return the customer name and address for the shipping label
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
}