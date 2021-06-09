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
        public FormMüşteri(string TC)
        {
            InitializeComponent();
        }

        private void FormMüşteri_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            Data dt1 = new Data();
            command = dt1.getCommand("select * from kullanici");




        }
    }
}
