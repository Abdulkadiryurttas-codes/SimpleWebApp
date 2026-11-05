using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class PersonelController : Controller
    {
        static List<Personel> personelList = new List<Personel>()
            {

            new Personel() { Ad = "Ahmet", Soyad = "Taş", Departman = "Finans", Id = 1},
            new Personel() { Ad = "Yusuf", Soyad = "Kanık", Departman = "Pc", Id = 2},
            new Personel() { Ad = "Emre", Soyad = "Cöne", Departman = "IT", Id = 3},
            new Personel() { Ad = "Hamam", Soyad = "Böcek", Departman = "Toprak", Id = 4}

    };

        public PersonelController()
        {

        }
        public IActionResult Index()
        {
            var p = new Personel();
            p.Ad = "Abdulkadir";
            p.Soyad = "Yurttaş";
            p.Departman = "Muhasebe";

            return View(p);
        }

        public IActionResult PersonelListesi()
        {
            //var liste = new List<Personel>() {
            //new Personel(){Ad="Ahmet", Soyad="Taş", Departman="Finans", Id=1},
            //new Personel(){Ad="Yusuf", Soyad="Kanık", Departman="Pc", Id=2},
            //new Personel(){Ad="Emre", Soyad="Cöne", Departman="IT", Id=3},
            //new Personel(){Ad="Hamam", Soyad="Böcek", Departman="Toprak", Id=4}
            //};

            return View("Liste", personelList);
        }

        public IActionResult Ara(int arananId)
        {
            Personel bulunan = null;

            foreach (var personel in personelList)
            {
                if (personel.Id == arananId)
                {
                    bulunan = personel;
                    break;
                }
            }
            return View(bulunan);
        }

        public IActionResult Selamla(string ad, string soyad)
        {
            var p = new Personel();
            p.Ad = ad;
            p.Soyad = soyad;

            return View(p);
        }

        public IActionResult VeriGonder(int deger)
        {
            ViewData["Veri"] = deger;
            ViewBag.Deger = deger;

            return View();
        }

        public IActionResult Topla(int s1, int s2)
        {
            ViewData["s1"] = s1;
            ViewData["s2"] = s2;

            return View();
        }

        public IActionResult Ekle()
        {
            return View();
        }

        public IActionResult Kaydet(int id, string ad, string soyad, string departman)
        {
            var yeniPersonel = new Personel
            {
                Id = id,
                Ad = ad,
                Soyad = soyad,
                Departman = departman
            };
            personelList.Add(yeniPersonel);
            return RedirectToAction("PersonelListesi");
        }
    }
}
