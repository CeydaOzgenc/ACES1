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
    public partial class FormDiyetisyen : Form
    {
        public FormDiyetisyen()
        {
            InitializeComponent();
            Data data1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = data1.getAdapter("select k.name,k.surname,k.hastalik, d.ogunTipID, k.TC from kullanici k, diyet_takvim d where tip LIKE '%Müşteri%'AND k.hastalik = d.hastalik ");
            DataTable dtbl1 = new DataTable();
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

        }

        private void FormDiyetisyen_Load(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            lblMusteriAd.Text = selectedRow.Cells[0].Value.ToString();
            lblMusteriSoyad.Text = selectedRow.Cells[1].Value.ToString();
            lblMusteriHastalik.Text = selectedRow.Cells[2].Value.ToString();
            lblOgunTip.Text = selectedRow.Cells[3].Value.ToString();
            lblTC.Text = selectedRow.Cells[4].Value.ToString();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            MüşteriEkle musteriEkle = new MüşteriEkle();
            musteriEkle.ShowDialog();
            tabloGuncelle();
        }

        public void tabloGuncelle()
        {
            Data data1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = data1.getAdapter("select k.name,k.surname,k.hastalik, d.ogunTipID, k.TC from kullanici k, diyet_takvim d where tip LIKE '%Müşteri%'AND k.hastalik = d.hastalik ");
            DataTable dtbl1 = new DataTable();
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Data data1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = data1.getCommand("DELETE FROM kullanici WHERE TC =@TC");
            command.Parameters.AddWithValue("@TC", lblTC.Text);
            command.ExecuteNonQuery();
            tabloGuncelle();
        }

        private void btnDiyet_Click(object sender, EventArgs e)
        {
            DiyetOlustur diyetOlustur = new DiyetOlustur(lblTC.Text);
            diyetOlustur.ShowDialog();

        }
    }
}
