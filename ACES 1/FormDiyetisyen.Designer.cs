
namespace ACES_1
{
    partial class FormDiyetisyen
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diyetveri_050621DataSet = new ACES_1.diyetveri_090621DataSet();
            this.oguntipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogun_tipTableAdapter = new ACES_1.diyetveri_050621DataSetTableAdapters.ogun_tipTableAdapter();
            this.oguntipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriHastalik = new System.Windows.Forms.Label();
            this.lbl73 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblOgunTip = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDiyet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetveri_050621DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguntipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguntipBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hastalik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Öğün Tipi:";
            // 
            // diyetveri_050621DataSet
            // 
            this.diyetveri_050621DataSet.DataSetName = "diyetveri_050621DataSet";
            this.diyetveri_050621DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oguntipBindingSource
            // 
            this.oguntipBindingSource.DataMember = "ogun_tip";
            this.oguntipBindingSource.DataSource = this.diyetveri_050621DataSet;
            // 
            // ogun_tipTableAdapter
            // 
            this.ogun_tipTableAdapter.ClearBeforeFill = true;
            // 
            // oguntipBindingSource1
            // 
            this.oguntipBindingSource1.DataMember = "ogun_tip";
            this.oguntipBindingSource1.DataSource = this.diyetveri_050621DataSet;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.Location = new System.Drawing.Point(778, 67);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(0, 20);
            this.lblMusteriAd.TabIndex = 6;
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.Location = new System.Drawing.Point(778, 108);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(0, 20);
            this.lblMusteriSoyad.TabIndex = 7;
            // 
            // lblMusteriHastalik
            // 
            this.lblMusteriHastalik.AutoSize = true;
            this.lblMusteriHastalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriHastalik.Location = new System.Drawing.Point(778, 159);
            this.lblMusteriHastalik.Name = "lblMusteriHastalik";
            this.lblMusteriHastalik.Size = new System.Drawing.Size(0, 20);
            this.lblMusteriHastalik.TabIndex = 8;
            // 
            // lbl73
            // 
            this.lbl73.AutoSize = true;
            this.lbl73.Location = new System.Drawing.Point(627, 198);
            this.lbl73.Name = "lbl73";
            this.lbl73.Size = new System.Drawing.Size(30, 17);
            this.lbl73.TabIndex = 15;
            this.lbl73.Text = "TC:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(779, 198);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(0, 17);
            this.lblTC.TabIndex = 15;
            // 
            // lblOgunTip
            // 
            this.lblOgunTip.AutoSize = true;
            this.lblOgunTip.Location = new System.Drawing.Point(782, 242);
            this.lblOgunTip.Name = "lblOgunTip";
            this.lblOgunTip.Size = new System.Drawing.Size(0, 17);
            this.lblOgunTip.TabIndex = 16;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(49, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 44);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(232, 296);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 44);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDiyet
            // 
            this.btnDiyet.Location = new System.Drawing.Point(782, 296);
            this.btnDiyet.Name = "btnDiyet";
            this.btnDiyet.Size = new System.Drawing.Size(123, 44);
            this.btnDiyet.TabIndex = 19;
            this.btnDiyet.Text = "Diyet";
            this.btnDiyet.UseVisualStyleBackColor = true;
            this.btnDiyet.Click += new System.EventHandler(this.btnDiyet_Click);
            // 
            // FormDiyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 369);
            this.Controls.Add(this.btnDiyet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblOgunTip);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lbl73);
            this.Controls.Add(this.lblMusteriHastalik);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDiyetisyen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDiyetisyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diyetveri_050621DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguntipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oguntipBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private diyetveri_090621DataSet diyetveri_050621DataSet;
        private System.Windows.Forms.BindingSource oguntipBindingSource;
        private diyetveri_050621DataSetTableAdapters.ogun_tipTableAdapter ogun_tipTableAdapter;
        private System.Windows.Forms.BindingSource oguntipBindingSource1;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriHastalik;
        private System.Windows.Forms.Label lbl73;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblOgunTip;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDiyet;
    }
}