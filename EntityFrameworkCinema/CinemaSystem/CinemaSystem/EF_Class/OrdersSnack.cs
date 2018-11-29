namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrdersSnack
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int SnackId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal OrderTotal { get; set; }

        public virtual Order Order { get; set; }

        public virtual Snack Snack { get; set; }
    }
}
