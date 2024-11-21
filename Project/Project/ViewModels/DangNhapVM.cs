using System.ComponentModel.DataAnnotations;

namespace Project.ViewModels
{
    public class DangNhapVM
    {
        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage="Chưa nhập Tài khoản")]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        [MinLength(6, ErrorMessage = "Tối thiểu 6 kí tự")]
        public  string MaTaiKhoan {  get; set; }

        [Display(Name = "Mật Khẩu")]
        [Required(ErrorMessage = "Chưa nhập Mật khẩu")]
        [DataType (DataType.Password)]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        [MinLength(6, ErrorMessage = "Tối thiểu 6 kí tự")]
        public string MatKhau {  get; set; }
    }
}
