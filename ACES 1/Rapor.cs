using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ACES_1
{
    class Rapor
    {
    }
    public abstract class RaporTemelKurucu
    {
        protected Kullanici Kullanici;
        protected DiyetGunler Diyet;
        public RaporTemelKurucu(Kullanici kullanici,DiyetGunler diyet)
        {
            Kullanici = kullanici;
            Diyet = diyet;
        }
        public abstract StreamWriter KullaniciBilgi();
        public abstract StreamWriter DiyetBilgi();
    }
    /*public class RaporBilgi
    {
        public string KullaniciTC;
        public string KullaniciAdi;
        public string KullaniciSoyadi;
        public string KullaniciMail;
        public string KullaniciAdres;
        public string KullaniciTelno;
        public string KullaniciYas;
        public string KullaniciBoy;
        public string KullaniciKilo;
        public string KullaniciCinsiyet;
        public string KullaniciHastalik;
        public int DiyetGun;
        public string DiyetSabah;
        public string DiyetOgle;
        public string DiyetAksam;
        public string Diyet1Ara;
        public string Diyet2Ara;
        public string Diyet3Ara;

    }*/
    public class Kullanici
    {
        public string KullaniciTC;
        public string KullaniciAdi;
        public string KullaniciSoyadi;
        public string KullaniciMail;
        public string KullaniciAdres;
        public string KullaniciTelno;
        public string KullaniciYas;
        public string KullaniciBoy;
        public string KullaniciKilo;
        public string KullaniciCinsiyet;
        public string KullaniciHastalik;
    }
    public class DiyetGunler
    {
        public int DiyetGun;
        public string DiyetSabah;
        public string DiyetOgle;
        public string DiyetAksam;
        public string Diyet1Ara;
        public string Diyet2Ara;
        public string Diyet3Ara;
    }
    public class Diyet
    {
        public string diyetler;
        public IList<DiyetGunler> diyet;

    }
    public class JsonRaporKurucu : RaporTemelKurucu
    {
        StreamWriter json = new StreamWriter(File.Create("../../../rapor.json"));
        public JsonRaporKurucu(Kullanici kullanici,DiyetGunler diyet) : base(kullanici, diyet)
        {
        }
        public override StreamWriter KullaniciBilgi()
        {
            Kullanici musteri = new Kullanici {
                KullaniciTC = base.Kullanici.KullaniciTC, 
                KullaniciAdi = base.Kullanici.KullaniciAdi,
                KullaniciSoyadi = base.Kullanici.KullaniciSoyadi,
                KullaniciMail = base.Kullanici.KullaniciMail,
                KullaniciAdres = base.Kullanici.KullaniciAdres,
                KullaniciTelno = base.Kullanici.KullaniciTelno,
                KullaniciYas = base.Kullanici.KullaniciYas,
                KullaniciBoy = base.Kullanici.KullaniciBoy,
                KullaniciKilo = base.Kullanici.KullaniciKilo,
                KullaniciCinsiyet = base.Kullanici.KullaniciCinsiyet,
                KullaniciHastalik = base.Kullanici.KullaniciHastalik

            };
            string jsonyazi = JsonConvert.SerializeObject(musteri);
            json.WriteLine(jsonyazi);
            return json;
        }
        public override StreamWriter DiyetBilgi()
        {
            int gun;
            gun = base.Diyet.DiyetGun;
            Diyet k_diyet = new Diyet();
            k_diyet.diyetler = "Diyet";
            List<DiyetGunler> musteridiyet = new List<DiyetGunler>();
            for (int x = 1; x <= gun; x++) {
                DiyetGunler diyetx = new DiyetGunler {
                    DiyetSabah = base.Diyet.DiyetSabah,
                    Diyet1Ara = base.Diyet.Diyet1Ara,
                    DiyetOgle = base.Diyet.DiyetOgle,
                    Diyet2Ara = base.Diyet.Diyet2Ara,
                    DiyetAksam = base.Diyet.DiyetAksam,
                    Diyet3Ara = base.Diyet.Diyet3Ara
                };
                musteridiyet.Add(diyetx);
            }
            k_diyet.diyet = musteridiyet;
            string jsonyazi = JsonConvert.SerializeObject(k_diyet);
            json.WriteLine(jsonyazi);
            return json;
        }
    }

    public class HtmlRaporKurucu : RaporTemelKurucu
    {
        StreamWriter html = new StreamWriter(File.Create("../../../rapor.html"));
        public HtmlRaporKurucu(Kullanici kullanici, DiyetGunler diyet) : base(kullanici, diyet)
        {
        }
        public override StreamWriter KullaniciBilgi()
        {
            html.WriteLine("<h1> Kullanıcı </h1>");
            html.WriteLine("<ul>");
            html.WriteLine("<li>TC: " + base.Kullanici.KullaniciTC + "</li>");
            html.WriteLine("<li>Ad: " + base.Kullanici.KullaniciAdi + "</li>");
            html.WriteLine("<li>Soyad: " + base.Kullanici.KullaniciSoyadi + "</li>");
            html.WriteLine("<li>Mail: " + base.Kullanici.KullaniciMail + "</li>");
            html.WriteLine("<li>Adres: " + base.Kullanici.KullaniciAdres + "</li>");
            html.WriteLine("<li>TelNo: " + base.Kullanici.KullaniciTelno + "</li>");
            html.WriteLine("<li>Yas: " + base.Kullanici.KullaniciYas + "</li>");
            html.WriteLine("<li>Boy: " + base.Kullanici.KullaniciBoy + "</li>");
            html.WriteLine("<li>Kilo: " + base.Kullanici.KullaniciKilo + "</li>");
            html.WriteLine("<li>Cinsiyet: " + base.Kullanici.KullaniciCinsiyet + "</li>");
            html.WriteLine("<li>Hastalik: " + base.Kullanici.KullaniciHastalik + "</li>");
            html.WriteLine("</ul>");
            return html;
        }
        public override StreamWriter DiyetBilgi()
        {
            int gun;
            gun = base.Diyet.DiyetGun;
            html.WriteLine("<h1> Diyet </h1>");
            html.WriteLine("<table style='border: 1px solid black; border - collapse: collapse;'>");
            html.WriteLine("<tr>");
            if (base.Diyet.DiyetSabah != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>Sabah</th>");
            }
            if (base.Diyet.Diyet1Ara != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>1.Ara</th>");
            }
            if (base.Diyet.DiyetOgle != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>Öğle</th>");
            }
            if (base.Diyet.Diyet2Ara != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>2.Ara</th>");
            }
            if (base.Diyet.DiyetAksam != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>Aksam</th>");
            }
            if (base.Diyet.Diyet3Ara != "")
            {
                html.WriteLine("<th style='border: 1px solid black; border - collapse: collapse;'>3.Ara</th>");
            }
            html.WriteLine("</tr>");
            for (int x=0;x<gun;x++)
            {
                html.WriteLine("<tr>");
                if (base.Diyet.DiyetSabah != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.DiyetSabah+"</td>");
                }
                if (base.Diyet.Diyet1Ara != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.Diyet1Ara+"</td>");
                }
                if (base.Diyet.DiyetOgle != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.DiyetOgle+"</td>");
                }
                if (base.Diyet.Diyet2Ara != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.Diyet2Ara+"</td>");
                }
                if (base.Diyet.DiyetAksam != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.DiyetAksam+"</td>");
                }
                if (base.Diyet.Diyet3Ara != "")
                {
                    html.WriteLine("<td style='border: 1px solid black; border - collapse: collapse;'>" + base.Diyet.Diyet3Ara+"</td>");
                }
                html.WriteLine("</tr>");
            }
            html.WriteLine("</table>");
            return html;
        }
    }
    public class RaporYontemi
    {
        private RaporTemelKurucu Rapor;
        StreamWriter html;
        public RaporYontemi(RaporTemelKurucu rapor)
        {
            Rapor = rapor;
        }
       public string RaporBilgiYazi()
        {
            Rapor.KullaniciBilgi();
            html= Rapor.DiyetBilgi();
            html.Close();
            return "";
        }
        public string RaporBilgiTersYazi()
        {
            Rapor.DiyetBilgi();
            html= Rapor.KullaniciBilgi();
            html.Close();
            return "";
        }
    }
}
