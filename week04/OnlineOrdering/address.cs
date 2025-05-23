namespace OnlineOrderingSystem.Models;
public class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA() => Country.ToLower() == "usa";
    public override string ToString() => $"{Street}, {City}, {State}, {Country}";
}
