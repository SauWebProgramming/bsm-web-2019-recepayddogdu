using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProgramlamaOdev.Entity
{
    public enum EnumOrderState
    {

        [Display(Name = "Onay Bekleniyor")]
        OnayBekleniyor,
        [Display(Name = "Tamamlandı")]
        Tamamlandi
    }
}