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
    public partial class Sipariş : Form
    {
        public Sipariş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");

        
        
        // barkod no textbox'ına değer girildiğinde yap
        private void barkodNoTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Barkod No textbox'ı temizlendiğinde ürün bilgilerini temizle
            if(barkodNoTxtBox.Text == "")
            {
                //İtem kontrolü için foreach döngüsü
                foreach  (Control item in ürünBilgi.Controls)
                {
                   //İtem Textboxsa
                    if (item is TextBox)
                    {
                        //item miktartextboxsa değeri 1 yap
                        if (item == miktarTxtBox)
                            item.Text = "1";
                        // İtem Toplam Fiyatsa değeri 0.00 yap
                        else if (item == toplamFiyatTxtBox)
                            item.Text = "0,00";
                        // 2'si de değilse tamamen temizle
                        else
                            item.Text = "";
                        
                    }
                        
                }
                
            }
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select barkodNo,ürünAdi,alisFiyati from stok where barkodNo like '" + barkodNoTxtBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            // komutttaki datayı okuduğu sürece 
            while (read.Read())
            {
                ürünAdTxtBox.Text = read["ürünAdi"].ToString();
                alisFiyatTxtBox.Text = read["alisFiyati"].ToString();
            }
            baglanti.Close();
        }
        //Sipariş Etme Butonu
        private void siparisEtBtn_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sipariş(firmaNo,firmaAd,telefon,barkodNo,ürünAdı,miktar,alisFiyati,toplamfiyat,tarih) values(@firmaNo,@firmaAd,@telefon,@barkodNo,@ürünAdı,@miktar,@alisFiyati,@toplamfiyat,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@firmaNo", firmaNoTxtBox.Text);
            komut.Parameters.AddWithValue("@firmaAd", firmaAdTxtBox.Text);
            komut.Parameters.AddWithValue("@telefon", telefonTxtBox.Text);
            komut.Parameters.AddWithValue("@barkodNo", barkodNoTxtBox.Text);
            komut.Parameters.AddWithValue("@ürünAdı", ürünAdTxtBox.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(miktarTxtBox.Text));
            komut.Parameters.AddWithValue("@alisFiyati", double.Parse(alisFiyatTxtBox.Text));
            komut.Parameters.AddWithValue("@toplamFiyat", double.Parse(toplamFiyatTxtBox.Text));
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("d"));
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutStok = new SqlCommand("update stok set depoStogu = depoStogu +'" + int.Parse(miktarTxtBox.Text) + "' where barkodNo='" + barkodNoTxtBox.Text + "'", baglanti);
            komutStok.ExecuteNonQuery();
            baglanti.Close();

            
            
            MessageBox.Show("Siparişiniz Sipariş Listesine Eklendi!", "Bilgi");
        }
        // Miktartextbox değişirse toplamfiyatın değerini işlemin sonucu yap
        private void miktarTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Hata vermemesi için try-catch kullanıldı
            try
            {
                toplamFiyatTxtBox.Text = (double.Parse(miktarTxtBox.Text) * double.Parse(alisFiyatTxtBox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }
        //Temizle Butonu
        private void temizleBtn_Click(object sender, EventArgs e)
        {
            //Ürün Bilgi Groupbox'ındaki İtemlerin ne olduğunu anlamak için foreach döngüsü
            foreach (Control item in ürünBilgi.Controls)
            {
                //İtem textboxsa
                if (item is TextBox)
                {
                    //item miktartextboxa eşitse değerini 1 yap
                    if (item == miktarTxtBox)
                        item.Text = "1";
                    //item toplamFiyatTextBox'a eşitse değerini 0.00 yap
                    else if (item == toplamFiyatTxtBox)
                        item.Text = "0,00";
                    //2'si de değilse tamamen temizle
                    else
                        item.Text = "";
                }
            }
            //Tedarikçi Bilgi Groupbox'ındaki İtemlerin ne olduğunu anlamak için foreach döngüsü
            foreach (Control item in tedarikciBilgi.Controls)
            {
                //item textboxa eşitse temizle
                if (item is TextBox)
                    item.Text = "";
            }

        }
        //alisFiyatTxtBox değeri değiştiğinde toplamFiyatın değişmesi için yapılan işlem
        private void alisFiyatTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toplamFiyatTxtBox.Text = (double.Parse(miktarTxtBox.Text) * double.Parse(alisFiyatTxtBox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }
        // firmaNoTxtBox değeri değiştiğinde yap
        private void firmaNoTxtBox_TextChanged(object sender, EventArgs e)
        {
            //firmaNoTxtBox değeri boşsa
            if (firmaNoTxtBox.Text == "")
            {
                //Tedarikci Bilgi GroupBox'undaki itemlerin ne olduğunu bulmak için foreach döngüsü
                foreach (Control item in tedarikciBilgi.Controls)
                {
                    //item textbox ise temizle
                    if (item is TextBox)
                        item.Text = "";
                }

            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select firmaNo,firmaAd,telefon from tedarikçi where firmaNo like '" + firmaNoTxtBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            //Komutta istenen datayı okuduğu sürece
            while (read.Read())
            {
                firmaAdTxtBox.Text = read["firmaAd"].ToString();
                telefonTxtBox.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
    }
}
