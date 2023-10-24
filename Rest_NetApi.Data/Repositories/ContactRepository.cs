using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_NetApi.Data.Repositories
{
    public class ContactRepository : BaseRepository<ContactDB>, IContactRepository
    {
      //  RepositoryWrapper repository
        public IEnumerable<ContactDto> FindAll()
        {
            var useres = GetAll();

            return useres.Select(TransformToDto);
        }

        public ContactDto FindById(Guid id)
        {
            var dbObject = GetById(id);

            if (dbObject == null) return null;

            return TransformToDto(dbObject);
        }

        public void RemoveContact(Guid id)
        {
            var dbObject = GetById(id);

            if (dbObject != null)
                Remove(dbObject);
        }

        public void Save(ContactDto obj)
        {   
            var dbObject = TransformToDBO(obj);

            dbObject.Id = Guid.NewGuid();

            Add(dbObject);
        }

        public void UpdateContact(ContactDto obj)
        {
            var dbObject = TransformToDBO(obj);

            Update(dbObject);
        }

        public ContactDto FindByPersonId(Guid id)
        {
            var result = Db.Contacts.FirstOrDefault(a => a.PersonId == id);

            if (result == null) return null;

            return TransformToDto(result);
        }

        private ContactDto TransformToDto(ContactDB contact)
        {
            return new ContactDto(contact.Id, contact.Phone1, contact.Phone2, contact.Email, contact.PersonId);
        }

        private ContactDB TransformToDBO(ContactDto contatact)
        {
            return new ContactDB(contatact.Id, contatact.Phone1, contatact.Phone2, contatact.Email, contatact.PersonId);
        }

       
    }
}
