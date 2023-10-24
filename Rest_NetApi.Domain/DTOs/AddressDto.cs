using System;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.Entities;

namespace Rest_NetApi.Domain.DTOs
{
	public class AddressDto
	{
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public Guid PersonId { get; set; } // Required foreign key property
       // public PersonDto Person { get; set; } = null!; // Required reference navigation to principal

        public AddressDto()
		{
		}

        public AddressDto(Guid id, string country, string city, string municipality, string neighborhood, string street, Guid personId)
        {
            Id = id;
            Country = country;
            City = city;
            Municipality = municipality;
            Neighborhood = neighborhood;
            Street = street;
            PersonId= personId;
        }

        public Address ToEntity()
        {
            return new Address(this.Id, this.Country, this.City, this.Municipality, this.Neighborhood, this.Street, this.PersonId);
        }
    }
}

