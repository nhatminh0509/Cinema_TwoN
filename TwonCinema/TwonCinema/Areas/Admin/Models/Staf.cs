using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Staf
    {
        [Key] public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Email không được bỏ trống")] public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")] public string Password { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        public ICollection<Cinema> listCinema { get; set; }
    }
}
