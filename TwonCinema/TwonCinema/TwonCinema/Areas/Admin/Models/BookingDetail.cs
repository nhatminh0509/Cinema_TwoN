using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class BookingDetail
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Hóa đơn không được bỏ trống")] public int Booking_ID { get; set; }
        [ForeignKey("Booking_ID")]
        public virtual Booking Booking { get; set; }
        [Required(ErrorMessage = "Ghế không được bỏ trống")] public int Seat_ID { get; set; }
        [ForeignKey("Seat_ID")]
        public virtual Equipment Equipment { get; set; }
    }
}
