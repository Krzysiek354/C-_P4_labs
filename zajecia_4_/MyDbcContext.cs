using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;//Pakiety SQL Server Entity 6 , Entity Framework, SqlClinet

namespace zajecia_4_
{
    internal class MyDbcContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PIV1b;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder) //fluent api jeśli tak to jeden sposob robic definioweanie wymagan dla atrybutow bazy albo tak albo w klasach np. Client
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Client>().Property("Id");
        //}
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
