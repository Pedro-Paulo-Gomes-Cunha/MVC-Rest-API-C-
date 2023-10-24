using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Interface.IEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.Entities
{
    public class User: IUser
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public Guid IdPersom { get; set; }

        public bool IsKid { get; set; }

        public byte Photo { get; set; }


        public User()
        {
        }

        public User(IUser user) : this(user.Id, user.Email, user.Name, user.Password, user.IdPersom, user.IsKid, user.Photo) { }

        public User(Guid id, string email, string name, string password, Guid persomId, bool isKid, byte photo)
        {
            Id = id;
            Email = email;
            Password = password;
            Name= name;
            IdPersom = persomId;
            IsKid = isKid;
            Photo = photo;
        }

        public UserDto ToDto()
        {
            return new UserDto(this.Id, this.Email, this.Name, this.Password, this.IdPersom, this.IsKid, this.Photo);
        }

    }
}
