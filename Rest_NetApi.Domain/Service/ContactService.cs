using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IRepository;
using Rest_NetApi.Domain.Interface.IService;

namespace Rest_NetApi.Domain.Service
{
	public class ContactService : IContactService
	{
        IRepositoryWrapper _repositoryWrapper;
		public ContactService(IRepositoryWrapper repositoryWrapper)
		{
            this._repositoryWrapper = repositoryWrapper;
		}

        public void Save(ContactDto obj)
        {
            var dado = obj.ToEntity();

            _repositoryWrapper.ContactRepository.Save(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDto> FindAll()
        {
            return _repositoryWrapper.ContactRepository.FindAll();
        }

        public ContactDto FindById(Guid id)
        {
            return _repositoryWrapper.ContactRepository.FindById(id);
        }

        public void Remove(Guid id)
        {
            _repositoryWrapper.ContactRepository.RemoveContact(id);
        }

        public void Update(ContactDto obj)
        {
            _repositoryWrapper.ContactRepository.UpdateContact(obj);
        }

        public ContactDto FindByPersonId(Guid personId)
        {
           return _repositoryWrapper.ContactRepository.FindByPersonId(personId);
        }
    }
}

