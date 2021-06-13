using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACES_1
{
    public partial class FormRapor : Form
    {
        string _TC;
        public FormRapor(string TC)
        {
            _TC = TC;
            InitializeComponent();
        }

        private void btnrapor_Click(object sender, EventArgs e)
        {
            int raporsecim;
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = dt1.getCommand("select kd.TC, kd.gun, kd.sabah, kd.1ara, kd.ogle, kd.2ara, kd.aksam, kd.3ara , k.name, k.surname, k.mail, k.address, k.telNo, k.yas, k.boy, k.kilo, k.cinsiyet, k.hastalik FROM kullanici_diyet kd, kullanici k WHERE kd.TC = '" + _TC+"' and k.TC='"+ _TC + "'");
            MySqlDataReader readCommand = command.ExecuteReader();
            Kullanici kullanici = new Kullanici();
            DiyetGunler diyet = new DiyetGunler();
            while (readCommand.Read())
            {
                kullanici.KullaniciTC = readCommand[0].ToString();
                kullanici.KullaniciAdi = readCommand[7].ToString();
                kullanici.KullaniciSoyadi = readCommand[8].ToString();
                kullanici.KullaniciMail = readCommand[9].ToString();
                kullanici.KullaniciAdres = readCommand[10].ToString();
                kullanici.KullaniciTelno = readCommand[11].ToString();
                kullanici.KullaniciYas = readCommand[12].ToString();
                kullanici.KullaniciBoy = readCommand[13].ToString();
                kullanici.KullaniciKilo = readCommand[14].ToString();
                kullanici.KullaniciCinsiyet = readCommand[15].ToString();
                kullanici.KullaniciHastalik = readCommand[16].ToString();
                diyet.DiyetGun = Convert.ToInt16(readCommand[1]);
                diyet.DiyetSabah = readCommand[2].ToString();
                diyet.Diyet1Ara = readCommand[3].ToString();
                diyet.DiyetOgle = readCommand[4].ToString();
                diyet.Diyet2Ara = readCommand[5].ToString();
                diyet.DiyetAksam = readCommand[6].ToString();
                diyet.Diyet3Ara = readCommand[7].ToString();
            }
            RaporTemelKurucu rapor;
            raporsecim =cmbFormatlar.SelectedIndex;
            if (raporsecim == 0)
            {
                rapor = new HtmlRaporKurucu(kullanici,diyet);
            }
            else
            {
                rapor = new JsonRaporKurucu(kullanici,diyet);
            }
            RaporYontemi yonetim = new RaporYontemi(rapor);
            raporsecim = comboBox2.SelectedIndex;
            if (raporsecim == 0)
            {
                yonetim.RaporBilgiYazi();
            }
            else
            {
                yonetim.RaporBilgiTersYazi();
            }
        }
    }
}
