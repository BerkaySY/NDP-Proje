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
    public partial class DepoStok : Form
    {
        public DepoStok()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();

        private void DepoStok_Load(object sender, EventArgs e)
        {
            Kayit_Listele();
        } 
        //Kayıtları datagride aktarmak için yazılan fonksiyon
        private void Kayit_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select barkodNo,depoStogu,ürünAdi,satisFiyati,alisFiyati from stok where depoStogu > 0", baglanti);
            adapter.Fill(dataSet, "stok");
            depoListe.DataSource = dataSet.Tables["stok"];
            baglanti.Close();
        }

        //stok listesinden textboxa girilen barkodnoya sahip ürünün bilgilerini getirmek için
        private void araTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select barkodNo,depoStogu,ürünAdi,satisFiyati,alisFiyati from stok where depoStogu > 0 AND barkodNo like '%" + araTextBox.Text + "%'", baglanti);
            adapter.Fill(tablo);
            depoListe.DataSource = tablo;
            baglanti.Close();
        }
    }
}
