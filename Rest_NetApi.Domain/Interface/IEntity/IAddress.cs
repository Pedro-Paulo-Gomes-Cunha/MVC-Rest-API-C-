using Rest_NetApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest_NetApi.Domain.Interface.IEntity
{
    public interface IAddress : IEntity
    {
        string Country { get; }
        string City { get; }
        string Municipality { get; }
        string Neighborhood { get; }
        string Street { get; }
        Person Person { get; }
    }
}