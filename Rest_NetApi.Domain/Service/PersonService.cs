using System;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IRepository;
using Rest_NetApi.Domain.Interface.IService;

namespace Rest_NetApi.Domain.Service
{
	public class PersonService : IPersonService
	{
        IRepositoryWrapper _repositoryWrapper;
		public PersonService(IRepositoryWrapper repositoryWrapper)
		{
            this._repositoryWrapper = repositoryWrapper;
		}

        public Guid Save(PersonDto obj)
        {
          /*  var userEntiy = obj.ToEntity();
            if (string.IsNullOrWhiteSpace(userEntiy.Email) || string.IsNullOrWhiteSpace(userEntiy.Senha))
                return;*/

           return _repositoryWrapper.PersonRepository.Save(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonDto> FindAll()
        {
            var AllPeople = _repositoryWrapper.PersonRepository.FindAll().ToList();

            for (int i = 0; i < AllPeople.Count(); i++)
            {
                AllPeople[i].Address = _repositoryWrapper.AddressRepository.FindByPersonId(AllPeople[i].Id);

                AllPeople[i].Contact = _repositoryWrapper.ContactRepository.FindByPersonId(AllPeople[i].Id);
            }

            return AllPeople.AsEnumerable();
        }


        public PersonDto FindById(Guid id)
        {
            return _repositoryWrapper.PersonRepository.FindById(id);
        }

        public void Remove(Guid id)
        {
            _repositoryWrapper.PersonRepository.RemovePerson(id);
        }

        public void Update(PersonDto obj)
        {
            _repositoryWrapper.PersonRepository.UpdatePerson(obj);
        }

    }
}

