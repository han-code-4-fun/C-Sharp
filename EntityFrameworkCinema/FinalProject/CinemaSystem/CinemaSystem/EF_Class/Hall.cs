namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hall()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int HallId { get; set; }

        [Required]
        [StringLength(50)]
        public string HallName { get; set; }

<<<<<<< HEAD:EntityFrameworkCinema/FinalProject/CinemaSystem/CinemaSystem/EF_Class/Hall.cs
        public int NMaxRow { get; set; }

        public int NMaxColum { get; set; }
=======
        public int MaxRow { get; set; }

        public int MaxColume { get; set; }
>>>>>>> 614aecc384936d67d4c4d303036d219fdee8b36e:EntityFrameworkCinema/CinemaSystem/CinemaSystem/EF_Class/Hall.cs

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
