using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên tối thiểu 4 ký tự, tối đa 100 ký tự.")]
        [StringLength(100, MinimumLength = 4)]
        public string? Name { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail.com", ErrorMessage = "Email bắt buộc phải nhập và có đuôi gmail.")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+\.@(?!gmail).com")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có 8 ký tự trở lên")]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$",
            ErrorMessage = "Mật khẩu phải có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [DisplayName("Mật khẩu")]
        public string? Password { get; set; }

        [Required]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage = "Cần điền đầy đủ.")]
        public Gender? Gender { get; set; }
        
        [Required(ErrorMessage = "Cần điền đầy đủ.")]
        public bool IsRegular { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Cần Nhập đủ.")]
        public string? Address { get; set; }

        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        [DisplayName("Điểm")]
        public double? Mark { get; set; }

    }
}
