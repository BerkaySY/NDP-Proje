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
using System.IO;
using System.Data.SqlClient;
namespace NDP_Proje
{
    public partial class Müsteri : Form
    {
        public Müsteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");

        bool durum;
        //SQL Tablosunda girilen TC'ye sahip müşteriyi bulmak için yazılan fonksiyon
        private void tcKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //Girilen TC'nin tabloda olup olmama durumuna göre true false döndüren if-else bloğu
            if (dr.Read())
                durum = false;
            else
                durum = true;

            baglanti.Close();
        }
        //Menüye Dönme Butonu
        private void menüyeDön_Click(object sender, EventArgs e)
        {
            Form1 menü = new Form1();
            menü.Show();
            this.Hide();
        }
        //Form Kapatıldığında Bütün Sistemi Kapatmak için
        private void Müsteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Temizle Butonu
        private void temizle_Click(object sender, EventArgs e)
        {
            adTextBox.Text = "";
            soyadTextBox.Text = "";
            telTextBox.Text = "";
            adresTextBox.Text = "";
            
        }
        //Müşteri Ekleme Butonu
        private void müsteriEkle_Click(object sender, EventArgs e)
        {
            tcKontrol();
            //Girilen TC'nin datada olup olmama durumuna göre ekleyen veya uyarı döndüren if-else bloğu
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into müşteri(tc,ad,soyad,telefon,adres) values(@tc,@ad,@soyad,@telefon,@adres)",baglanti);
                komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
                komut.Parameters.AddWithValue("@ad", adTextBox.Text);
                komut.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
                komut.Parameters.AddWithValue("@telefon", telTextBox.Text);
                komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Eklendi");
            }
            else
            {
                MessageBox.Show("Bu TC'ye Sahip Bir Müşteri Zaten Var!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }

        

        // Müşteri Listeleme Ekranına Götüren Buton
        private void müsteriListe_Click(object sender, EventArgs e)
        {
            MüsteriListeleme listele = new MüsteriListeleme();
            listele.ShowDialog();
        }
        // Satış yapma ekranına götüren buton
        private void satisYapBtn_Click(object sender, EventArgs e)
        {
            Satış satisYap = new Satış();
            satisYap.ShowDialog();
        }
        //Satış Raporunu Ekrana getiren buton
        private void satisRapor_Click(object sender, EventArgs e)
        {
            SatışRaporu satisRaporla = new SatışRaporu();
            satisRaporla.ShowDialog();
        }
    }
}
