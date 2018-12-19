namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Schedule", Namespace = "")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Orders = new HashSet<Order>();
        }
        [XmlElement("ScheduleId")]
        public int ScheduleId { get; set; }
        [XmlElement("HallId")]
        public int HallId { get; set; }
        [XmlElement("MovieId")]
        public int MovieId { get; set; }
        [XmlElement("StartTime")]
        public TimeSpan StartTime { get; set; }
        [XmlIgnore]
        public virtual Hall Hall { get; set; }
        [XmlIgnore]
        public virtual Movie Movie { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
