namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Snack", Namespace = "")]
    public partial class Snack
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Snack()
        {
            OrdersSnacks = new HashSet<OrdersSnack>();
        }
        [XmlElement("SnackId")]
        public int SnackId { get; set; }
        [XmlElement("Name")]
        [Required]
        public string Name { get; set; }
        [XmlElement("Price")]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersSnack> OrdersSnacks { get; set; }
    }
}
