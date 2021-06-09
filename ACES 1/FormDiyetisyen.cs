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
            // TODO: Bu kod satırı 'diyetveri_050621DataSet.ogun_tip' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogun_tipTableAdapter.Fill(this.diyetveri_050621DataSet.ogun_tip);

            


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

        private void button1_Click(object sender, EventArgs e)
        {
            Data dt1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = dt1.getAdapter("UPDATE kullanici SET ogunTipID = '" +lblOgunTip.Text +"' where TC = " + lblTC.Text );
            //dt1.tabloGuncelle("select k.name,k.surname,k.hastalik, d.ogunTipID, k.TC from kullanici k, diyet_takvim d where tip LIKE '%Müşteri%'AND k.hastalik = d.hastalik ");
            DataTable dtbl666 = new DataTable();
            adtr = dt1.getAdapter("select k.name,k.surname,k.hastalik, d.ogunTipID, k.TC from kullanici k, diyet_takvim d where tip LIKE '%Müşteri%'AND k.hastalik = d.hastalik ");
            adtr.Fill(dtbl666);
        }
    }
}
