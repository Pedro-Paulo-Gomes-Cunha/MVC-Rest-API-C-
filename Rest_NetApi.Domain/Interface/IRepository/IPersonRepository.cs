using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;

namespace Rest_NetApi.Domain.Interface.IRepository
{
    public interface IPersonRepository 
    {
        IEnumerable<PersonDto> FindAll();
        Guid Save(PersonDto obj);
        PersonDto FindById(Guid id);
        void UpdatePerson(PersonDto obj);
        void RemovePerson(Guid id);
    }
}

