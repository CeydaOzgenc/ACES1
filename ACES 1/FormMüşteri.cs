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
    public partial class FormMüşteri : Form
    {
        string TC;
        public FormMüşteri(string TC)
        {
            InitializeComponent();
            this.TC = TC;
            
        }

        private void FormMüşteri_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            Data dt1 = new Data();
            command = dt1.getCommand("select * from kullanici where TC= " + TC);
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                lblTC.Text = read[0].ToString();
                lblName.Text = read[1].ToString();
                lblSurname.Text = read[2].ToString();
                lblMail.Text = read[3].ToString();
                lblPassword.Text = read[4].ToString();
                lblTelNo.Text = read[5].ToString();
                lblAddress.Text = read[6].ToString();
                lblYas.Text = read[7].ToString();
                lblBoy.Text = read[8].ToString();
                lblKilo.Text = read[9].ToString();
                lblCinsiyet.Text = read[10].ToString();
            }
            
        }
    }
}
