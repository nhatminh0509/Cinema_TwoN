using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Movie_Show
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Thời gian bắt đầu không được bỏ trống")] public DateTime Start_Show { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        public ICollection<Booking> listBooking { get; set; }
        [Required(ErrorMessage = "Phòng không được bỏ trống")] public int Room_ID { get; set; }
        [ForeignKey("Room_ID")]
        public virtual Room Room { get; set; }
        [Required(ErrorMessage = "Phim không được bỏ trống")] public int Movie_ID { get; set; }
        [ForeignKey("Movie_ID")]
        public virtual Movie Movie { get; set; }

    }
}
