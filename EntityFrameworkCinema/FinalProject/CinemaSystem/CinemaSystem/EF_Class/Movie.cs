namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Movie", Namespace = "")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            Schedules = new HashSet<Schedule>();
        }
        [XmlElement("MovieId")]
        [Key]
        public int MovieId { get; set; }
        [XmlElement("Name")]
        [Required]
        public string Name { get; set; }
        [XmlElement("Description")]
        [Required]
        public string Description { get; set; }
        [XmlElement("Director")]
        [Required]
        public string Director { get; set; }
        [XmlElement("Duration_Minutes")]
        public int Duration_Minutes { get; set; }
        [XmlElement("InitialPrice")]
        [Column(TypeName = "money")]
        public decimal InitialPrice { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
