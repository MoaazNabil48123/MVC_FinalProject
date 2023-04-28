using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.ViewModel;

public class LoginViewModel
{
    [Required]
    public string UserName { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    public bool RememberMe { get; set; }
    public string? ReturnUrl { get; set; }
    public string? previousUrl { get; set; }
    public IList<AuthenticationScheme>? ExternalLogins { get; set; }
	}
