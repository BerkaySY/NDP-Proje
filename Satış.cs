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
    public partial class Satış : Form
    {
        public Satış()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        //Satış Yapma Butonu
        private void satisYapBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutRaf = new SqlCommand("select rafStogu from stok where barkodNo='" + barkodNoTxtBox.Text + "'", baglanti);
            int komutRafStok = Convert.ToInt32(komutRaf.ExecuteScalar());
            baglanti.Close();
            
            baglanti.Open();
            SqlCommand komutDepo = new SqlCommand("select depoStogu from stok where barkodNo='" + barkodNoTxtBox.Text + "'", baglanti);
            int komutDepoStok = Convert.ToInt32(komutDepo.ExecuteScalar());
            baglanti.Close();
            // Ürünün raf stoğu ve depo stoğu girilen miktardan küçükse uyarı ver
            if (komutRafStok < Convert.ToInt32(miktarTxtBox.Text) && komutDepoStok < Convert.ToInt32(miktarTxtBox.Text))
                MessageBox.Show("Satmak İstediğiniz Ürün İçin Stok Yetersiz!", "Uyarı");
            //Ürünün raf stoğu ve depo stoğu girilen miktardan büyükse  satışı gerçekleştir
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satış(tc,ad,soyad,telefon,adres,barkodNo,ürünAdi,miktar,satisFiyati,toplamFiyat,tarih) values(@tc,@ad,@soyad,@telefon,@adres,@barkodNo,@ürünAdi,@miktar,@satisFiyati,@toplamFiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", tcTxtBox.Text);
                komut.Parameters.AddWithValue("@ad", adTxtBox.Text);
                komut.Parameters.AddWithValue("@soyad", soyadTxtBox.Text);
                komut.Parameters.AddWithValue("@telefon", telTextBox.Text);
                komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
                komut.Parameters.AddWithValue("@barkodNo", barkodNoTxtBox.Text);
                komut.Parameters.AddWithValue("@ürünAdi", ürünAdTxtBox.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(miktarTxtBox.Text));
                komut.Parameters.AddWithValue("@satisFiyati", double.Parse(satisFiyatTxtBox.Text));
                komut.Parameters.AddWithValue("@toplamFiyat", double.Parse(toplamFiyatTxtBox.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("d"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                // Ürünün rafstogu girilen miktara eşit veya büyükse raf stoğundan düş
                if(komutRafStok >= Convert.ToInt32(miktarTxtBox.Text))
                {
                    baglanti.Open();
                    SqlCommand komutStok = new SqlCommand("update stok set rafStogu = rafStogu-'" + int.Parse(miktarTxtBox.Text) + "' where barkodNo='" + barkodNoTxtBox.Text + "'", baglanti);
                    komutStok.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satışınız Onaylandı!", "Bilgi");
                }
                //Değilse depo stoğundan düş
                else
                {
                    baglanti.Open();
                    SqlCommand komutStok = new SqlCommand("update stok set depoStogu = depoStogu-'" + int.Parse(miktarTxtBox.Text) + "' where barkodNo='" + barkodNoTxtBox.Text + "'", baglanti);
                    komutStok.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satışınız Onaylandı!", "Bilgi");
                }
                
            }
            
            

        }
        //barkodnoTxtBox değeri değişirse
        private void barkodNoTxtBox_TextChanged(object sender, EventArgs e)
        {
            //barkodNoTxtBox değeri boşsa
            if (barkodNoTxtBox.Text == "")
            {
                //ÜrünBilgi groupboxındaki itemlerin hangi controle ait olduğunu bulmak için foreach döngüsü
                foreach (Control item in ürünBilgi.Controls)
                {
                    //item textboxsa
                    if (item is TextBox)
                    {
                        //item miktarTxtBoxsa değerini 1 yap
                        if (item == miktarTxtBox)
                            item.Text = "1";
                        //item toplamFiyatTxtboxsa değerini 0.00 yap
                        else if (item == toplamFiyatTxtBox)
                            item.Text = "0,00";
                        //2si de değise boş yap
                        else
                            item.Text = "";

                    }

                }

            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select barkodNo,ürünAdi,satisFiyati from stok where barkodNo like '" + barkodNoTxtBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            //komutu datadan okuduğu sürece
            while (read.Read())
            {
                ürünAdTxtBox.Text = read["ürünAdi"].ToString();
                satisFiyatTxtBox.Text = read["satisFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void tcTxtBox_TextChanged(object sender, EventArgs e)
        {
            //tcTxtBox değeri boşsa
            if (tcTxtBox.Text == "")
            {
                //müsteribilgi groupboxının itemlerinin hangi control olduğunu bulmak için foreach döngüsü
                foreach (Control item in müsteriBilgi.Controls)
                {
                    //item textboxsa değerini boş yap
                    if (item is TextBox)
                        item.Text = "";
                }

            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select tc,ad,soyad,telefon,adres from müşteri where tc like '" + tcTxtBox.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            // komuttaki datayı okuduğu sürece
            while (read.Read())
            {
                adTxtBox.Text = read["ad"].ToString();
                soyadTxtBox.Text = read["soyad"].ToString();
                telTextBox.Text = read["telefon"].ToString();
                adresTextBox.Text = read["adres"].ToString();
            }
            baglanti.Close();
        }

        private void miktarTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Hata olmaması için toplamfiyat değerini girdiren try catch bloğu
            try
            {
                toplamFiyatTxtBox.Text = (double.Parse(miktarTxtBox.Text) * double.Parse(satisFiyatTxtBox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void satisFiyatTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Hata olmaması için toplamfiyat değerini girdiren try catch bloğu
            try
            {
                toplamFiyatTxtBox.Text = (double.Parse(miktarTxtBox.Text) * double.Parse(satisFiyatTxtBox.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            //ürünbilgi groupboxundaki item controllerini bulmak için foreach döngüsü
            foreach (Control item in ürünBilgi.Controls)
            {
                //item textboxsa
                if (item is TextBox)
                {
                    //item miktarTxtBoxsa değerini 1 yap
                    if (item == miktarTxtBox)
                        item.Text = "1";
                    //item toplamFiyatTxtBoxsa 0.00 yap
                    else if (item == toplamFiyatTxtBox)
                        item.Text = "0,00";
                    //2si de değilse boş yap
                    else
                        item.Text = "";
                }
            }
            //müsteribilgi groupboxindaki itemlerin hangi control olduğunu bulmak için foreach döngüsü
            foreach (Control item in müsteriBilgi.Controls)
            {
                //item textboxsa değerini boş yap
                if (item is TextBox)
                    item.Text = "";
            }
        }
    }
}
