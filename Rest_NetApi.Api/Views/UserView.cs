using System;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;

namespace Rest_NetApi.Api.Views
{
	public class UserView
	{
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public Guid IdPersom { get; set; }

        public bool IsKid { get; set; }

        public byte Photo { get; set; }

        public UserView()
        {
        }

        public UserView(Guid id, string email, string name, string password, Guid idPersom, bool isKid, byte photo)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            IdPersom = idPersom;
            IsKid = isKid;
            Photo = photo;
        }

        public UserDto ToDto()
        {
            return new UserDto(this.Id, this.Email, this.Name, this.Password, this.IdPersom, this.IsKid, this.Photo);
        }

    }
}

