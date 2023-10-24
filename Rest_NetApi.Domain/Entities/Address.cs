using System;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IEntity;

namespace Rest_NetApi.Domain.Entities
{
	public class Address : IAddress
	{
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public Guid PersonId { get; set; } // Required foreign key property
        public Person Person { get; set; } = null!; // Required reference navigation to principal

        public Address()
		{
		}

        public Address(IAddress address): this(address.Id, address.Country, address.City, address.Municipality, address.Neighborhood, address.Street, address.Person.Id) { }

        public Address(Guid id, string country, string city, string municipality, string neighborhood, string street, Guid personId)
        {
            Id = id;
            Country = country;
            City = city;
            Municipality = municipality;
            Neighborhood = neighborhood;
            Street = street;
            PersonId= personId;
        }

        public AddressDto ToDto()
        {
            return new AddressDto(this.Id, this.Country, this.City, this.Municipality, this.Neighborhood, this.Street, this.PersonId);
        }
    }
}

