using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACES_1
{
    class Rapor
    {
    }

    public abstract class RaporTemelKurucu
    {
        protected RaporBilgi Bilgi;
        public RaporTemelKurucu(RaporBilgi raporbilgi)
        {
            Bilgi = raporbilgi;
        }
        public abstract string KullaniciBilgi();
        public abstract string DiyetBilgi();
    }
    public class RaporBilgi
    {
        public int KullaniciTC;
        public string KullaniciAdi;
        public string KullaniciSoyadi;
        public string KullaniciMail;
        public string KullaniciSifre;
        public string KullaniciAdres;
        public int KullaniciTelno;
        public int KullaniciYas;
        public int KullaniciBoy;
        public int KullaniciKilo;
        public int KullaniciCinsiyet;
        public string KullaniciHastalik;
        public int DiyetGun;
        public string DiyetSabah;
        public string DiyetOgle;
        public string DiyetAksam;
        public string Diyet1Ara;
        public string Diyet2Ara;
        public string Diyet3Ara;

    }
    public class JsonRaporKurucu : RaporTemelKurucu
    {
        public JsonRaporKurucu(RaporBilgi raporbilgi) : base(raporbilgi)
        {
        }
        public override string KullaniciBilgi()
        {
            throw new NotImplementedException();
        }
        public override string DiyetBilgi()
        {
            throw new NotImplementedException();
        }
    }

    public class HtmlRaporKurucu : RaporTemelKurucu
    {
        public HtmlRaporKurucu(RaporBilgi raporbilgi) : base(raporbilgi)
        {
        }
        public override string KullaniciBilgi()
        {
            throw new NotImplementedException();
        }
        public override string DiyetBilgi()
        {
            throw new NotImplementedException();
        }
    }
    public class RaporYontemi
    {
        private RaporTemelKurucu Rapor;
        public RaporYontemi(RaporTemelKurucu rapor)
        {
            Rapor = rapor;
        }
        public string RaporBilgiYazi()
        {
            string product = Rapor.KullaniciBilgi();
            product += Rapor.DiyetBilgi();
            return product;
        }
        public string RaporBilgiTersYazi()
        {
            string product = Rapor.DiyetBilgi();
            product += Rapor.KullaniciBilgi();
            return product;
        }
    }
}
