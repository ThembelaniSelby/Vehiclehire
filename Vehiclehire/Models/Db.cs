using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vehiclehire.Models
{
    public class Db : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Verify> Verifies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<PickPoint> PickPoints { get; set; }
        public DbSet<Refund> Refunds { get; set; }


        public DbSet<Booking> Bookings { get; set; }


        //public DbSet<Delivery> Deliveries { get; set; }
        //public DbSet<QrCode> QrCodes { get; set; }
        //public DbSet<Qcode> Qcodes { get; set; }
        //public DbSet<Scan> Scans { get; set; }
    }
}