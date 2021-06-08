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
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = dt1.getCommand("select TC, password from kullanici");
            MySqlDataReader read = command.ExecuteReader();

            try
            {
                while (read.Read())
                {
                    if (read[0].ToString() == a && read[1].ToString() == b)
                    {
                        MessageBox.Show("BASARILI!!!");
                        FormDiyetisyen frm2 = new FormDiyetisyen();
                        frm2.Show();
                        this.Hide();
                        break;

                    }
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
