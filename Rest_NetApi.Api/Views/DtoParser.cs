using System;
using Rest_NetApi.Domain.DTOs;

namespace Rest_NetApi.Api.Views
{
	public class DtoParser
	{
		public DtoParser()
		{
		}

		public static AddressDto Parse(AddressView address)
		{
			return new AddressDto(address.Id, address.Country, address.City, address.Municipality, address.Neighborhood, address.Street, address.PersonId);
		}

        public static ContactDto Parse(ContactView contact)
        {
            return new ContactDto(contact.Id, contact.Phone1, contact.Phone2, contact.Email, contact.PersonId);
        }

        public static PersonDto Parse(PersonView person)
        {
            return new PersonDto(person.Id, person.FirstName, person.LastName, person.Birthday, person.Description, person.Nationality, person.Genero);
        }


    }
}

