public class Customer
{
    private string name;
    private Address address;

    public string Name { get => name; set => name = value; }
    public Address Address { get => address; set => address = value; }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}