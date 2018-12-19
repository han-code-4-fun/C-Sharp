namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Hall", Namespace = "")]
    public partial class Hall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hall()
        {
            Schedules = new HashSet<Schedule>();
        }
        [XmlElement("HallId")]
        public int HallId { get; set; }
        [XmlElement("HallName")]
        [Required]
        [StringLength(50)]
        public string HallName { get; set; }
        [XmlElement("NMaxRow")]
        public int NMaxRow { get; set; }
        [XmlElement("NMaxColum")]
        public int NMaxColum { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
