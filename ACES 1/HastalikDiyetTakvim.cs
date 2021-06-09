using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ACES_1
{
    class HastalikDiyetTakvim // adi boyle kalsin diye ellemedik.
    {
    }
    public interface IDiyetTakvim
    {
        bool takvimOlustur(int TC, string yontem);
    }
    public class ObezDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(int TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Obez'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='readOgunTip[0].ToString()'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    dtbase.getCommand("update kullanici_diyet set sabah='readkomut[3]', 1ara='readkomut[4]', ogle='readkomut[5]', 2ara='readkomut[6]', aksam='readkomut[7]', 3ara='readkomut[8]' where TC='TC'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(int TC, string yontem)
        {
            DiyetYontemFabrikasi yontemFabrikasi = new DiyetYontemFabrikasi();
            IDiyetYontem diyetYontem = yontemFabrikasi.diyetYontemNesnesiOlustur(yontem);
            diyetYontem.takvimYapisi(TC);
            return true;
        }
    }

    public class ColyakDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(int TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Colyak'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='readOgunTip[0].ToString()'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    tkvolustur = dtbase.getCommand("update kullanici_diyet set sabah=readkomut[3], 1ara=readkomut[4], ogle=readkomut[5], 2ara=readkomut[6], aksam=readkomut[7], 3ara=readkomut[8] where TC='TC'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(int TC, string yontem)
        {
            DiyetYontemFabrikasi yontemFabrikasi = new DiyetYontemFabrikasi();
            IDiyetYontem diyetYontem = yontemFabrikasi.diyetYontemNesnesiOlustur(yontem);
            diyetYontem.takvimYapisi(TC);
            return true;
        }
    }

    public class SekerDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(int TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Seker'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='readOgunTip[0].ToString()'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    tkvolustur = dtbase.getCommand("update kullanici_diyet set sabah='readkomut[3].ToString()', 1ara='readkomut[4].ToString()', ogle='readkomut[5].ToString()', 2ara='readkomut[6].ToString()', aksam='readkomut[7].ToString()', 3ara='readkomut[8].ToString()' where TC='TC'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(int TC, string yontem)
        {
            DiyetYontemFabrikasi yontemFabrikasi = new DiyetYontemFabrikasi();
            IDiyetYontem diyetYontem = yontemFabrikasi.diyetYontemNesnesiOlustur(yontem);
            diyetYontem.takvimYapisi(TC);
            return true;
        }
    }

    public class DiyetTakvimFabrikasi
    {
        public IDiyetTakvim diyetTakvimNesnesiOlustur(string diyetTip)
        {
            if (diyetTip == "Obez")
            {
                return new ObezDiyetTakvim();
            }
            else if (diyetTip == "Colyak")
            {
                return new ColyakDiyetTakvim();
            }
            else
            {
                return new SekerDiyetTakvim();
            }
        }
    }
}
