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
    public partial class DiyetOlustur : Form
    {
        string _TC;
        public DiyetOlustur(string TC)
        {
            _TC = TC;
            InitializeComponent();
        }

        private void DiyetOlustur_Load(object sender, EventArgs e)
        {
            Data dt1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            MySqlCommand bak = new MySqlCommand();
            DataTable dtbl1 = new DataTable();
            adtr = dt1.getAdapter("select kd.TC, kd.sabah, kd.1ara, kd.ogle, kd.2ara, kd.aksam, kd.3ara , k.hastalik FROM kullanici_diyet kd, kullanici k WHERE kd.TC = k.TC");
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
            command = dt1.getCommand("SELECT * FROM kullanici WHERE TC = @TC");
            command.Parameters.AddWithValue("@TC", _TC);
            MySqlDataReader readCommand = command.ExecuteReader();
            try
            {
                while(readCommand.Read())
                {
                    lblTC.Text = readCommand[0].ToString();
                    lblName.Text = readCommand[1].ToString();
                    lblSurname.Text = readCommand[2].ToString();
                    lblMail.Text = readCommand[3].ToString();
                    lblTelNo.Text = readCommand[6].ToString();
                    lblYas.Text = readCommand[7].ToString();
                    lblBoy.Text = readCommand[8].ToString();
                    lblKilo.Text = readCommand[9].ToString();
                    lblCinsiyet.Text = readCommand[10].ToString();
                    lblHastalik.Text = readCommand[12].ToString();
                    bak = dt1.getCommand("select * from kullanici_diyet where TC='" + lblTC.Text.ToString() + "'");
                    MySqlDataReader readbak = bak.ExecuteReader();
                    if (readbak.Read())
                    {
                        comboBox1.SelectedItem = readbak[1].ToString();
                        comboBox2.SelectedItem = readbak[2].ToString();
                    }

                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtTC.Text = selectedRow.Cells[0].Value.ToString();
            txtName.Text = selectedRow.Cells[1].Value.ToString();
            txtSurname.Text = selectedRow.Cells[2].Value.ToString();
            txtMail.Text = selectedRow.Cells[3].Value.ToString();
            txtPassword.Text = selectedRow.Cells[4].Value.ToString();
            txtAddress.Text = selectedRow.Cells[5].Value.ToString();
            txtTelNo.Text = selectedRow.Cells[6].Value.ToString();
            txtYas.Text = selectedRow.Cells[7].Value.ToString();
            txtBoy.Text = selectedRow.Cells[8].Value.ToString();
            txtKilo.Text = selectedRow.Cells[9].Value.ToString();
            txtCinsiyet.Text = selectedRow.Cells[10].Value.ToString();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            MySqlCommand bak = new MySqlCommand();
            bak= dt1.getCommand("select * from kullanici_diyet where TC='"+lblTC.Text.ToString()+"'");
            MySqlDataReader readbak = bak.ExecuteReader();
            if (readbak.Read()) {
                command = dt1.getCommand("update kullanici_diyet set gun="+ Convert.ToInt32(comboBox1.SelectedItem) + " where TC = '"+readbak[0]+"'");
                command.ExecuteNonQuery();
            }
            else
            {
                command = dt1.getCommand("insert into kullanici_diyet (TC, gun ) values (@TC, @gun)");
                command.Parameters.AddWithValue("@TC", lblTC.Text);
                command.Parameters.AddWithValue("@gun", Convert.ToInt32(comboBox1.SelectedItem));
                command.ExecuteNonQuery();
            }
            DiyetTakvimFabrikasi takvimFabrikasi = new DiyetTakvimFabrikasi();
            IDiyetTakvim diyetTakvim = takvimFabrikasi.diyetTakvimNesnesiOlustur(lblHastalik.Text.ToString());
            diyetTakvim.takvimOlustur(lblTC.Text.ToString(), comboBox2.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRapor form = new FormRapor(lblTC.Text);
            form.Show();
            this.Hide();
        }
    }
}
