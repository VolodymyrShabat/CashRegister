using Microsoft.EntityFrameworkCore;
using System;
namespace CashRegister
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ProductType { get; set; }
        public string ProductSubType { get; set; }

        public override string ToString()
        {
            return this.Id + " "+ ProductName + " " +  Price + " " + Quantity + " " + ProductType + " " + ProductSubType +"\n" ;
        }
    }

    class StatisticForDay
    {
        public DateTime Tiem { get; set; }
        public int ProductId { get; set; }
        public float Sold { get; set; }
    }

    class AppContext:DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=MyDB; Trusted_Connection=True");
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
