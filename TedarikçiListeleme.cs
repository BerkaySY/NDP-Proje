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
    public partial class TedarikçiListeleme : Form
    {
        public TedarikçiListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Tedarikçi Güncelleme Butonu
        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tedarikçi set firmaAd=@firmaAd,telefon=@telefon,email=@email,adres=@adres where firmaNo=@firmaNo", baglanti);
            komut.Parameters.AddWithValue("@firmaNo", firmaNoTextBox.Text);
            komut.Parameters.AddWithValue("@firmaAd", firmaAdTextBox.Text);
            komut.Parameters.AddWithValue("@telefon", telTextBox.Text);
            komut.Parameters.AddWithValue("@email", emailTextBox.Text);
            komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["tedarikçi"].Clear();
            Kayit_Listele();
            MessageBox.Show("Tedarikçi Kaydı Güncellendi", "Bilgi");
            //Tedarikçi Güncelleme Yerindeki Controlleri gösteren foreach döngüsü
            foreach (Control item in this.Controls)
            {
                //item textbox veya maskedTextBox a eşitse temizle
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = "";
            }
        }
        //Form Açıldığında Datayı Tabloya Aktar
        private void TedarikçiListeleme_Load(object sender, EventArgs e)
        {
            Kayit_Listele();
        }
        //Tedarikçi Kayıtlarını Listeleyen Fonksiyon
        private void Kayit_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tedarikçi", baglanti);
            adapter.Fill(dataSet, "tedarikçi");
            dataGridView1.DataSource = dataSet.Tables["tedarikçi"];
            baglanti.Close();
        }
        //Tedarikçi Sil Butonu
        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tedarikçi where firmaNo='" + dataGridView1.CurrentRow.Cells["firmaNo"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["tedarikçi"].Clear();
            Kayit_Listele();
            MessageBox.Show("Tedarikçi Kaydı Silindi!", "Bilgi");
        }
        //FirmaNo ile Tedarikçi Kaydı Arama
        private void firmaAraTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tedarikçi where firmaAd like '%" + firmaAraTextBox.Text + "%'", baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        //Tablodaki tedarikçilerden çift tıklananın bilgilerini textboxlara aktar
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            firmaNoTextBox.Text = dataGridView1.CurrentRow.Cells["firmaNo"].Value.ToString();
            firmaAdTextBox.Text = dataGridView1.CurrentRow.Cells["firmaAd"].Value.ToString();
            telTextBox.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            emailTextBox.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            adresTextBox.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
        }
    }
}
