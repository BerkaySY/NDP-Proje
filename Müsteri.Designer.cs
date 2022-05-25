
namespace NDP_Proje
{
    partial class Müsteri
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
            this.adLabel = new System.Windows.Forms.Label();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.menüyeDön = new System.Windows.Forms.Button();
            this.adresLabel = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.müsteriEkle = new System.Windows.Forms.Button();
            this.satisRapor = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.tcText = new System.Windows.Forms.Label();
            this.müsteriListe = new System.Windows.Forms.Button();
            this.satisYapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.BackColor = System.Drawing.Color.Red;
            this.adLabel.ForeColor = System.Drawing.Color.White;
            this.adLabel.Location = new System.Drawing.Point(50, 120);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(31, 15);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Adı :";
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(87, 117);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(179, 23);
            this.adTextBox.TabIndex = 1;
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.ForeColor = System.Drawing.Color.White;
            this.soyadLabel.Location = new System.Drawing.Point(33, 155);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(48, 15);
            this.soyadLabel.TabIndex = 2;
            this.soyadLabel.Text = "Soyadı :";
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(87, 152);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(179, 23);
            this.soyadTextBox.TabIndex = 3;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.ForeColor = System.Drawing.Color.White;
            this.telLabel.Location = new System.Drawing.Point(27, 189);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(54, 15);
            this.telLabel.TabIndex = 4;
            this.telLabel.Text = "Telefon  :";
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(88, 186);
            this.telTextBox.Mask = "(999) 000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(178, 23);
            this.telTextBox.TabIndex = 5;
            // 
            // menüyeDön
            // 
            this.menüyeDön.BackColor = System.Drawing.Color.Aqua;
            this.menüyeDön.Location = new System.Drawing.Point(12, 355);
            this.menüyeDön.Name = "menüyeDön";
            this.menüyeDön.Size = new System.Drawing.Size(363, 83);
            this.menüyeDön.TabIndex = 10;
            this.menüyeDön.Text = "Menüye Dönmek İçin Tıklayınız";
            this.menüyeDön.UseVisualStyleBackColor = false;
            this.menüyeDön.Click += new System.EventHandler(this.menüyeDön_Click);
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.ForeColor = System.Drawing.Color.White;
            this.adresLabel.Location = new System.Drawing.Point(38, 225);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(43, 15);
            this.adresLabel.TabIndex = 11;
            this.adresLabel.Text = "Adres :";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(87, 222);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(179, 68);
            this.adresTextBox.TabIndex = 12;
            // 
            // müsteriEkle
            // 
            this.müsteriEkle.BackColor = System.Drawing.Color.Yellow;
            this.müsteriEkle.Location = new System.Drawing.Point(316, 88);
            this.müsteriEkle.Name = "müsteriEkle";
            this.müsteriEkle.Size = new System.Drawing.Size(241, 83);
            this.müsteriEkle.TabIndex = 17;
            this.müsteriEkle.Text = "Müşteri Ekle";
            this.müsteriEkle.UseVisualStyleBackColor = false;
            this.müsteriEkle.Click += new System.EventHandler(this.müsteriEkle_Click);
            // 
            // satisRapor
            // 
            this.satisRapor.BackColor = System.Drawing.Color.Lime;
            this.satisRapor.Location = new System.Drawing.Point(425, 355);
            this.satisRapor.Name = "satisRapor";
            this.satisRapor.Size = new System.Drawing.Size(363, 83);
            this.satisRapor.TabIndex = 18;
            this.satisRapor.Text = "Günlük Satış Raporu";
            this.satisRapor.UseVisualStyleBackColor = false;
            this.satisRapor.Click += new System.EventHandler(this.satisRapor_Click);
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Silver;
            this.temizle.Location = new System.Drawing.Point(316, 222);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(241, 83);
            this.temizle.TabIndex = 19;
            this.temizle.Text = "TEMİZLE";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(88, 88);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(178, 23);
            this.tcTextBox.TabIndex = 20;
            // 
            // tcText
            // 
            this.tcText.AutoSize = true;
            this.tcText.ForeColor = System.Drawing.Color.White;
            this.tcText.Location = new System.Drawing.Point(55, 91);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(26, 15);
            this.tcText.TabIndex = 21;
            this.tcText.Text = "TC :";
            // 
            // müsteriListe
            // 
            this.müsteriListe.BackColor = System.Drawing.Color.Fuchsia;
            this.müsteriListe.Location = new System.Drawing.Point(563, 88);
            this.müsteriListe.Name = "müsteriListe";
            this.müsteriListe.Size = new System.Drawing.Size(225, 83);
            this.müsteriListe.TabIndex = 22;
            this.müsteriListe.Text = "Müşteri Listesi";
            this.müsteriListe.UseVisualStyleBackColor = false;
            this.müsteriListe.Click += new System.EventHandler(this.müsteriListe_Click);
            // 
            // satisYapBtn
            // 
            this.satisYapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.satisYapBtn.Location = new System.Drawing.Point(563, 222);
            this.satisYapBtn.Name = "satisYapBtn";
            this.satisYapBtn.Size = new System.Drawing.Size(225, 83);
            this.satisYapBtn.TabIndex = 23;
            this.satisYapBtn.Text = "Satış Yap";
            this.satisYapBtn.UseVisualStyleBackColor = false;
            this.satisYapBtn.Click += new System.EventHandler(this.satisYapBtn_Click);
            // 
            // Müsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.satisYapBtn);
            this.Controls.Add(this.müsteriListe);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.satisRapor);
            this.Controls.Add(this.müsteriEkle);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.adresLabel);
            this.Controls.Add(this.menüyeDön);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.adLabel);
            this.Name = "Müsteri";
            this.Text = "Müşteri İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Müsteri_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.Button menüyeDön;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.Button müsteriEkle;
        private System.Windows.Forms.Button satisRapor;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.Label tcText;
        private System.Windows.Forms.Button müsteriListe;
        private System.Windows.Forms.Button satisYapBtn;
    }
}