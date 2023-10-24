using System;
using Rest_NetApi.Domain.Interface.IRepository;

namespace Rest_NetApi.Data.Repositories
{
	public class RepositoryWrapper : IRepositoryWrapper
	{
		IAddressRepository _addressRepository;

        IUserRepository _userRepository;

        IContactRepository _contactRepository;

        IPersonRepository _personRepository;

      
        public RepositoryWrapper()
		{
		}

		public IAddressRepository AddressRepository
		{
			get
			{
				if(_addressRepository == null)
				{
					_addressRepository = new AddressRepository();
				}
				return _addressRepository;
			}
		}

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository();
                }
                return _userRepository;
            }
        }

        public IContactRepository ContactRepository
        {
            get
            {
                if (_contactRepository == null)
                {
                    _contactRepository = new ContactRepository();
                }
                return _contactRepository;
            }
        }

        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository();
                }
                return _personRepository;
            }
        }


       


    }
}

