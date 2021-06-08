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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Data data1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = data1.getAdapter("select * from kullanici where tip LIKE '%Diyetisyen%' ");
            DataTable dtbl1 = new DataTable();
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
        }
        

        private void btnDiyetisyenEkle_Click(object sender, EventArgs e)
        {
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = dt1.getCommand("INSERT INTO kullanici(TC, name, surname, mail, password, address, telNo, yas, boy, kilo, cinsiyet, tip, hastalik) VALUES(@TC, @name, @surname, @mail, @password, @address, @telNo, @yas, @boy, @kilo, @cinsiyet, @tip, @hastalik)     ");
            command.Parameters.AddWithValue("@TC", txtTC.Text);
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@mail", txtMail.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@telNo", txtTelNo.Text);
            command.Parameters.AddWithValue("@yas", txtYas.Text);
            command.Parameters.AddWithValue("@boy", txtBoy.Text);
            command.Parameters.AddWithValue("@kilo", txtKilo.Text);
            command.Parameters.AddWithValue("@cinsiyet", txtCinsiyet.Text);
            command.Parameters.AddWithValue("@tip", "Diyetisyen");
            command.Parameters.AddWithValue("@hastalik","yok");

            command.ExecuteNonQuery();
            DiyetisyenlerTablosuSifirlama();
            temizlik();


        }

        private void btnDiyetisyenSil_Click(object sender, EventArgs e)
        {
            
            Data dt1 = new Data();
            MySqlCommand command = new MySqlCommand();
            command = dt1.getCommand("DELETE FROM kullanici WHERE TC = @TC");
            try
            {
                if(txtTC.Text == null || txtTC.Text == " ")
                {

                }
                else
                {
                    command.Parameters.AddWithValue("@TC", Convert.ToInt32(txtTC.Text));
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
   
            Data data1 = new Data();
            DiyetisyenlerTablosuSifirlama();
            temizlik();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
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
            txtCinsiyet.Text = selectedRow.Cells[10].Value.ToString();
        }

        DataTable DiyetisyenlerTablosuSifirlama()
        {
            Data data1 = new Data();
            MySqlDataAdapter adtr = new MySqlDataAdapter();
            adtr = data1.getAdapter("select * from kullanici where tip LIKE '%Diyetisyen%' ");
            DataTable dtbl1 = new DataTable();
            adtr.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
            return dtbl1;
        }
        void temizlik()
        {
            txtTC.Text = " ";
            txtName.Text = " ";
            txtSurname.Text = " ";
            txtMail.Text = " ";
            txtPassword.Text = " ";
            txtAddress.Text = " ";
            txtTelNo.Text = " ";
            txtYas.Text = " ";
            txtBoy.Text = " ";
            txtKilo.Text = " ";
            txtCinsiyet.Text = " ";
        }

        private void btnDiyetisyenGuncelle_Click(object sender, EventArgs e)
        {
            DiyetisyenlerTablosuSifirlama();
            temizlik();
        }
    }
}
