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
    public partial class ÜrünListe : Form
    {
        public ÜrünListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Form Açıldığında Ürün Listesini Tabloya Aktar
        private void ÜrünListe_Load(object sender, EventArgs e)
        {
            Kayit_Listele();
        }
        //Ürün Listesi getiren fonksiyon
        private void Kayit_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from stok", baglanti);
            adapter.Fill(dataSet, "stok");
            dataGridView1.DataSource = dataSet.Tables["stok"];
            baglanti.Close();
        }
        //Ürün Güncelleme Butonu
        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update stok set rafStogu=@rafStogu,depoStogu=@depoStogu,ürünAdi=@ürünAdi,satisFiyati=@satisFiyati,alisFiyati=@alisFiyati where barkodNo=@barkodNo", baglanti);
            komut.Parameters.AddWithValue("@barkodNo", barkodTextBox.Text);
            komut.Parameters.AddWithValue("@rafStogu", int.Parse(rafTextBox.Text));
            komut.Parameters.AddWithValue("@depoStogu", int.Parse(depoTextBox.Text));
            komut.Parameters.AddWithValue("@ürünAdi", ürünAdTextBox.Text);
            komut.Parameters.AddWithValue("@satisFiyati", double.Parse(satisTextBox.Text));
            komut.Parameters.AddWithValue("@alisFiyati", double.Parse(alisTextBox.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["stok"].Clear();
            Kayit_Listele();
            MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi");
            //Control itemlerinin türünü döndüren foreach döngüsü
            foreach (Control item in this.Controls)
            {
                //item textbox ise temizle
                if (item is TextBox)
                    item.Text = "";
            }
        }
        //Ürün Silme Butonu
        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from stok where barkodNo='" + dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["stok"].Clear();
            Kayit_Listele();
            MessageBox.Show("Ürün Kaydı Silindi!", "Bilgi");
        }
        //Ürünü Barkod No'ya Göre Arama
        private void araTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from stok where barkodNo like '%" + araTextBox.Text + "%'", baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        //Çift Tıklanan ürün kaydının bilgilerini textboxlara aktar
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodTextBox.Text = dataGridView1.CurrentRow.Cells["barkodNo"].Value.ToString();
            rafTextBox.Text = dataGridView1.CurrentRow.Cells["rafStogu"].Value.ToString();
            depoTextBox.Text = dataGridView1.CurrentRow.Cells["depoStogu"].Value.ToString();
            ürünAdTextBox.Text = dataGridView1.CurrentRow.Cells["ürünAdi"].Value.ToString();
            satisTextBox.Text = dataGridView1.CurrentRow.Cells["satisFiyati"].Value.ToString();
            alisTextBox.Text = dataGridView1.CurrentRow.Cells["alisFiyati"].Value.ToString();
        }
    }
}
