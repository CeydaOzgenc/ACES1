
namespace ACES_1
{
    partial class FormRapor
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
            this.cmbFormatlar = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnrapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFormatlar
            // 
            this.cmbFormatlar.FormattingEnabled = true;
            this.cmbFormatlar.Items.AddRange(new object[] {
            "HTML Yazdır",
            "JSON Yazdır"});
            this.cmbFormatlar.Location = new System.Drawing.Point(67, 89);
            this.cmbFormatlar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFormatlar.Name = "cmbFormatlar";
            this.cmbFormatlar.Size = new System.Drawing.Size(165, 30);
            this.cmbFormatlar.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kullanıcı Bilgisi Üstte ",
            "Diyet Bilgisi Üstte "});
            this.comboBox2.Location = new System.Drawing.Point(272, 89);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 30);
            this.comboBox2.TabIndex = 1;
            // 
            // btnrapor
            // 
            this.btnrapor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnrapor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrapor.Location = new System.Drawing.Point(157, 165);
            this.btnrapor.Margin = new System.Windows.Forms.Padding(4);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(206, 55);
            this.btnrapor.TabIndex = 2;
            this.btnrapor.Text = "Raporu Hazırla";
            this.btnrapor.UseVisualStyleBackColor = false;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rapor Hazırlama Paneli";
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(527, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrapor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbFormatlar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRapor";
            this.Text = "FormRapor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFormatlar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnrapor;
        private System.Windows.Forms.Label label1;
    }
}