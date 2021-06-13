
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnrapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HTML Yazdır",
            "JSON Yazdır"});
            this.comboBox1.Location = new System.Drawing.Point(67, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 30);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kullanıcı Bilgisi Üstte ",
            "Diyet Bilgisi Üstte "});
            this.comboBox2.Location = new System.Drawing.Point(272, 89);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 30);
            this.comboBox2.TabIndex = 1;
            // 
            // btnrapor
            // 
            this.btnrapor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrapor.Location = new System.Drawing.Point(157, 165);
            this.btnrapor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrapor.Name = "btnrapor";
            this.btnrapor.Size = new System.Drawing.Size(206, 55);
            this.btnrapor.TabIndex = 2;
            this.btnrapor.Text = "Raporu Hazırla";
            this.btnrapor.UseVisualStyleBackColor = true;
            this.btnrapor.Click += new System.EventHandler(this.btnrapor_Click);
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 289);
            this.Controls.Add(this.btnrapor);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRapor";
            this.Text = "FormRapor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnrapor;
    }
}