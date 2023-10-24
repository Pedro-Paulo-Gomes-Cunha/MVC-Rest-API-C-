using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_NetApi.DBObjects.DBObjects
{
	public class UserDB
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public Guid IdPersom { get; set; }

        public bool IsKid { get; set; }

        public byte Photo { get; set; }
        public UserDB()
		{
		}

        public UserDB(Guid id, string email, string name, string password, Guid idPersom, bool isKid, byte photo)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            IdPersom = idPersom;
            IsKid = isKid;
            Photo = photo;
        }
    }
}