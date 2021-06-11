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
    public partial class MüşteriEkle : Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();
        }
        FormDiyetisyen formDiyetisyen = new FormDiyetisyen();
        private void button1_Click(object sender, EventArgs e)
        {
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            try
            {
                command = dt1.getCommand("INSERT INTO kullanici(TC, name, surname, mail, password, address, telNo, yas, boy, kilo, cinsiyet, tip, hastalik) VALUES(@TC, @name, @surname, @mail, @password, @address, @telNo, @yas, @boy, @kilo, @cinsiyet, @tip, @hastalik) ");
                command.Parameters.AddWithValue("@TC", txtTC.Text);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@surname", txtSurname.Text);
                command.Parameters.AddWithValue("@mail", txtMail.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@telNo", txtTelNo.Text);
                command.Parameters.AddWithValue("@yas", txtYas.Text);
                command.Parameters.AddWithValue("@boy", txtBoy.Text);
                command.Parameters.AddWithValue("@kilo", txtKilo.Text);
                command.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
                command.Parameters.AddWithValue("@tip", "Müşteri");
                command.Parameters.AddWithValue("@hastalik", cmbHastalik.Text);
                command.ExecuteNonQuery();
                temizlik();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                
                MessageBox.Show("Müşteri Ekle Tamamlandı.");
            }
        }



        void temizlik()
        {
            txtTC.Text = " ";
            txtName.Text = " ";
            txtSurname.Text = " ";
            txtMail.Text = " ";
            txtPassword.Text = " ";
            txtAddress.Text = " ";
            txtTelNo.Text = " ";
            txtYas.Text = " ";
            txtBoy.Text = " ";
            txtKilo.Text = " ";
            cmbCinsiyet.Text = " ";
            cmbHastalik.Text = " ";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizlik();
        }
    }
}
