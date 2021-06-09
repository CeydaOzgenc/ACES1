
namespace ACES_1
{
    partial class FormMüşteri
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
            this.lblTC = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(28, 36);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(30, 17);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(28, 103);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyad:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(28, 139);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(29, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Şifre:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(239, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 17);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Adres:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(239, 68);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(36, 17);
            this.lblYas.TabIndex = 6;
            this.lblYas.Text = "Yaş:";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(239, 103);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(36, 17);
            this.lblBoy.TabIndex = 6;
            this.lblBoy.Text = "Boy:";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(240, 139);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(35, 17);
            this.lblKilo.TabIndex = 6;
            this.lblKilo.Text = "Kilo:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(239, 174);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(61, 17);
            this.lblCinsiyet.TabIndex = 6;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMüşteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTC);
            this.Name = "FormMüşteri";
            this.Text = "FormMüşteri";
            this.Load += new System.EventHandler(this.FormMüşteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Button button1;
    }
}