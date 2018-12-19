namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Serialization;

    [XmlRoot("Customer", Namespace = "")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        [XmlElement("CustomerId")]
        public int CustomerId { get; set; }
        [XmlElement("FirstName")]
        [Required]
        public string FirstName { get; set; }
        [XmlElement("LastName")]
        [Required]
        public string LastName { get; set; }
        [XmlElement("Email")]
        [Required]
        public string Email { get; set; }
        [XmlElement("Phone")]
        [Required]
        public string Phone { get; set; }
        [XmlIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
