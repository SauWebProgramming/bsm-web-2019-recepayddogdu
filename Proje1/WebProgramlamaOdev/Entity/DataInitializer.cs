using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProgramlamaOdev.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler=new List<Category>()
            {
                new Category(){Name = "Kamera",Description = "Kamera Ürünleri"},
                new Category(){Name = "Bilgisayar",Description = "Bilgisayar Ürünleri"},
                new Category(){Name = "Elektronik",Description = "Elektronik Ürünleri"},
                new Category(){Name = "Telefon",Description = "Telefon Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description = "Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}