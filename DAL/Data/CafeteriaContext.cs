using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Model;



namespace DAL.Data
{
   public class CafeteriaContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<OrderProcuct> OrderProcucts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RDK65PV;Initial Catalog=CafeteriaContext;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProcuct>()
                .HasKey(op => new { op.Order_Id, op.Product_Id });
            modelBuilder.Entity<OrderProcuct>()
                .HasOne(op => op.Orders)
                .WithMany(o => o.orderProcuct)
                .HasForeignKey(op => op.Order_Id);
            modelBuilder.Entity<OrderProcuct>()
                .HasOne(op => op.Products)
                .WithMany(p => p.OrderProcucts)
                .HasForeignKey(op => op.Product_Id);
            modelBuilder.Entity<Store>() 
                .HasKey(s=> new { s.Product_Id , s.Expired_date });





        }
        
    }
}
