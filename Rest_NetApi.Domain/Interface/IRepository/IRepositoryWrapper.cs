using System;
namespace Rest_NetApi.Domain.Interface.IRepository
{
	public interface IRepositoryWrapper
	{
		IAddressRepository AddressRepository { get; }
        IUserRepository UserRepository { get; }
        IContactRepository ContactRepository { get; }
        IPersonRepository PersonRepository { get; }
      
    }
}

