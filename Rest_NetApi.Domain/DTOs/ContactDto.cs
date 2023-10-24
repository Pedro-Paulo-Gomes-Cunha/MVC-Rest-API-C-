using System;
using System.Runtime.CompilerServices;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.Entities;

namespace Rest_NetApi.Domain.DTOs
{
	public class ContactDto
	{
        public Guid Id { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email { get; set; }

        public Guid PersonId { get; set; } // Required foreign key property
       // public PersonDto Person { get; set; } = null!; // Required reference navigation to principal



        public ContactDto()
		{
		}

        public ContactDto(Guid id, string phone1, string phone2, string email, Guid personId)
        {
            Id = id;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
            PersonId = personId;

        }

        public Contact ToEntity()
        {
            return new Contact(this.Id, this.Phone1, this.Phone2, this.Email, this.PersonId);
        }


    }
}

