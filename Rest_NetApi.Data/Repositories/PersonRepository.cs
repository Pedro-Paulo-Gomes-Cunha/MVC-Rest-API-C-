using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IRepository;

namespace Rest_NetApi.Data.Repositories
{
	public class PersonRepository : BaseRepository<PersonDB>, IPersonRepository
    {
		public PersonRepository()
		{
		}

        public IEnumerable<PersonDto> FindAll()
        {
            var persones = GetAll();

            return persones.Select(TransformToDto);
        }

        public PersonDto FindById(Guid id)
        {
            var dbObject = GetById(id);

            if (dbObject == null) return null;

            return TransformToDto(dbObject);
        }

        public void RemovePerson(Guid id)
        {
            var dbObject = GetById(id);

            if (dbObject != null)
                Remove(dbObject);
        }

        public Guid Save(PersonDto obj)
        {
            var dbObject = TransformToDBO(obj);

            dbObject.Id = Guid.NewGuid();

            Add(dbObject);

            return dbObject.Id;
        }

       public void UpdatePerson(PersonDto obj)
        {
            throw new NotImplementedException();
        }

        private PersonDto TransformToDto(PersonDB person)
        {
            return new PersonDto(person.Id, person.FirstName, person.LastName, person.Birthday, person.Description, person.Nationality, person.Genero);
        }


        private PersonDB TransformToDBO(PersonDto person)
        {
            return new PersonDB(person.Id, person.FirstName, person.LastName, person.Birthday, person.Description, person.Nationality, person.Genero);
        }

    }
}