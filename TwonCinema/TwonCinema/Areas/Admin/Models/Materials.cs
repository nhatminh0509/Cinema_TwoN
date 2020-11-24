using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Materials
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Tọa độ hàng không được bỏ trống")] public int Row_ID { get; set; }
        [Required(ErrorMessage = "Tọa độ cột không được bỏ trống")] public int Col_ID { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        [Required(ErrorMessage = "Phòng không được bỏ trống")] public int Room_ID { get; set; }
        [ForeignKey("Room_ID")]
        public virtual Room Room { get; set; }
        [Required(ErrorMessage = "Cấp bậc ghế không được bỏ trống")] public int Seat_Level_ID { get; set; }
        [ForeignKey("Seat_Level_ID")]
        public virtual Category_Materials Seat_Level { get; set; }
    }
}
