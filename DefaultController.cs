using Microsoft.AspNetCore.Mvc;
using Project_OOP.Ornekler;
using System.Diagnostics;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void messages() // geriye değer döndürmeyen metot örnegi
        {
            ViewBag.m1 = "Merhaba bu bir Core Projesi";
            ViewBag.m2 = "Proje çok iyi gidiyor";
            ViewBag.m3 = "Bu kursu sevdim.";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int cevre()
        {
            int kisa = 30;
            int uzun = 50;
            int cvr = 2 * (kisa + uzun);
            return cvr;
        }

        int Carp(int s1,int s2) // geriye deger donduren parametreli metot ornegi
        {
            int sonuc = s1 * s2;
            return sonuc;
        }
        void Kullanici(string kullaniciAdi)
        {
            ViewBag.v = kullaniciAdi; // parametreden gelen degeri disaridan erisilecek degere esitledik
        }

        int Faktoriyel(int p)
        {
            int f = 1; // kontrol degiskeni
            for(int i = 1;i<=p;i++) // disardian verilen param gore faktoriyel islemi yapilir.
            {
                f = f * i;
            }
            return f;
        }
        public IActionResult Index()
        {
            ViewBag.c = Carp(4,6); // metotumuzu tasımak icin viewbag esitledik.
            Kullanici("User1"); // parametre degerini verdik.
            messages();
            return View();
        }
        public IActionResult Urunler()
        {
            ViewBag.faktor = Faktoriyel(6);
            messages();
            ViewBag.t = topla(); // void türünde olsaydı hata verirdi.
            ViewBag.c = cevre();
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();

            sehirler.Ad = "GaziAntep";
            sehirler.Id = 1;
            sehirler.Nufus = 1780000;
            sehirler.Ulke = "Turkey";
            sehirler.Renk1 = "Kirmizi";
            sehirler.Renk2 = "Beyaz";

            ViewBag.v1 = sehirler.Ad;
            ViewBag.v2 = sehirler.Id;
            ViewBag.v3 = sehirler.Nufus;
            ViewBag.v4 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;

            return View();
        }
    }
}
