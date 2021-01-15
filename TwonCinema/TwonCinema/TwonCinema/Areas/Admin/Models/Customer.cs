using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        [Required(ErrorMessage = "Email không được bỏ trống")] public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")] public string Password { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")] public string Phone { get; set; }
        public int Total_Spending { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }
        public ICollection<Booking> listBooking { get; set; }
    }
}
