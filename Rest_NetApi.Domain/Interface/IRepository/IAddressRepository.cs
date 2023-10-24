using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;

namespace Rest_NetApi.Domain.Interface.IRepository
{
    public interface IAddressRepository 
    {
        IEnumerable<AddressDto> FindAll();
        void Save(AddressDto obj);
        AddressDto FindById(Guid id);
        AddressDto FindByPersonId(Guid idUser);
        void UpdateAddress(AddressDto obj);
        void RemoveAdress(Guid id);
    }
}

