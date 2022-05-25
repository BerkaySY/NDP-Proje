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
    public partial class GiderDüzenle : Form
    {
        public GiderDüzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();

        //Gider Tablosunu datagridde göstermek için fonksiyon
        private void gider_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from gider where tarih='"+ DateTime.Now.ToString("d") + "'", baglanti);
            adapter.Fill(dataSet, "gider");
            giderTablosu.DataSource = dataSet.Tables["gider"];
            baglanti.Close();
        }

        bool durum;
        //Textboxa girilen gider ismi tabloda varsa uyarı ver yoksa ekle
        private void giderKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from gider where giderIsmi=@giderIsmi", baglanti);
            komut.Parameters.AddWithValue("@giderIsmi", giderIsimEkleTxtBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //Girilen giderin tabloda olup olmadğını kontrol edip true false döndürmek için if-else bloğu
            if (dr.Read())
                durum = false;
            else
                durum = true;

            baglanti.Close();
        }
        //Giderleri Form Açıldığında Datagride aktarmak için
        private void GiderDüzenle_Load(object sender, EventArgs e)
        {
            gider_Listele();
        }
        //Gider Ekleme İşlemleri
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            giderKontrol();
            //Girilen Gider SQL tablosunda yoksa ekle yoksa uyarı ver
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into gider(giderIsmi,tutar,tarih) values(@giderIsmi,@tutar,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@giderIsmi", giderIsimEkleTxtBox.Text);
                komut.Parameters.AddWithValue("@tutar", double.Parse(tutarEkleTxtBox.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("d"));
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataSet.Tables["gider"].Clear();
                gider_Listele();
                MessageBox.Show("Gider Eklendi");
            }
            else
            {
                MessageBox.Show("Bu İsme Sahip Bir Gider Zaten Var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
