
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ResetPassword
    {
        public string ResetPasswordGUID { get; set; }

        public int? EmployeeID { get; set; }

        [Required(ErrorMessage = "Enter New Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "New Password and Confirm Password do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class ChangePassword
    {
        [Required(ErrorMessage = "Enter Current Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter New Password")]
        [StringLength(50, ErrorMessage = "Password should be Min of 6 Characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword", ErrorMessage = "New Password and Confirm Password did not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }

        public int? EmployeeID { get; set; }

        public bool? LoggedInFlag { get; set; }
    }
}
