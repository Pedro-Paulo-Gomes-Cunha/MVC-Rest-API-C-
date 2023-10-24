using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.Interface.IRepository
{
    public interface IContactRepository 
    {
        IEnumerable<ContactDto> FindAll();
        void Save(ContactDto obj);
        ContactDto FindById(Guid id);
        ContactDto FindByPersonId(Guid id);
        void UpdateContact(ContactDto obj);
        void RemoveContact(Guid id);

    }
}
