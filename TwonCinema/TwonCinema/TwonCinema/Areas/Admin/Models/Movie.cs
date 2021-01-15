using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwonCinema.Areas.Admin.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được bỏ trống")] public string Name { get; set; }
        public string Image_1 { get; set; }
        public string Image_2 { get; set; }
        public string Trailer { get; set; }
        [Required(ErrorMessage = "Đạo diễn không được bỏ trống")] public string Directors { get; set; }
        public string Cast { get; set; }
        public string Genre { get; set; }
        [Required(ErrorMessage = "Ngày khởi chiếu không được bỏ trống")] public DateTime Release_Date { get; set; }
        [Required(ErrorMessage = "Thời lượng không được bỏ trống")] public int Running_Time { get; set; }
        public string Language { get; set; }
        public string Rated { get; set; }
        public string Desc { get; set; }
        public string Keyword { get; set; }
        public string Slug { get; set; }
        [Required(ErrorMessage = "Trạng thái không được bỏ trống")] public int Status { get; set; }

    }
}
