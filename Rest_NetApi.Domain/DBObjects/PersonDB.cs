using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_NetApi.DBObjects.DBObjects
{
	public class PersonDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public string Genero { get; set; }

        public ContactDB Contact { get; set; }

        public virtual AddressDB Address { get; set; }


        public PersonDB()
        {
        }

        public PersonDB(Guid id, string firstname, string lastname, DateTime birthday, string desciption, string nacionality, string genero)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Description = desciption;
            Nationality = nacionality;
            Genero = genero;
        }
    }
}