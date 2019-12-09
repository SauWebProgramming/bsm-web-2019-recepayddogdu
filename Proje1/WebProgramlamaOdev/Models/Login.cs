using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProgramlamaOdev.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Parola")]
        public string Password { get; set; }

        
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}