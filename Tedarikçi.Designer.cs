
namespace NDP_Proje
{
    partial class Tedarikçi
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
            this.firmaNoTextBox = new System.Windows.Forms.TextBox();
            this.firmaAdTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.firmaNoLbl = new System.Windows.Forms.Label();
            this.firmaAdLbl = new System.Windows.Forms.Label();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.adresLbl = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.menüyeDön = new System.Windows.Forms.Button();
            this.müsteriRapor = new System.Windows.Forms.Button();
            this.tedarikciEkleBtn = new System.Windows.Forms.Button();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.tedarikciListeleBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firmaNoTextBox
            // 
            this.firmaNoTextBox.Location = new System.Drawing.Point(84, 25);
            this.firmaNoTextBox.Name = "firmaNoTextBox";
            this.firmaNoTextBox.Size = new System.Drawing.Size(137, 23);
            this.firmaNoTextBox.TabIndex = 0;
            // 
            // firmaAdTextBox
            // 
            this.firmaAdTextBox.Location = new System.Drawing.Point(84, 74);
            this.firmaAdTextBox.Name = "firmaAdTextBox";
            this.firmaAdTextBox.Size = new System.Drawing.Size(137, 23);
            this.firmaAdTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(84, 169);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(137, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(84, 218);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(137, 78);
            this.adresTextBox.TabIndex = 4;
            // 
            // firmaNoLbl
            // 
            this.firmaNoLbl.AutoSize = true;
            this.firmaNoLbl.Location = new System.Drawing.Point(12, 28);
            this.firmaNoLbl.Name = "firmaNoLbl";
            this.firmaNoLbl.Size = new System.Drawing.Size(62, 15);
            this.firmaNoLbl.TabIndex = 5;
            this.firmaNoLbl.Text = "Firma No :";
            // 
            // firmaAdLbl
            // 
            this.firmaAdLbl.AutoSize = true;
            this.firmaAdLbl.Location = new System.Drawing.Point(10, 77);
            this.firmaAdLbl.Name = "firmaAdLbl";
            this.firmaAdLbl.Size = new System.Drawing.Size(64, 15);
            this.firmaAdLbl.TabIndex = 6;
            this.firmaAdLbl.Text = "Firma Adı :";
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.Location = new System.Drawing.Point(20, 121);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(54, 15);
            this.telefonLbl.TabIndex = 7;
            this.telefonLbl.Text = "Telefon : ";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(32, 172);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 15);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email :";
            // 
            // adresLbl
            // 
            this.adresLbl.AutoSize = true;
            this.adresLbl.Location = new System.Drawing.Point(28, 221);
            this.adresLbl.Name = "adresLbl";
            this.adresLbl.Size = new System.Drawing.Size(46, 15);
            this.adresLbl.TabIndex = 9;
            this.adresLbl.Text = "Adres : ";
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(84, 118);
            this.telTextBox.Mask = "(999) 000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(137, 23);
            this.telTextBox.TabIndex = 10;
            // 
            // menüyeDön
            // 
            this.menüyeDön.BackColor = System.Drawing.Color.Aqua;
            this.menüyeDön.Location = new System.Drawing.Point(12, 355);
            this.menüyeDön.Name = "menüyeDön";
            this.menüyeDön.Size = new System.Drawing.Size(363, 83);
            this.menüyeDön.TabIndex = 11;
            this.menüyeDön.Text = "Menüye Dönmek İçin Tıklayınız";
            this.menüyeDön.UseVisualStyleBackColor = false;
            this.menüyeDön.Click += new System.EventHandler(this.menüyeDön_Click);
            // 
            // müsteriRapor
            // 
            this.müsteriRapor.BackColor = System.Drawing.Color.Lime;
            this.müsteriRapor.Location = new System.Drawing.Point(425, 355);
            this.müsteriRapor.Name = "müsteriRapor";
            this.müsteriRapor.Size = new System.Drawing.Size(363, 83);
            this.müsteriRapor.TabIndex = 19;
            this.müsteriRapor.Text = "Günlük Sipariş Listesi";
            this.müsteriRapor.UseVisualStyleBackColor = false;
            this.müsteriRapor.Click += new System.EventHandler(this.müsteriRapor_Click);
            // 
            // tedarikciEkleBtn
            // 
            this.tedarikciEkleBtn.BackColor = System.Drawing.Color.Yellow;
            this.tedarikciEkleBtn.Location = new System.Drawing.Point(284, 74);
            this.tedarikciEkleBtn.Name = "tedarikciEkleBtn";
            this.tedarikciEkleBtn.Size = new System.Drawing.Size(241, 83);
            this.tedarikciEkleBtn.TabIndex = 20;
            this.tedarikciEkleBtn.Text = "Tedarikçi Ekle";
            this.tedarikciEkleBtn.UseVisualStyleBackColor = false;
            this.tedarikciEkleBtn.Click += new System.EventHandler(this.tedarikciEkleBtn_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.BackColor = System.Drawing.Color.Silver;
            this.temizleBtn.Location = new System.Drawing.Point(284, 187);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(241, 83);
            this.temizleBtn.TabIndex = 21;
            this.temizleBtn.Text = "TEMİZLE";
            this.temizleBtn.UseVisualStyleBackColor = false;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // tedarikciListeleBtn
            // 
            this.tedarikciListeleBtn.BackColor = System.Drawing.Color.DeepPink;
            this.tedarikciListeleBtn.Location = new System.Drawing.Point(549, 74);
            this.tedarikciListeleBtn.Name = "tedarikciListeleBtn";
            this.tedarikciListeleBtn.Size = new System.Drawing.Size(239, 83);
            this.tedarikciListeleBtn.TabIndex = 23;
            this.tedarikciListeleBtn.Text = "Tedarikçi Listesi";
            this.tedarikciListeleBtn.UseVisualStyleBackColor = false;
            this.tedarikciListeleBtn.Click += new System.EventHandler(this.tedarikciListeleBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(547, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 83);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sipariş Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tedarikçi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tedarikciListeleBtn);
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.tedarikciEkleBtn);
            this.Controls.Add(this.müsteriRapor);
            this.Controls.Add(this.menüyeDön);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.adresLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.telefonLbl);
            this.Controls.Add(this.firmaAdLbl);
            this.Controls.Add(this.firmaNoLbl);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.firmaAdTextBox);
            this.Controls.Add(this.firmaNoTextBox);
            this.Name = "Tedarikçi";
            this.Text = "Tedarikçi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tedarikçi_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firmaNoTextBox;
        private System.Windows.Forms.TextBox firmaAdTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Label firmaNoLbl;
        private System.Windows.Forms.Label firmaAdLbl;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label adresLbl;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.Button menüyeDön;
        private System.Windows.Forms.Button müsteriRapor;
        private System.Windows.Forms.Button tedarikciEkleBtn;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.Button tedarikciListeleBtn;
        private System.Windows.Forms.Button button1;
    }
}