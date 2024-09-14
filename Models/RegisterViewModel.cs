using System.ComponentModel.DataAnnotations;
using BlogApp.Entity;

namespace BlogApp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "UserName")]
        public string? UserName { get; set; }
        [Required]
        [Display(Name = "Ad Soyad")]
        public string? Name { get; set; }



        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Parolanız eşleşmiyor.")]
        [Display(Name = "Parola Tekrar")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}