namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Orders = new HashSet<Order>();
        }

        public int ScheduleId { get; set; }

        public int HallId { get; set; }

        public int MovieId { get; set; }

        public TimeSpan StartTime { get; set; }

        public bool A1 { get; set; }

        public bool A2 { get; set; }

        public bool A3 { get; set; }

        public bool A4 { get; set; }

        public bool B1 { get; set; }

        public bool B2 { get; set; }

        public bool B3 { get; set; }

        public bool B4 { get; set; }

        public bool C1 { get; set; }

        public bool C2 { get; set; }

        public bool C3 { get; set; }

        public bool C4 { get; set; }

        public bool D1 { get; set; }

        public bool D2 { get; set; }

        public bool D3 { get; set; }

        public bool D4 { get; set; }

        public bool E1 { get; set; }

        public bool E2 { get; set; }

        public bool E3 { get; set; }

        public bool E4 { get; set; }

        public virtual Hall Hall { get; set; }

        public virtual Movy Movy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
