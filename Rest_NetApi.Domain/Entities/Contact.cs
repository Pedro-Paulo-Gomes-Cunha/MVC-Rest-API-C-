using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IEntity;
using System;
namespace Rest_NetApi.Domain.Entities
{
	public class Contact: IContact
    {

        public Guid Id { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email { get; set; }

        public Guid PersonId { get; set; } // Required foreign key property
        public Person Person { get; set; } = null!; // Required reference navigation to principal


        public Contact()
        {
        }

        public Contact(IContact contact) : this(contact.Id, contact.Phone1, contact.Phone2, contact.Email, contact.PersonId) { }

        public Contact(Guid id,string phone1, string phone2, string email, Guid personId)
        {
            Id = id;
            Phone1= phone1;
            Phone2= phone2;
            Email = email;
            PersonId = personId;

        }

        public ContactDto ToDto()
        {
            return new ContactDto(this.Id,this.Phone1,this.Phone2, this.Email, this.PersonId);
        }


       
	}
}

