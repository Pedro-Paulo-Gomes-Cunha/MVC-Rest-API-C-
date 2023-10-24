using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Rest_NetApi.Data.Repositories;
using Rest_NetApi.Domain.Interface.IRepository;
using Rest_NetApi.Domain.Interface.IService;
using Rest_NetApi.Domain.Service;

namespace Rest_NetApi.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
          /*  builder.RegisterGeneric(typeof(ServiceBase<>))
               .As(typeof(IServiceBase<>))
               .InstancePerLifetimeScope();*/

            builder.RegisterGeneric(typeof(BaseRepository<>))
               .As(typeof(IRepositoryBase<>))
               .InstancePerLifetimeScope();


            builder.RegisterType<RepositoryWrapper>().As<IRepositoryWrapper>();

            //User
            builder.RegisterType<UserService> ().As<IUserService>();
            builder.RegisterType<UserRepository> ().As<IUserRepository>();

            //Person
            builder.RegisterType<PersonService>().As<IPersonService>();
            builder.RegisterType<PersonRepository>().As<IPersonRepository>();

            //Contact
            builder.RegisterType<ContactService>().As<IContactService>();
            builder.RegisterType<ContactRepository>().As<IContactRepository>();

            //Adrress
            builder.RegisterType<AddressService>().As<IAddressService>();
            builder.RegisterType<AddressRepository>().As<IAddressRepository>();


            #endregion IOC


        }

    }
}
