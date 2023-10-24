using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using Rest_NetApi.Domain.DTOs;

namespace Rest_NetApi.DBObjects.DBObjects
{
	public class AddressDB
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

     //   [Required]
       //[ForeignKey("Person")]
        public Guid PersonId { get; set; } // Required foreign key property

        
        public virtual PersonDB Person { get; set; } // Required reference navigation to principal

        public AddressDB()
		{
		}

        public AddressDB(Guid id, string country, string city, string municipality, string neighborhood, string street, Guid personId)
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