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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Data data1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = data1.getAdapter("select k.name,k.surname,k.hastalik, d.ogunTipID from kullanici k, diyet_takvim d where tip LIKE '%Müşteri%'AND k.hastalik = d.hastalik ");
            DataTable dtbl1 = new DataTable();
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

        }



    }
}
