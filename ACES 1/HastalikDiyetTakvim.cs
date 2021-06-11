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
        bool takvimOlustur(string TC, string yontem);
    }
    public class ObezDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(string TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Obezite'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='"+readOgunTip[0].ToString()+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    dtbase.getCommand("update kullanici_diyet set sabah='"+readkomut[3]+"', 1ara='"+readkomut[4]+"', ogle='"+readkomut[5]+"', 2ara='"+readkomut[6]+"', aksam='"+readkomut[7]+"', 3ara='"+readkomut[8]+"' where TC='"+TC+"'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(string TC, string yontem)
        {
            DiyetYontemFabrikasi yontemFabrikasi = new DiyetYontemFabrikasi();
            IDiyetYontem diyetYontem = yontemFabrikasi.diyetYontemNesnesiOlustur(yontem);
            diyetYontem.takvimYapisi(TC);
            return true;
        }
    }

    public class ColyakDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(string TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Çölyak'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='"+readOgunTip[0].ToString()+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    tkvolustur = dtbase.getCommand("update kullanici_diyet set sabah='" + readkomut[3] + "', 1ara='" + readkomut[4] + "', ogle='" + readkomut[5] + "', 2ara='" + readkomut[6] + "', aksam='" + readkomut[7] + "', 3ara='" + readkomut[8] + "' where TC='" + TC + "'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(string TC, string yontem)
        {
            DiyetYontemFabrikasi yontemFabrikasi = new DiyetYontemFabrikasi();
            IDiyetYontem diyetYontem = yontemFabrikasi.diyetYontemNesnesiOlustur(yontem);
            diyetYontem.takvimYapisi(TC);
            return true;
        }
    }

    public class SekerDiyetTakvim : IDiyetTakvim
    {
        public bool takvimOlustur(string TC, string yontem)
        {
            Data dtbase = new Data();
            MySqlCommand ogunTip = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand tkvolustur = new MySqlCommand();
            ogunTip = dtbase.getCommand("select Oguntip from diyet_takvim where hastalik='Seker'");
            MySqlDataReader readOgunTip = ogunTip.ExecuteReader();
            while (readOgunTip.Read())
            {
                komut = dtbase.getCommand("select * from ogun_tip where ogunTip='"+readOgunTip[0].ToString()+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    tkvolustur = dtbase.getCommand("update kullanici_diyet set sabah='" + readkomut[3] + "', 1ara='" + readkomut[4] + "', ogle='" + readkomut[5] + "', 2ara='" + readkomut[6] + "', aksam='" + readkomut[7] + "', 3ara='" + readkomut[8] + "' where TC='" + TC + "'");
                }
            }
            return this.yontemOlustur(TC, yontem);
        }
        public bool yontemOlustur(string TC, string yontem)
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
            if (diyetTip == "Obezite")
            {
                return new ObezDiyetTakvim();
            }
            else if (diyetTip == "Çölyak")
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
