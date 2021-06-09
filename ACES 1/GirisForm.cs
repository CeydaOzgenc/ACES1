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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txtTC.Text;
            string b = txtSifre.Text;
            Boolean state = false;
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = dt1.getCommand("select TC, password,tip from kullanici");
            MySqlDataReader read = command.ExecuteReader();

            try
            {

                while (read.Read())
                {
                    if (read[0].ToString() == a && read[1].ToString() == b && read[2].ToString() == "Diyetisyen" )
                    {
                        state = true;
                        FormDiyetisyen frmDiyetisyen = new FormDiyetisyen();
                        frmDiyetisyen.Show();
                        this.Hide();
                        break;

                    }
                    else if(read[0].ToString() == a && read[1].ToString() == b && read[2].ToString() == "Admin")
                    {
                        state = true;
                        FormAdmin frmAdmin = new FormAdmin();
                        frmAdmin.Show();
                        this.Hide();
                    }
                    else if(read[0].ToString() == a && read[1].ToString() == b && read[2].ToString() == "Müşteri")
                    {
                        state = true;
                        FormMüşteri frmMusteri = new FormMüşteri(read[0].ToString());
                        frmMusteri.Show();
                        this.Hide();
                    }
                    
                }
                if(state == false)
                {
                    MessageBox.Show("Hatali Giris Denemesi!");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("hata: " + error.Message);
            }
           
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
