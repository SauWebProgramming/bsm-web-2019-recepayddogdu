using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProgramlamaOdev.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("E-Mail Adresiniz")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Mail Adresi.")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Parola")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required]
        [DisplayName("Parola Tekrar")]
        [DataType(DataType.Password)]

        [Compare("Password",ErrorMessage = "Parolalarınız Uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}