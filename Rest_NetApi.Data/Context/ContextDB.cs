using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Rest_NetApi.DBObjects.DBObjects;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rest_NetApi.Data.Context
{
    public class ContextDB : DbContext
    {

        public ContextDB() : base()
        {

        }

        public ContextDB(DbContextOptions<DbContext> options):base(options)
        {
            
        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
         {
            var stringConexao = "Data Source=USER\\SQLEXPRESS;Database=Rest_NetApi;User=User1;Password=123456789;TrustServerCertificate=true;MultipleActiveResultSets=true";
            options.UseSqlServer(stringConexao);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<UserDB>().Property(e => e.Id).HasDefaultValueSql("NEWID()");


            base.OnModelCreating(modelBuilder);
            




            modelBuilder.Entity<AddressDB>()
                 .HasOne(e => e.Person)
                 .WithOne(e => e.Address)
                 .HasForeignKey<AddressDB>(e => e.PersonId);
            



        }


        public DbSet<UserDB> Users { get; set; }
        public DbSet<PersonDB> People { get; set; }
        public DbSet<AddressDB> Address { get; set; }
        public DbSet<ContactDB> Contacts { get; set; }




    }
}
