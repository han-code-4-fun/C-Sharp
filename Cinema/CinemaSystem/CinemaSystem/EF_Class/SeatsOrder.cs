namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("SeatsOrder", Namespace = "")]
    public partial class SeatsOrder
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Row")]
        public int? Row { get; set; }
        [XmlElement("Column")]
        public int? Column { get; set; }
        [XmlElement("OrderId")]
        public int? OrderId { get; set; }
        [XmlIgnore]
        public virtual Order Order { get; set; }
    }
}
