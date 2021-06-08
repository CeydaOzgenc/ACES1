
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
            this.diyetveri_050621DataSet = new ACES_1.diyetveri_050621DataSet();
            this.oguntipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogun_tipTableAdapter = new ACES_1.diyetveri_050621DataSetTableAdapters.ogun_tipTableAdapter();
            this.oguntipBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbOgunTip = new System.Windows.Forms.ComboBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriHastalik = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(604, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label4.Location = new System.Drawing.Point(627, 204);
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
            // cmbOgunTip
            // 
            this.cmbOgunTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgunTip.FormattingEnabled = true;
            this.cmbOgunTip.Location = new System.Drawing.Point(782, 197);
            this.cmbOgunTip.Name = "cmbOgunTip";
            this.cmbOgunTip.Size = new System.Drawing.Size(121, 28);
            this.cmbOgunTip.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diyet Gün Sayısı";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diyet Yöntemi";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 373);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // FormDiyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOgunTip);
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
        private diyetveri_050621DataSet diyetveri_050621DataSet;
        private System.Windows.Forms.BindingSource oguntipBindingSource;
        private diyetveri_050621DataSetTableAdapters.ogun_tipTableAdapter ogun_tipTableAdapter;
        private System.Windows.Forms.BindingSource oguntipBindingSource1;
        private System.Windows.Forms.ComboBox cmbOgunTip;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriHastalik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}