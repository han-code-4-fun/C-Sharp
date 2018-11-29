namespace CinemaSystem.EF_Class
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CinemaDBEntity : DbContext
    {
        public CinemaDBEntity()
            : base("name=CinemaDBEntity")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Movy> Movies { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersSnack> OrdersSnacks { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Snack> Snacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Hall>()
                .Property(e => e.HallName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Movy>()
                .Property(e => e.InitialPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrdersSnack>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrdersSnack>()
                .Property(e => e.OrderTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Schedule)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Snack>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Snack>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
