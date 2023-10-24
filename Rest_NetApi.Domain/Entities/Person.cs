using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.Entities
{
    public class Person:IPerson
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }

      //  public Guid ContactId { get; set; }
     //   public Guid AddressId { get; set; }

        public Contact? Contact { get; set; }
        public Address? Address { get; set; }

        public string Genero { get; set; }
        public Person()
        {
        }

        public Person(IPerson person) : this(person.Id, person.FirstName, person.LastName, person.Birthday, person.Nationality, person.Description,person.Genero) 
        {
            Contact=person.Contact; Address=person.Address;
        }

        public Person(Guid id, string firstname, string lastname, DateTime birthday, string desciption, string nacionality, string genero)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Description = desciption;
            Nationality = nacionality;
            Genero = genero;
        }

        public PersonDto ToDto()
        {
            return new PersonDto(this.Id, this.FirstName, this.LastName, this.Birthday, this.Description, this.Nationality,this.Genero);
        }
    }
}
