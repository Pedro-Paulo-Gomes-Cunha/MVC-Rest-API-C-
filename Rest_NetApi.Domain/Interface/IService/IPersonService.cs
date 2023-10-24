using System;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IEntity;

namespace Rest_NetApi.Domain.Interface.IService
{
	public interface IPersonService// : IServiceBase<PersonDto>
	{
        Guid Save(PersonDto obj);
        PersonDto FindById(Guid id);
        IEnumerable<PersonDto> FindAll();
        void Update(PersonDto obj);
        void Remove(Guid id);
        void Dispose();
    }
}

