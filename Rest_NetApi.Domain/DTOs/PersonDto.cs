using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.DTOs
{
    public class PersonDto
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public ContactDto? Contact { get; set; }

        public string Genero { get; set; }

        public AddressDto? Address { get; set; }




        public PersonDto()
        {
        }

        public PersonDto(Guid id, string firstname, string lastname, DateTime birthday, string desciption, string nacionality,string genero)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Description = desciption;
            Nationality = nacionality;
            Genero= genero;

        }
    
        public Person ToEntity()
        {
            return new Person(this.Id, this.FirstName, this.LastName, this.Birthday, this.Description, this.Nationality, this.Genero);
        }

    }
}
