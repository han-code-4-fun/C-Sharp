namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("OrdersSnack", Namespace = "")]

    public partial class OrdersSnack
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("OrderId")]
        public int OrderId { get; set; }
        [XmlElement("SnackId")]
        public int SnackId { get; set; }
        [XmlElement("Quantity")]
        public int Quantity { get; set; }
        [XmlElement("UnitPrice")]
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [XmlElement("OrderTotal")]
        [Column(TypeName = "money")]
        public decimal OrderTotal { get; set; }
        [XmlIgnore]
        public virtual Order Order { get; set; }
        [XmlIgnore]
        public virtual Snack Snack { get; set; }
    }
}
