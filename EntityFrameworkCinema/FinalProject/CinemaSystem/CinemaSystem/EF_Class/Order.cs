namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrdersSnacks = new HashSet<OrdersSnack>();
            SeatsOrders = new HashSet<SeatsOrder>();
        }

        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        public int? ScheduleId { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderTotal { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? OrderDateTime { get; set; }

        public string TicketIdentifier { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersSnack> OrdersSnacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatsOrder> SeatsOrders { get; set; }
    }
}
