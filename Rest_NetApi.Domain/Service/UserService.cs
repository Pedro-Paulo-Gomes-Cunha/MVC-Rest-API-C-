using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IRepository;
using Rest_NetApi.Domain.Interface.IService;

namespace Rest_NetApi.Domain.Service
{
	public class UserService : IUserService
	{
        IRepositoryWrapper _repositoryWrapper;
		public UserService(IRepositoryWrapper repositoryWrapper)
		{
            this._repositoryWrapper = repositoryWrapper;
		}

        public void Save(UserDto obj)
        {
            var userEntiy = obj.ToEntity();
            if (string.IsNullOrWhiteSpace(userEntiy.Email) || string.IsNullOrWhiteSpace(userEntiy.Password))
                return;

            _repositoryWrapper.UserRepository.Save(userEntiy.ToDto());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> FindAll()
        {
            return _repositoryWrapper.UserRepository.FindAll();
        }

        public UserDto FindById(Guid id)
        {
            return _repositoryWrapper.UserRepository.FindById(id);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserDto obj)
        {
            _repositoryWrapper.UserRepository.UpdateUser(obj);
        }

        public UserDto UserLogin(string email, string password)
        {
            return _repositoryWrapper.UserRepository.UserLogin(email, password);
        }
    }
}

