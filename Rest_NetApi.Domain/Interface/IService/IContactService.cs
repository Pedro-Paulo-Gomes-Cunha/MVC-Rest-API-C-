using System;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;

namespace Rest_NetApi.Domain.Interface.IService
{
	public interface IContactService : IServiceBase<ContactDto>
	{
        ContactDto FindByPersonId(Guid personId);
    }
}

