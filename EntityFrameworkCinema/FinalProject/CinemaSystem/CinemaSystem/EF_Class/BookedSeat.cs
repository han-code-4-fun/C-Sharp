namespace CinemaSystem.EF_Class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookedSeat
    {
        public int Id { get; set; }

        public int OrderID { get; set; }

        public int SeatRow { get; set; }

        public int SeatColumn { get; set; }

        public virtual Order Order { get; set; }
    }
}
