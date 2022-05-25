/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2021-2022 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: Proje 1
** ÖĞRENCİ ADI............: BERKAY SARAY
** ÖĞRENCİ NUMARASI.......: B211210040
** DERSİN ALINDIĞI GRUP...: 1.ÖĞRETİM A GRUBU
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NDP_Proje
{
    public partial class Tedarikçi : Form
    {
        public Tedarikçi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");

        bool durum;
        //Tedarikçinin Kayıtlı Olup Olmadığını gösteren Fonksiyon
        private void firmaNoKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tedarikçi where firmaNo=@firmaNo", baglanti);
            komut.Parameters.AddWithValue("@firmaNo", firmaNoTextBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //Girilen Tedarikçi Kayıtlı ise false döndür
            if (dr.Read())
                durum = false;
            //Girilen Tedarikçi Kayıtlı değilse true döndür
            else
                durum = true;

            baglanti.Close();
        }
        //Menüye Dön Butonu
        private void menüyeDön_Click(object sender, EventArgs e)
        {
            Form1 menü = new Form1();
            menü.Show();
            this.Hide();
        }
        //Temizle Butonu
        private void temizleBtn_Click(object sender, EventArgs e)
        {
            firmaNoTextBox.Text = "";
            firmaAdTextBox.Text = "";
            telTextBox.Text = "";
            emailTextBox.Text = "";
            adresTextBox.Text = "";

        }
        //Tedarikçi Ekle Butonu
        private void tedarikciEkleBtn_Click(object sender, EventArgs e)
        {
            firmaNoKontrol();
            //Girilen Tedarikçi datada kayıtlı değilse ekle
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tedarikçi(firmaNo,firmaAd,telefon,email,adres) values(@firmaNo,@firmaAd,@telefon,@email,@adres)", baglanti);
                komut.Parameters.AddWithValue("@firmaAd", firmaAdTextBox.Text);
                komut.Parameters.AddWithValue("@firmaNo", firmaNoTextBox.Text);
                komut.Parameters.AddWithValue("@telefon", telTextBox.Text);
                komut.Parameters.AddWithValue("@email", emailTextBox.Text);
                komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tedarikçi Eklendi");
            }
            //Girilen Tedarikçi datada kayıtlı ise uyarı mesajı döndür
            else
            {
                MessageBox.Show("Bu Firma No'ya Sahip Bir Tedarikçi Zaten Var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Tedarikçi Listeleme Butonu
        private void tedarikciListeleBtn_Click(object sender, EventArgs e)
        {
            TedarikçiListeleme listele = new TedarikçiListeleme();
            listele.ShowDialog();
        }
        //Sipariş Et Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Sipariş siparisEt = new Sipariş();
            siparisEt.ShowDialog();

        }
        //Form Kapatılırsa Bütün Sistemi Kapat
        private void Tedarikçi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Sipariş Listeleme Butonu
        private void müsteriRapor_Click(object sender, EventArgs e)
        {
            SiparişListesi siparisListele = new SiparişListesi();
            siparisListele.ShowDialog();
        }
    }
}
