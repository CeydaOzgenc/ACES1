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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=diyetveri_050621");
            baglanti.Open();
        }

        private void button1_Click()
        {
            MySqlConnection connection;
            MySqlCommand command;
            Data data1 = new Data();
            connection= data1.getConnection();
            connection.Open();
            command = ("select hastalik, ogunTipID from diyet_takvim");
            
        }
    }
}
