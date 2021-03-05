namespace WharehouseManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Transaction1 = new HashSet<Transaction>();
        }

        public int id { get; set; }

        public int type_id { get; set; }

        public int order_id { get; set; }

        public int? move_from_transaction_id { get; set; }

        public int item_id { get; set; }

        public int quantity { get; set; }

        public int wharehouse_id { get; set; }

        public int total_quantity_for_product_in_wharehouse { get; set; }

        public int total_quantity_for_item_in_wharehouse { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int? paymentOrderId { get; set; }

        public virtual Item Item { get; set; }

        public virtual Payment_Order Payment_Order { get; set; }

        public virtual SupplyingOrder SupplyingOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transaction1 { get; set; }

        public virtual Transaction Transaction2 { get; set; }

        public virtual Transaction_Type Transaction_Type { get; set; }

        public virtual Wharehouse Wharehouse { get; set; }
    }
}
