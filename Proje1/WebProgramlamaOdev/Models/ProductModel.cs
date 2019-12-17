using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebProgramlamaOdev.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Fiyat")]
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
       
        public int CategoryId { get; set; }

    }
}