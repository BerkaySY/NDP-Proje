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
    public partial class MüsteriListeleme : Form
    {
        public MüsteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Form Açıldığında Müşteri Kayıtlarını Datagride Aktarma
        private void MüsteriListeleme_Load(object sender, EventArgs e)
        {
            Kayit_Listele();
        }
        // Müşteri Kayıtlarını Getirmesi İçin Yazılan Fonksiyon
        private void Kayit_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from müşteri", baglanti);
            adapter.Fill(dataSet, "müşteri");
            dataGridView1.DataSource = dataSet.Tables["müşteri"];
            baglanti.Close();
        }
        //Müşteri Kaydı Güncellemek İçin Güncelleme Yerine Tablodan üstüne çift tıklanan müşterinin bilgilerini getirme
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcTextBox.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            adTextBox.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            soyadTextBox.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            telTextBox.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            adresTextBox.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
        }
        //Müşteri Bilgilerini Güncelleme Butonu
        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set ad=@ad,soyad=@soyad,telefon=@telefon,adres=@adres where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", tcTextBox.Text);
            komut.Parameters.AddWithValue("@ad", adTextBox.Text);
            komut.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@telefon", telTextBox.Text);
            komut.Parameters.AddWithValue("@adres", adresTextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["müşteri"].Clear();
            Kayit_Listele();
            MessageBox.Show("Müşteri Kaydı Güncellendi", "Bilgi");
            //Butona Basıldıktan Sonra Güncelleme Kısmındaki Bilgileri Silen ForEach döngüsü
            foreach (Control item in this.Controls)
            {
                // item textbox veya maskedtextboxsa temizle
                if (item is TextBox || item is MaskedTextBox)
                    item.Text = "";
            }
        }
        //Müşteri Kaydını Silme Butonu
        private void silBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='" + dataGridView1.CurrentRow.Cells["tc"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataSet.Tables["müşteri"].Clear();
            Kayit_Listele();
            MessageBox.Show("Müşteri Kaydı Silindi!", "Bilgi");
        }
        //Müşteriyi TC bilgisine Göre Arama
        private void tcAraTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from müşteri where tc like '%" + tcAraTextBox.Text + "%'", baglanti);
            adapter.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }

    
    
}
