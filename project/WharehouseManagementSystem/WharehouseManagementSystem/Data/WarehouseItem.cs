namespace WharehouseManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WarehouseItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int warehouse_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_id { get; set; }

        public int quantity { get; set; }

        public virtual Item Item { get; set; }

        public virtual SupplyingOrder SupplyingOrder { get; set; }

        public virtual Wharehouse Wharehouse { get; set; }
    }
}
