
namespace ACES_1
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.txtCinsiyet = new System.Windows.Forms.TextBox();
            this.btnDiyetisyenEkle = new System.Windows.Forms.Button();
            this.btnDiyetisyenSil = new System.Windows.Forms.Button();
            this.btnDiyetisyenGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(55, 274);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(46, 25);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(58, 311);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(26, 345);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(75, 25);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(47, 382);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(43, 416);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 25);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(31, 452);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 25);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Adres:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.Location = new System.Drawing.Point(273, 279);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(76, 25);
            this.lblTelNo.TabIndex = 7;
            this.lblTelNo.Text = "Tel No:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(297, 311);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(52, 25);
            this.lblYas.TabIndex = 8;
            this.lblYas.Text = "Yaş:";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoy.Location = new System.Drawing.Point(297, 343);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(52, 25);
            this.lblBoy.TabIndex = 9;
            this.lblBoy.Text = "Boy:";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKilo.Location = new System.Drawing.Point(298, 375);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(51, 25);
            this.lblKilo.TabIndex = 10;
            this.lblKilo.Text = "Kilo:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(261, 407);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lblCinsiyet.TabIndex = 9;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTC.Location = new System.Drawing.Point(107, 273);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(135, 26);
            this.txtTC.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(107, 309);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 26);
            this.txtName.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSurname.Location = new System.Drawing.Point(107, 345);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 26);
            this.txtSurname.TabIndex = 13;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMail.Location = new System.Drawing.Point(107, 381);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(135, 26);
            this.txtMail.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(107, 417);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 26);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(107, 453);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(135, 26);
            this.txtAddress.TabIndex = 16;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTelNo.Location = new System.Drawing.Point(355, 276);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(135, 26);
            this.txtTelNo.TabIndex = 17;
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtYas.Location = new System.Drawing.Point(355, 308);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(135, 26);
            this.txtYas.TabIndex = 18;
            // 
            // txtBoy
            // 
            this.txtBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoy.Location = new System.Drawing.Point(355, 340);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(135, 26);
            this.txtBoy.TabIndex = 19;
            // 
            // txtKilo
            // 
            this.txtKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKilo.Location = new System.Drawing.Point(355, 372);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(135, 26);
            this.txtKilo.TabIndex = 20;
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCinsiyet.Location = new System.Drawing.Point(355, 404);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(135, 26);
            this.txtCinsiyet.TabIndex = 21;
            // 
            // btnDiyetisyenEkle
            // 
            this.btnDiyetisyenEkle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDiyetisyenEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiyetisyenEkle.Location = new System.Drawing.Point(534, 277);
            this.btnDiyetisyenEkle.Name = "btnDiyetisyenEkle";
            this.btnDiyetisyenEkle.Size = new System.Drawing.Size(236, 48);
            this.btnDiyetisyenEkle.TabIndex = 22;
            this.btnDiyetisyenEkle.Text = "EKLE";
            this.btnDiyetisyenEkle.UseVisualStyleBackColor = false;
            this.btnDiyetisyenEkle.Click += new System.EventHandler(this.btnDiyetisyenEkle_Click);
            // 
            // btnDiyetisyenSil
            // 
            this.btnDiyetisyenSil.BackColor = System.Drawing.Color.Red;
            this.btnDiyetisyenSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnDiyetisyenSil.Location = new System.Drawing.Point(534, 345);
            this.btnDiyetisyenSil.Name = "btnDiyetisyenSil";
            this.btnDiyetisyenSil.Size = new System.Drawing.Size(236, 48);
            this.btnDiyetisyenSil.TabIndex = 23;
            this.btnDiyetisyenSil.Text = "Sil";
            this.btnDiyetisyenSil.UseVisualStyleBackColor = false;
            this.btnDiyetisyenSil.Click += new System.EventHandler(this.btnDiyetisyenSil_Click);
            // 
            // btnDiyetisyenGuncelle
            // 
            this.btnDiyetisyenGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnDiyetisyenGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnDiyetisyenGuncelle.Location = new System.Drawing.Point(534, 408);
            this.btnDiyetisyenGuncelle.Name = "btnDiyetisyenGuncelle";
            this.btnDiyetisyenGuncelle.Size = new System.Drawing.Size(236, 48);
            this.btnDiyetisyenGuncelle.TabIndex = 24;
            this.btnDiyetisyenGuncelle.Text = "Güncelle";
            this.btnDiyetisyenGuncelle.UseVisualStyleBackColor = false;
            this.btnDiyetisyenGuncelle.Click += new System.EventHandler(this.btnDiyetisyenGuncelle_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnDiyetisyenGuncelle);
            this.Controls.Add(this.btnDiyetisyenSil);
            this.Controls.Add(this.btnDiyetisyenEkle);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.TextBox txtCinsiyet;
        private System.Windows.Forms.Button btnDiyetisyenEkle;
        private System.Windows.Forms.Button btnDiyetisyenSil;
        private System.Windows.Forms.Button btnDiyetisyenGuncelle;
    }
}