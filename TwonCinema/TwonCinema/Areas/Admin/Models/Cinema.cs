using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được bỏ trống")] public string Address { get; set; }
        [Required(ErrorMessage = "Số di động không được bỏ trống")] public string Hotline { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        [Required(ErrorMessage = "Quản lí không được bỏ trống")]  public int Manager_ID { get; set; }
        [ForeignKey("Manager_ID")]
       
        public virtual Staf Staf { get; set; }
        public ICollection<Room> listRoom { get; set; }
    }
}
