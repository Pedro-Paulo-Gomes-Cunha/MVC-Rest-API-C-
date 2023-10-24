using Rest_NetApi.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_NetApi.DBObjects.DBObjects
{
	public class ContactDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email { get; set; }

        public Guid PersonId { get; set; } // Required foreign key property
        public PersonDB Person { get; set; } = null!; // Required reference navigation to principal

        public ContactDB()
		{
		}

        public ContactDB(Guid id, string phone1, string phone2, string email,Guid personId)
        {
            Id = id;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
            PersonId = personId;

        }
    }
}