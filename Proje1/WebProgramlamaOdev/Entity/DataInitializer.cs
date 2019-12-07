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

            var urunler=new List<Product>()
            {
                new Product(){Name = "Canon Eos 1200D Yüksek Kaliteli Fotoğraf Makinesi",Description ="Canon eos 1200d Fotoğraf Makinesi. Kullanması çok keyiflidir.", Price=1200,Stock=100,IsApproved=true,CategoryId=1,IsHome=true, Image = "1.jpg"},
                new Product(){Name = "Canon 4000D 18-55 MM III ",Description ="Canon 4000D 18-55 MM III Fotoğraf Makinesi Kullanması çok keyiflidir.", Price=600,Stock=300,IsApproved=true,CategoryId=1,IsHome=true, Image = "2.jpg"},
                new Product(){Name = "Fujifilm X100F Aynasız Fotoğraf Makinesi Kullanması çok keyiflidir.",Description ="SIFIR", Price=800,Stock=100,IsApproved=false,CategoryId=1,IsHome=true, Image = "3.jpg"},
                new Product(){Name = "Canon Eos 600D",Description ="SIFIR, Kullanması çok keyiflidir.", Price=800,Stock=50,IsApproved=true,CategoryId=1,IsHome=true, Image = "4.jpg"},
                new Product(){Name = "Nikon D3200",Description ="SIFIR, Kullanması çok keyiflidir.", Price=1200,Stock=500,IsApproved=false,CategoryId=1, Image = "5.jpg"},

                new Product(){Name = "MSI GS65 STEALTH",Description ="NVIDIA GeForce RTX, laptopta nihai oyun deneyimini yaşamanızı sağlayacak. Bu şık ve güçlü oyun sistemleri, yeni NVIDIA Turing GPU mimarisi ve devrim yaratan RTX platformu ile donatıldı.", Price=6000,Stock=100,IsApproved=true,CategoryId=2,IsHome=true, Image = "1.jpg"},
                new Product(){Name = "ASUS GS65 STEALTH",Description ="NVIDIA GeForce RTX, laptopta nihai oyun deneyimini yaşamanızı sağlayacak.", Price=5000,Stock=560,IsApproved=true,CategoryId=2,IsHome=true, Image = "2.jpg"},
                new Product(){Name = "DELL GS65 STEALTH",Description ="NVIDIA GeForce RTX, laptopta nihai oyun deneyimini yaşamanızı sağlayacak.", Price=4000,Stock=0,IsApproved=false,CategoryId=2, Image = "3.jpg"},
                new Product(){Name = "CASPER GS65 STEALTH",Description ="NVIDIA GeForce RTX, laptopta nihai oyun deneyimini yaşamanızı sağlayacak.", Price=3200,Stock=100,IsApproved=true,CategoryId=2, Image = "4.jpg"},
                    
                new Product(){Name = "GRUNDIG 32VLE5730 32 80 CM FHD LED TV,DAHİLİ UYDU ALICI ",Description ="32 80 CM FHD LED TV,DAHİLİ UYDU ALICI", Price=1200,Stock=100,IsApproved=true,CategoryId=3, Image = "1.jpg"},
                new Product(){Name = "VESTEL 32VLE5730",Description ="32 80 CM FHD LED TV,DAHİLİ UYDU ALICI", Price=1200,Stock=100,IsApproved=true,CategoryId=3,IsHome=true, Image = "2.jpg"},
                new Product(){Name = "SAMSUNG 32VLE5730D",Description ="32 80 CM FHD LED TV,DAHİLİ UYDU ALICI", Price=1200,Stock=100,IsApproved=true,CategoryId=3,IsHome=true, Image = "3.jpg"},
                new Product(){Name = "LG 32VLE5730",Description ="32 80 CM FHD LED TV,DAHİLİ UYDU ALICI", Price=1200,Stock=100,IsApproved=true,CategoryId=3, Image = "4.jpg"},

                new Product(){Name = "HUAWEI P30 PRO",Description ="128 GB AKILLI TELEFON ŞAFAK MAVİSİ", Price=1200,Stock=100,IsApproved=true,CategoryId=4,IsHome=true, Image = "1.jpg"},
                new Product(){Name = "LG P30 PRO",Description ="128 GB AKILLI TELEFON ŞAFAK MAVİSİ", Price=1200,Stock=100,IsApproved=true,CategoryId=4,IsHome=true, Image = "2.jpg"},
                new Product(){Name = "SAMSUNG P30 PRO",Description ="128 GB AKILLI TELEFON ŞAFAK MAVİSİ", Price=1200,Stock=100,IsApproved=false,CategoryId=4, Image = "3.jpg"},
                new Product(){Name = "IPHONE P30 PRO",Description ="128 GB AKILLI TELEFON ŞAFAK MAVİSİ", Price=1200,Stock=100,IsApproved=true,CategoryId=4, Image = "4.jpg"}
            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}