using System;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IRepository;
using Rest_NetApi.Domain.Interface.IService;

namespace Rest_NetApi.Domain.Service
{
	public class AddressService : IAddressService
	{
        IRepositoryWrapper _repositoryWrapper;
		public AddressService(IRepositoryWrapper repositoryWrapper)
		{
            this._repositoryWrapper = repositoryWrapper;
		}

        public void Save(AddressDto obj)
        {
            var dado = obj.ToEntity();

            _repositoryWrapper.AddressRepository.Save(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressDto> FindAll()
        {
            return _repositoryWrapper.AddressRepository.FindAll();
        }

        public AddressDto FindById(Guid id)
        {
           return _repositoryWrapper.AddressRepository.FindById(id);
        }

        public void Remove(Guid id)
        {
            _repositoryWrapper.AddressRepository.RemoveAdress(id);
        }

        public void Update(AddressDto obj)
        {
            _repositoryWrapper.AddressRepository.UpdateAddress(obj);
        }

        public AddressDto FindByPersonId(Guid personId)
        {
           return _repositoryWrapper.AddressRepository.FindByPersonId(personId);
        }
    }
}

