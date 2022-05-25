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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");

        bool durum;
        //Ürünün Var olup olmadığını gösteren Fonksiyon
        private void ürünKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from stok where barkodNo=@barkodNo", baglanti);
            komut.Parameters.AddWithValue("@barkodNo", barkodTextBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //Girilen Ürün datada varsa false döndür 
            if (dr.Read())
                durum = false;
            //Girilen Ürün datada yoksa true döndür
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
        
        private void Stok_Load(object sender, EventArgs e)
        {

        }
        //Form Kapatıldığında bütün programı kapatmak için
        private void Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Ürün Ekleme Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            ürünKontrol();
            //Ürün datada Kayıtlı Değilse Ekle
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into stok(barkodNo,rafStogu,depoStogu,ürünAdi,satisFiyati,alisFiyati) values(@barkodNo,@rafStogu,@depoStogu,@ürünAdi,@satisFiyati,@alisFiyati)", baglanti);
                komut.Parameters.AddWithValue("@barkodNo", barkodTextBox.Text);
                komut.Parameters.AddWithValue("@rafStogu", int.Parse(rafTextBox.Text));
                komut.Parameters.AddWithValue("@depoStogu", int.Parse(depoTextBox.Text));
                komut.Parameters.AddWithValue("@ürünAdi", ürünAdTextBox.Text);
                komut.Parameters.AddWithValue("@satisFiyati", double.Parse(satisTextBox.Text));
                komut.Parameters.AddWithValue("@alisFiyati", double.Parse(alisTextBox.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                //Yeniürüngrubundaki değerleri temizlemek için foreach döngüsü
                foreach (Control item in yeniÜrünGrup.Controls)
                {
                    //item textbox ise temizle
                    if (item is TextBox)
                        item.Text = "";
                }
                MessageBox.Show("Ürün Eklendi","Bilgi");
            }
            //Ürün Kayıtlı İse Uyarı Döndür
            else
                MessageBox.Show("Bu Barkod No'ya Sahip Bir Ürün Bulunmakta!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        //ÜrünListeleme Ekranına Götüren Buton
        private void button5_Click(object sender, EventArgs e)
        {
            ÜrünListe listele = new ÜrünListe();
            listele.ShowDialog();
        }
        //Menüye Dönme Butonu
        private void menüyeDön_Click_1(object sender, EventArgs e)
        {
            Form1 menü = new Form1();
            menü.Show();
            this.Hide();
        }
        //Temizle Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            barkodTextBox.Text = "";
            rafTextBox.Text = "";
            depoTextBox.Text = "";
            ürünAdTextBox.Text = "";
            satisTextBox.Text = "";
            alisTextBox.Text = "";
        }
        //Raf Stoğunu Listeleme Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            RafStok rafListele = new RafStok();
            rafListele.ShowDialog();
        }
        //Depo Stoğunu Listeleme Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            DepoStok depoListele = new DepoStok();
            depoListele.ShowDialog();
        }
    }
}
