using System;
using Rest_NetApi.Data.Context;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IRepository;

namespace Rest_NetApi.Data.Repositories
{
	public class AddressRepository : BaseRepository<AddressDB>, IAddressRepository
    {

        protected ContextDB Db = new();
        public AddressRepository()
		{
		}

        public IEnumerable<AddressDto> FindAll()
        {
            var addresses = GetAll();

            return addresses.Select(TransformToDto);
        }

        public AddressDto FindById(Guid id)
        {
            var dbObject = GetById(id);

            if (dbObject == null) return null;

            return TransformToDto(dbObject);

        }

        public void RemoveAdress(Guid id)
        {
            var dbObject = GetById(id);

            if(dbObject!=null)
                 Remove(dbObject);
        }

        public void Save(AddressDto obj)
        {
            var dbObject = TransformToDBO(obj);

            dbObject.Id = Guid.NewGuid();

            Add(dbObject);
        }

        public AddressDto FindByPersonId(Guid id)
        {
            var resukt = Db.Address.FirstOrDefault(a => a.PersonId == id);

            if (resukt == null) return null;

            return TransformToDto(resukt);
        }

        public void UpdateAddress(AddressDto obj)
        {
            var dbObject = TransformToDBO(obj);

            Update(dbObject);
        }

        private AddressDto TransformToDto(AddressDB address)
        {
            return new AddressDto(address.Id, address.Country, address.City, address.Municipality, address.Neighborhood, address.Street, address.PersonId);
        }

        private AddressDB TransformToDBO(AddressDto address)
        {
            return new AddressDB(address.Id, address.Country, address.City, address.Municipality, address.Neighborhood, address.Street, address.PersonId);
        }

       
    }
}