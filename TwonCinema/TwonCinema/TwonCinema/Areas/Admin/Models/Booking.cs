using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Booking
    {
        [Key]
        public int ID { get; set; }
        public int Total_Price { get; set; }
        public ICollection<BookingDetail> listBookingDetail { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        [Required(ErrorMessage = "Xuất chiếu không được bỏ trống")] public int Show_ID { get; set; }
        [ForeignKey("Show_ID")]
        public virtual Movie_Show Movie_Show { get; set; }
        [Required(ErrorMessage = "Xuất chiếu không được bỏ trống")] public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }

    }
}
