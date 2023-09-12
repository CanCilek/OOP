using Microsoft.AspNetCore.Mvc;
using OOP.Ornekler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}

        void messages()
        {
            ViewBag.m1 = "Merhaba Bu Bir Core Projesi";
            ViewBag.m2 = "Merhaba Proje Çok İyi Duruyor";
            ViewBag.m3 = "Hi!!";
        }

        int Topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;

        }

        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int c = 2 * (kisa + uzun);
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }


        public IActionResult Index()
        {

            messages();
            MesajListesi("Parametre İsmi");
            return View();
        }

        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = Topla();
            ViewBag.c = Cevre();
            return View();

        }

        public IActionResult Musteriler()
        {
            return View();
        }


        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            

            sehirler.SehirId = 1;
            sehirler.SehirAd = "Kiev";
            sehirler.Nufus = 1000;
            sehirler.Ulke = "Ukrayna";
            sehirler.renk1 = "Mavi";
            sehirler.renk2 = "Sarı";
            ViewBag.s1 = sehirler.SehirId;
            ViewBag.s2 = sehirler.SehirAd;
            ViewBag.s3 = sehirler.Nufus;
            ViewBag.s4 = sehirler.Ulke;
            ViewBag.s5 = sehirler.renk1;
            ViewBag.s6 = sehirler.renk2;

            return View();
        }
    }
}
