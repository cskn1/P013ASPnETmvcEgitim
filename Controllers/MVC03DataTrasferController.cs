using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC03DataTrasferController : Controller
    {
        public IActionResult Index( string Ara)
        {
            ViewBag.UrunKategorisi="Bilgisayar";
            ViewData["UrunAdi"] = "Asus DizÜstü Bilgisayar";
            TempData["UrunFiyati"] = 9999;
            ViewBag.GetVerisi = Ara;

        
            return View();
        }
    }
    [HttpPost] // AŞAĞIDAKİ MEOT POST İŞLEMİNDE ÇALIŞSIN
    public IActionResult Index(string text1,string ddlListe, bool cbOnay)
    {
        ViewBag.BirinciYontem = "1.Yöntem(Parametrelerden gelen veriler)";
        ViewBag.Mesaj = "Textbox dan gelen veri:" + text1;
        ViewBag.MesajListe = "ddListe den gelen ver:" + ddlListe;
        TempDataAttribute["Tdata"]="cbOnay dan gelen değer"+ cbOnay
        return View();
    }
}
