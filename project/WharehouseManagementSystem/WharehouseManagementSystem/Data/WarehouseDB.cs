using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WharehouseManagementSystem
{
    public partial class WarehouseDB : DbContext
    {
        public WarehouseDB()
            : base("name=WarehouseDB")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Inovice_Items> Inovice_Items { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Payment_Order> Payment_Order { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<SupplyingOrder> SupplyingOrders { get; set; }
        public virtual DbSet<SupplyingOrder_Items> SupplyingOrder_Items { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Transaction_Type> Transaction_Type { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<WarehouseItem> WarehouseItems { get; set; }
        public virtual DbSet<Wharehouse> Wharehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Payment_Order)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.customer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Wharehouses)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.employee_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Inovice_Items)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.SupplyingOrder_Items)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.item_code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.item_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.WarehouseItems)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.item_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Units)
                .WithMany(e => e.Items)
                .Map(m => m.ToTable("Item_Units"));

            modelBuilder.Entity<Payment_Order>()
                .HasMany(e => e.Inovice_Items)
                .WithRequired(e => e.Payment_Order)
                .HasForeignKey(e => e.order_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment_Order>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.Payment_Order)
                .HasForeignKey(e => e.paymentOrderId);

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.SupplyingOrders)
                .WithRequired(e => e.Provider)
                .HasForeignKey(e => e.supplier_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplyingOrder>()
                .HasMany(e => e.Inovice_Items)
                .WithRequired(e => e.SupplyingOrder)
                .HasForeignKey(e => e.supplyingOrder_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplyingOrder>()
                .HasMany(e => e.SupplyingOrder_Items)
                .WithRequired(e => e.SupplyingOrder)
                .HasForeignKey(e => e.order_number)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplyingOrder>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.SupplyingOrder)
                .HasForeignKey(e => e.order_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupplyingOrder>()
                .HasMany(e => e.WarehouseItems)
                .WithRequired(e => e.SupplyingOrder)
                .HasForeignKey(e => e.order_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Transaction1)
                .WithOptional(e => e.Transaction2)
                .HasForeignKey(e => e.move_from_transaction_id);

            modelBuilder.Entity<Transaction_Type>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Transaction_Type)
                .HasForeignKey(e => e.type_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wharehouse>()
                .HasMany(e => e.SupplyingOrders)
                .WithRequired(e => e.Wharehouse)
                .HasForeignKey(e => e.warehouse_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wharehouse>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Wharehouse)
                .HasForeignKey(e => e.wharehouse_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wharehouse>()
                .HasMany(e => e.WarehouseItems)
                .WithRequired(e => e.Wharehouse)
                .HasForeignKey(e => e.warehouse_id)
                .WillCascadeOnDelete(false);
        }
    }
}
