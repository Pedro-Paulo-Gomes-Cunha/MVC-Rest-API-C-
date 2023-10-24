using Rest_NetApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.Interface.IEntity
{
    public interface IContact : IEntity
    {
        string Phone1 { get; }
        string Phone2 { get; }
        string Email { get; }
        Guid PersonId { get; }
    }
}