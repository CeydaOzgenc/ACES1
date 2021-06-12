using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ACES_1
{
    class Diyetler
    {
    }
    public interface IDiyetYontem
    {
        bool takvimYapisi(string TC);
    }
    public class AkdenizDiyeti : IDiyetYontem
    {
        public bool takvimYapisi(string TC)
        {
            Data dtbase = new Data();
            MySqlCommand ogunYontem = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand yntolustur = new MySqlCommand();
            ogunYontem = dtbase.getCommand("select * from diyet_yontem where yontemTip='Akdeniz Diyeti'");
            MySqlDataReader readOgunYontem = ogunYontem.ExecuteReader();
            while (readOgunYontem.Read())
            {
                string[] veri = new string[] { "sabah", "1ara", "ogle", "2ara", "aksam", "3ara" };
                komut = dtbase.getCommand("select * from kullanici_diyet where TC='"+TC+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    yntolustur = dtbase.getCommand("update kullanici_diyet set yontemTip='Akdeniz Diyeti' where TC='"+TC+"'");
                    yntolustur.ExecuteNonQuery();
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x+1].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+ "' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                    }
                }
            }
            return true;
        }
    }
    public class GlutenFreeDiyeti : IDiyetYontem
    {
        public bool takvimYapisi(string TC)
        {
            Data dtbase = new Data();
            MySqlCommand ogunYontem = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand yntolustur = new MySqlCommand();
            ogunYontem = dtbase.getCommand("select * from diyet_yontem where yontemTip='Gluten Free Diyeti'");
            MySqlDataReader readOgunYontem = ogunYontem.ExecuteReader();
            while (readOgunYontem.Read())
            {
                string[] veri = new string[] { "sabah", "1ara", "ogle", "2ara", "aksam", "3ara" };
                komut = dtbase.getCommand("select * from kullanici_diyet where TC='"+TC+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    yntolustur = dtbase.getCommand("update kullanici_diyet set yontemTip='Gluten Free Diyeti' where TC='" + TC + "'");
                    yntolustur.ExecuteNonQuery();
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x+1].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+ "' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                    }
                }
            }
            return true;
        }
    }
    public class DenizUrunleriDiyeti : IDiyetYontem
    {
        public bool takvimYapisi(string TC)
        {
            Data dtbase = new Data();
            MySqlCommand ogunYontem = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand yntolustur = new MySqlCommand();
            ogunYontem = dtbase.getCommand("select * from diyet_yontem where yontemTip='Deniz Urunleri Diyeti'");
            MySqlDataReader readOgunYontem = ogunYontem.ExecuteReader();
            while (readOgunYontem.Read())
            {
                string[] veri = new string[] { "sabah", "1ara", "ogle", "2ara", "aksam", "3ara" };
                komut = dtbase.getCommand("select * from kullanici_diyet where TC='"+TC+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    yntolustur = dtbase.getCommand("update kullanici_diyet set yontemTip='Deniz Mahsulleri Diyeti' where TC='" + TC + "'");
                    yntolustur.ExecuteNonQuery();
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x+1].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+ "' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                    }
                }
            }
            return true;
        }
    }
    public class YesilliklerDunyasiDiyeti : IDiyetYontem
    {
        public bool takvimYapisi(string TC)
        {
            Data dtbase = new Data();
            MySqlCommand ogunYontem = new MySqlCommand();
            MySqlCommand komut = new MySqlCommand();
            MySqlCommand yntolustur = new MySqlCommand();
            ogunYontem = dtbase.getCommand("select * from diyet_yontem where yontemTip='Yesillikler Dunyasi Diyeti'");
            MySqlDataReader readOgunYontem = ogunYontem.ExecuteReader();
            while (readOgunYontem.Read())
            {
                string[] veri = new string[] { "sabah", "1ara", "ogle", "2ara", "aksam", "3ara" };
                komut = dtbase.getCommand("select * from kullanici_diyet where TC='"+TC+"'");
                MySqlDataReader readkomut = komut.ExecuteReader();
                while (readkomut.Read())
                {
                    yntolustur = dtbase.getCommand("update kullanici_diyet set yontemTip='Yeşillikler Dünyasi Diyeti' where TC='" + TC + "'");
                    yntolustur.ExecuteNonQuery();
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x + 1].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+ "' where TC='" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='' where TC = '" + TC + "'");
                            yntolustur.ExecuteNonQuery();
                        }
                    }
                }
            }
            return true;
        }
    }
    public class DiyetYontemFabrikasi
    {
        public IDiyetYontem diyetYontemNesnesiOlustur(string diyetTip)
        {
            if (diyetTip == "Akdeniz Diyeti")
            {
                return new AkdenizDiyeti();
            }
            else if (diyetTip == "Gluten Free Diyeti")
            {
                return new GlutenFreeDiyeti();
            }
            else if (diyetTip == "Deniz Mahsulleri Diyeti")
            {
                return new DenizUrunleriDiyeti();
            }
            else
            {
                return new YesilliklerDunyasiDiyeti();
            }
        }
    }
}

