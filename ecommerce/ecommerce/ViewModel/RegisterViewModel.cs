using System.ComponentModel.DataAnnotations;

namespace ecommerce.ViewModel
{
    public class RegisterViewModel
    {
        [Display(Name = "Name")]
        [MinLength(3)]
        [MaxLength(25)]
        public string UserName { get; set; }



        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
       

        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }



        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
       
        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]

        public string PhoneNumber { get; set; }    
    }
}
