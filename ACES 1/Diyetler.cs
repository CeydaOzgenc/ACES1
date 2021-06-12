using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+"'");
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "=''");
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
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+"'");
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "=''");
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
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+"'");
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "=''");
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
                    for (int x = 2; x < 8; x++)
                    {
                        if (readkomut[x].ToString() == "1")
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "='"+readOgunYontem[x]+"'");
                        }
                        else
                        {
                            yntolustur = dtbase.getCommand("update kullanici_diyet set " + veri[x - 2] + "=''");
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
            if (diyetTip == "Akdeniz")
            {
                return new AkdenizDiyeti();
            }
            else if (diyetTip == "GlutenFree")
            {
                return new GlutenFreeDiyeti();
            }
            else if (diyetTip == "DenizUrunleri")
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

