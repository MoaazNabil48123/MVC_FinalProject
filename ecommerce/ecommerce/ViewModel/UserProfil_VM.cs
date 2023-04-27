using ecommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.ViewModel
{
    public class UserProfil_VM
    {
        [Required, Display(Name = "User Name"), MinLength(3), MaxLength(25)]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Address>? addresses { get; set; }
    }
}
