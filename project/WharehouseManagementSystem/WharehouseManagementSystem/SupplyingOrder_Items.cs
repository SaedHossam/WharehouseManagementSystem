namespace WharehouseManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplyingOrder_Items
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_number { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_code { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime Production_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime expiration_date { get; set; }

        public virtual Item Item { get; set; }

        public virtual SupplyingOrder SupplyingOrder { get; set; }
    }
}
