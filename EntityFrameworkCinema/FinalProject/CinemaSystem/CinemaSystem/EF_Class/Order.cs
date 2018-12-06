namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Order", Namespace = "")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrdersSnacks = new HashSet<OrdersSnack>();
            SeatsOrders = new HashSet<SeatsOrder>();
        }
        [XmlElement("OrderId")]
        public int OrderId { get; set; }
        [XmlElement("CustomerId")]
        public int? CustomerId { get; set; }
        [XmlElement("ScheduleId")]
        public int? ScheduleId { get; set; }
        [XmlElement("OrderTotal")]
        [Column(TypeName = "money")]
        public decimal? OrderTotal { get; set; }
        [XmlElement("OrderDateTime")]
        [Column(TypeName = "datetime2")]
        public DateTime? OrderDateTime { get; set; }
        [XmlElement("TicketIdentifier")]
        public string TicketIdentifier { get; set; }
        [XmlIgnore]
        public virtual Customer Customer { get; set; }
        [XmlIgnore]
        public virtual Schedule Schedule { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersSnack> OrdersSnacks { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatsOrder> SeatsOrders { get; set; }
    }
}
