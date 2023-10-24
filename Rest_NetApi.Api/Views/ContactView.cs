using System;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IEntity;

namespace Rest_NetApi.Api.Views
{
    public class ContactView
    {
        public Guid Id { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Email { get; set; }

        public Guid PersonId { get; set; }



        /// <summary>
        ///   public PersonDto Person { get; set; } = null!; // Required reference navigation to principal
        /// </summary>


        public ContactView()
        {
        }

        public ContactView(Guid id, string phone1, string phone2, string email, Guid personId)
        {
            Id = id;
            Phone1 = phone1;
            Phone2 = phone2;
            Email = email;
            PersonId = personId;


        }
    }
}

