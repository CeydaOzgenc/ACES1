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
           
        }
        MySqlConnection connection;
        MySqlDataAdapter adtr;
        private void button1_Click()
        {
            
            DataTable dtbl1 = new DataTable();
            Data dt1 = new Data();
            connection = dt1.getConnection();
            adtr = dt1.getAdapter("select hastalik, ogunTipID from diyet_takvim");
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
        }
    }
}
