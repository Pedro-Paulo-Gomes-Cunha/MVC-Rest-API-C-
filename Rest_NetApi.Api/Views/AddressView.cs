namespace Rest_NetApi.Api.Views
{
    public class AddressView
    {
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public Guid PersonId { get; set; } 

        public AddressView()
        {
        }

        public AddressView(Guid id, string country, string city, string municipality, string neighborhood, string street, Guid personId)
        {
            Id = id;
            Country = country;
            City = city;
            Municipality = municipality;
            Neighborhood = neighborhood;
            Street = street;
            PersonId = personId;
        }
    }
}
