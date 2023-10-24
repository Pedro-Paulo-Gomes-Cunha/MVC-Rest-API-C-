using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rest_NetApi.Domain.Entities;

namespace Rest_NetApi.Domain.Interface.IEntity
{
    public interface IPerson : IEntity
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime Birthday { get; }
        string Nationality { get; }
        string Description { get; }
        string Genero { get; }
        Contact Contact { get; }
        Address Address { get; }
    }
}