using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Sức chứa không được bỏ trống")] public int Capacity { get; set; }
        [Required(ErrorMessage = "Chiều dài không được bỏ trống")] public int Length { get; set; }
        [Required(ErrorMessage = "Chiều rộng không được bỏ trống")] public int Width { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        [Required(ErrorMessage = "Rạp Phim không được bỏ trống")] public int Cinema_ID { get; set; }
        [ForeignKey("Cinema_ID")]

        public virtual Cinema Cinema { get; set; }
        public ICollection<Equipment> listMaterials { get; set; }
    }
}
