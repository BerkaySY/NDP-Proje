
namespace NDP_Proje
{
    partial class Sipariş
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
            this.siparisEtBtn = new System.Windows.Forms.Button();
            this.firmaNoTxtBox = new System.Windows.Forms.TextBox();
            this.firmaAdTxtBox = new System.Windows.Forms.TextBox();
            this.telefonTxtBox = new System.Windows.Forms.TextBox();
            this.barkodNoTxtBox = new System.Windows.Forms.TextBox();
            this.ürünAdTxtBox = new System.Windows.Forms.TextBox();
            this.tedarikciBilgi = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firmaNoLbl = new System.Windows.Forms.Label();
            this.ürünBilgi = new System.Windows.Forms.GroupBox();
            this.toplamFiyatLbl = new System.Windows.Forms.Label();
            this.alisFiyatLbl = new System.Windows.Forms.Label();
            this.miktarLbl = new System.Windows.Forms.Label();
            this.ürünAdLbl = new System.Windows.Forms.Label();
            this.barkodNoLbl = new System.Windows.Forms.Label();
            this.toplamFiyatTxtBox = new System.Windows.Forms.TextBox();
            this.alisFiyatTxtBox = new System.Windows.Forms.TextBox();
            this.miktarTxtBox = new System.Windows.Forms.TextBox();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.tedarikciBilgi.SuspendLayout();
            this.ürünBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisEtBtn
            // 
            this.siparisEtBtn.BackColor = System.Drawing.Color.Lime;
            this.siparisEtBtn.Location = new System.Drawing.Point(12, 382);
            this.siparisEtBtn.Name = "siparisEtBtn";
            this.siparisEtBtn.Size = new System.Drawing.Size(158, 46);
            this.siparisEtBtn.TabIndex = 0;
            this.siparisEtBtn.Text = "Sipariş Ver";
            this.siparisEtBtn.UseVisualStyleBackColor = false;
            this.siparisEtBtn.Click += new System.EventHandler(this.siparisEtBtn_Click);
            // 
            // firmaNoTxtBox
            // 
            this.firmaNoTxtBox.Location = new System.Drawing.Point(87, 22);
            this.firmaNoTxtBox.Name = "firmaNoTxtBox";
            this.firmaNoTxtBox.Size = new System.Drawing.Size(206, 23);
            this.firmaNoTxtBox.TabIndex = 1;
            this.firmaNoTxtBox.TextChanged += new System.EventHandler(this.firmaNoTxtBox_TextChanged);
            // 
            // firmaAdTxtBox
            // 
            this.firmaAdTxtBox.Location = new System.Drawing.Point(87, 66);
            this.firmaAdTxtBox.Name = "firmaAdTxtBox";
            this.firmaAdTxtBox.ReadOnly = true;
            this.firmaAdTxtBox.Size = new System.Drawing.Size(206, 23);
            this.firmaAdTxtBox.TabIndex = 2;
            // 
            // telefonTxtBox
            // 
            this.telefonTxtBox.Location = new System.Drawing.Point(87, 106);
            this.telefonTxtBox.Name = "telefonTxtBox";
            this.telefonTxtBox.ReadOnly = true;
            this.telefonTxtBox.Size = new System.Drawing.Size(206, 23);
            this.telefonTxtBox.TabIndex = 3;
            // 
            // barkodNoTxtBox
            // 
            this.barkodNoTxtBox.Location = new System.Drawing.Point(87, 22);
            this.barkodNoTxtBox.Name = "barkodNoTxtBox";
            this.barkodNoTxtBox.Size = new System.Drawing.Size(206, 23);
            this.barkodNoTxtBox.TabIndex = 4;
            this.barkodNoTxtBox.TextChanged += new System.EventHandler(this.barkodNoTxtBox_TextChanged);
            // 
            // ürünAdTxtBox
            // 
            this.ürünAdTxtBox.Location = new System.Drawing.Point(87, 60);
            this.ürünAdTxtBox.Name = "ürünAdTxtBox";
            this.ürünAdTxtBox.ReadOnly = true;
            this.ürünAdTxtBox.Size = new System.Drawing.Size(206, 23);
            this.ürünAdTxtBox.TabIndex = 5;
            // 
            // tedarikciBilgi
            // 
            this.tedarikciBilgi.Controls.Add(this.label3);
            this.tedarikciBilgi.Controls.Add(this.label2);
            this.tedarikciBilgi.Controls.Add(this.firmaNoLbl);
            this.tedarikciBilgi.Controls.Add(this.telefonTxtBox);
            this.tedarikciBilgi.Controls.Add(this.firmaAdTxtBox);
            this.tedarikciBilgi.Controls.Add(this.firmaNoTxtBox);
            this.tedarikciBilgi.Location = new System.Drawing.Point(24, 21);
            this.tedarikciBilgi.Name = "tedarikciBilgi";
            this.tedarikciBilgi.Size = new System.Drawing.Size(315, 145);
            this.tedarikciBilgi.TabIndex = 6;
            this.tedarikciBilgi.TabStop = false;
            this.tedarikciBilgi.Text = "Tedarikçi Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Firma Ad :";
            // 
            // firmaNoLbl
            // 
            this.firmaNoLbl.AutoSize = true;
            this.firmaNoLbl.Location = new System.Drawing.Point(18, 25);
            this.firmaNoLbl.Name = "firmaNoLbl";
            this.firmaNoLbl.Size = new System.Drawing.Size(62, 15);
            this.firmaNoLbl.TabIndex = 4;
            this.firmaNoLbl.Text = "Firma No :";
            // 
            // ürünBilgi
            // 
            this.ürünBilgi.Controls.Add(this.toplamFiyatLbl);
            this.ürünBilgi.Controls.Add(this.alisFiyatLbl);
            this.ürünBilgi.Controls.Add(this.miktarLbl);
            this.ürünBilgi.Controls.Add(this.ürünAdLbl);
            this.ürünBilgi.Controls.Add(this.barkodNoLbl);
            this.ürünBilgi.Controls.Add(this.toplamFiyatTxtBox);
            this.ürünBilgi.Controls.Add(this.alisFiyatTxtBox);
            this.ürünBilgi.Controls.Add(this.miktarTxtBox);
            this.ürünBilgi.Controls.Add(this.ürünAdTxtBox);
            this.ürünBilgi.Controls.Add(this.barkodNoTxtBox);
            this.ürünBilgi.Location = new System.Drawing.Point(24, 172);
            this.ürünBilgi.Name = "ürünBilgi";
            this.ürünBilgi.Size = new System.Drawing.Size(315, 204);
            this.ürünBilgi.TabIndex = 7;
            this.ürünBilgi.TabStop = false;
            this.ürünBilgi.Text = "Ürün Bilgileri";
            // 
            // toplamFiyatLbl
            // 
            this.toplamFiyatLbl.AutoSize = true;
            this.toplamFiyatLbl.Location = new System.Drawing.Point(6, 178);
            this.toplamFiyatLbl.Name = "toplamFiyatLbl";
            this.toplamFiyatLbl.Size = new System.Drawing.Size(80, 15);
            this.toplamFiyatLbl.TabIndex = 13;
            this.toplamFiyatLbl.Text = "Toplam Fiyat :";
            // 
            // alisFiyatLbl
            // 
            this.alisFiyatLbl.AutoSize = true;
            this.alisFiyatLbl.Location = new System.Drawing.Point(18, 140);
            this.alisFiyatLbl.Name = "alisFiyatLbl";
            this.alisFiyatLbl.Size = new System.Drawing.Size(63, 15);
            this.alisFiyatLbl.TabIndex = 12;
            this.alisFiyatLbl.Text = "Alış Fiyatı :";
            // 
            // miktarLbl
            // 
            this.miktarLbl.AutoSize = true;
            this.miktarLbl.Location = new System.Drawing.Point(27, 101);
            this.miktarLbl.Name = "miktarLbl";
            this.miktarLbl.Size = new System.Drawing.Size(47, 15);
            this.miktarLbl.TabIndex = 11;
            this.miktarLbl.Text = "Miktar :";
            // 
            // ürünAdLbl
            // 
            this.ürünAdLbl.AutoSize = true;
            this.ürünAdLbl.Location = new System.Drawing.Point(18, 63);
            this.ürünAdLbl.Name = "ürünAdLbl";
            this.ürünAdLbl.Size = new System.Drawing.Size(60, 15);
            this.ürünAdLbl.TabIndex = 10;
            this.ürünAdLbl.Text = "Ürün Adı :";
            // 
            // barkodNoLbl
            // 
            this.barkodNoLbl.AutoSize = true;
            this.barkodNoLbl.Location = new System.Drawing.Point(10, 25);
            this.barkodNoLbl.Name = "barkodNoLbl";
            this.barkodNoLbl.Size = new System.Drawing.Size(69, 15);
            this.barkodNoLbl.TabIndex = 9;
            this.barkodNoLbl.Text = "Barkod No :";
            // 
            // toplamFiyatTxtBox
            // 
            this.toplamFiyatTxtBox.Location = new System.Drawing.Point(87, 175);
            this.toplamFiyatTxtBox.Name = "toplamFiyatTxtBox";
            this.toplamFiyatTxtBox.ReadOnly = true;
            this.toplamFiyatTxtBox.Size = new System.Drawing.Size(206, 23);
            this.toplamFiyatTxtBox.TabIndex = 8;
            this.toplamFiyatTxtBox.Text = "0,00";
            this.toplamFiyatTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alisFiyatTxtBox
            // 
            this.alisFiyatTxtBox.Location = new System.Drawing.Point(87, 137);
            this.alisFiyatTxtBox.Name = "alisFiyatTxtBox";
            this.alisFiyatTxtBox.ReadOnly = true;
            this.alisFiyatTxtBox.Size = new System.Drawing.Size(206, 23);
            this.alisFiyatTxtBox.TabIndex = 7;
            this.alisFiyatTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alisFiyatTxtBox.TextChanged += new System.EventHandler(this.alisFiyatTxtBox_TextChanged);
            // 
            // miktarTxtBox
            // 
            this.miktarTxtBox.Location = new System.Drawing.Point(87, 98);
            this.miktarTxtBox.Name = "miktarTxtBox";
            this.miktarTxtBox.Size = new System.Drawing.Size(206, 23);
            this.miktarTxtBox.TabIndex = 6;
            this.miktarTxtBox.Text = "1";
            this.miktarTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.miktarTxtBox.TextChanged += new System.EventHandler(this.miktarTxtBox_TextChanged);
            // 
            // temizleBtn
            // 
            this.temizleBtn.BackColor = System.Drawing.Color.Red;
            this.temizleBtn.Location = new System.Drawing.Point(181, 382);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(158, 46);
            this.temizleBtn.TabIndex = 8;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = false;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // Sipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(351, 440);
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.ürünBilgi);
            this.Controls.Add(this.tedarikciBilgi);
            this.Controls.Add(this.siparisEtBtn);
            this.Name = "Sipariş";
            this.Text = "Sipariş";
            this.tedarikciBilgi.ResumeLayout(false);
            this.tedarikciBilgi.PerformLayout();
            this.ürünBilgi.ResumeLayout(false);
            this.ürünBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparisEtBtn;
        private System.Windows.Forms.TextBox firmaNoTxtBox;
        private System.Windows.Forms.TextBox firmaAdTxtBox;
        private System.Windows.Forms.TextBox telefonTxtBox;
        private System.Windows.Forms.TextBox barkodNoTxtBox;
        private System.Windows.Forms.TextBox ürünAdTxtBox;
        private System.Windows.Forms.GroupBox tedarikciBilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firmaNoLbl;
        private System.Windows.Forms.GroupBox ürünBilgi;
        private System.Windows.Forms.Label toplamFiyatLbl;
        private System.Windows.Forms.Label alisFiyatLbl;
        private System.Windows.Forms.Label miktarLbl;
        private System.Windows.Forms.Label ürünAdLbl;
        private System.Windows.Forms.Label barkodNoLbl;
        private System.Windows.Forms.TextBox toplamFiyatTxtBox;
        private System.Windows.Forms.TextBox alisFiyatTxtBox;
        private System.Windows.Forms.TextBox miktarTxtBox;
        private System.Windows.Forms.Button temizleBtn;
    }
}