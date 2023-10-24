using System;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities.Enums;
using Rest_NetApi.Domain.Interface.IEntity;

namespace Rest_NetApi.Api.Views
{
	public class ViewParser
	{
		public ViewParser()
		{
		}

		public static AddressView Parse(AddressDto address)
		{
			return new AddressView(address.Id, address.Country, address.City, address.Municipality, address.Neighborhood, address.Street, address.PersonId);
		}
	
        public static UserView Parse(UserDto user)
        {
			return new UserView(user.Id, user.Email, user.Name, user.Password, user.IdPersom, user.IsKid, user.Photo);
        }

		
	
		public static ContactView Parse(ContactDto contact)
		{
			return new ContactView(contact.Id,contact.Phone1,contact.Phone2, contact.Email, contact.PersonId);
        }

		
		public static PersonView Parse(PersonDto person)
		{
			return new PersonView(person.Id, person.FirstName, person.LastName, person.Birthday, person.Description, person.Nationality, person.Genero);
		}
    }
}

