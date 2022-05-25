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
    public partial class RafStok : Form
    {
        public RafStok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Raf stoğunu form açıldığında listelemek için
        private void RafStok_Load(object sender, EventArgs e)
        {
            Kayit_Listele();
        }
        //Raf Stoğunu Listelemeye Yarayan fonksiyon Ürünlerden Raf Stoğu 0'dan büyük olanları getirir
        private void Kayit_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select barkodNo,rafStogu,ürünAdi,satisFiyati,alisFiyati from stok where rafStogu > 0", baglanti);
            adapter.Fill(dataSet, "stok");
            rafListe.DataSource = dataSet.Tables["stok"];
            baglanti.Close();
        }
        //Barkod Noya göre Raf stoğu 0'dan büyük olanları getirme
        private void araTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select barkodNo,rafStogu,ürünAdi,satisFiyati,alisFiyati from stok where rafStogu > 0 AND barkodNo like '%" + araTextBox.Text + "%'", baglanti);
            adapter.Fill(tablo);
            rafListe.DataSource = tablo;
            baglanti.Close();
        }
    }
}
