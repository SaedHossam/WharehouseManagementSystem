namespace WharehouseManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplyingOrder")]
    public partial class SupplyingOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplyingOrder()
        {
            Inovice_Items = new HashSet<Inovice_Items>();
            SupplyingOrder_Items = new HashSet<SupplyingOrder_Items>();
            Transactions = new HashSet<Transaction>();
            WarehouseItems = new HashSet<WarehouseItem>();
        }

        [Key]
        public int number { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int supplier_id { get; set; }

        public int warehouse_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inovice_Items> Inovice_Items { get; set; }

        public virtual Provider Provider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyingOrder_Items> SupplyingOrder_Items { get; set; }

        public virtual Wharehouse Wharehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseItem> WarehouseItems { get; set; }
    }
}
