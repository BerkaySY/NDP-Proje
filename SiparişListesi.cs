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
    public partial class SiparişListesi : Form
    {
        public SiparişListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Sipariş Listelemeye Yarayan Fonksiyon
        private void Siparis_Listele()
        {
            
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from sipariş where tarih='"+DateTime.Now.ToString("d")+"'", baglanti);
            adapter.Fill(dataSet, "sipariş");
            siparisListe.DataSource = dataSet.Tables["sipariş"];
            baglanti.Close();
        }
        //Form Açıldığında Siparişleri Listeleme
        private void SiparişListesi_Load(object sender, EventArgs e)
        {
            Siparis_Listele();
        }
    }
}
