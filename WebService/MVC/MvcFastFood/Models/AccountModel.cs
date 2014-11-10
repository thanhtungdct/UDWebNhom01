using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFastFood.Models
{
    public class AccountModel
    {

        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải có ít nhất {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu xác nhận")]
        [StringLength(100, ErrorMessage = "Mật khẩu phải có ít nhất {2}.", MinimumLength = 6)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không đúng.")]
        [DataType(DataType.Password)]
        public string ConfPassword { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression("(09[0-9]{8}|01[2-9]{1}[0-9]{8})", ErrorMessage = "Số điện thoại không đúng định dạng.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email không được để trống !")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email không đúng định dạng !")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}