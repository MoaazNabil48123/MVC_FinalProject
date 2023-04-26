
using System.ComponentModel.DataAnnotations;

namespace ecommerce.ViewModel;

public class ChangePassword_VM
{
    [Required, Display(Name ="Old Password"), DataType(DataType.Password)]
    public string OldPassword { get; set; }
    [Required, Display(Name ="New Password"), DataType(DataType.Password)]
    public string NewPassword { get; set; }
    [Required, Display(Name ="Confirm Password"), DataType(DataType.Password), Compare(nameof(NewPassword),ErrorMessage ="Those Passwords don't match")]
    public string ConfirmPassword { get; set; }
}
