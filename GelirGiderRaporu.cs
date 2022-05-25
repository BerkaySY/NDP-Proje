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
    public partial class GelirGiderRaporu : Form
    {
        public GelirGiderRaporu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Satışları Listelemek İçin Fonksiyon
        private void satis_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from satış where tarih='" + DateTime.Now.ToString("d") + "'", baglanti);
            adapter.Fill(dataSet, "satış");
            gelirTablosu.DataSource = dataSet.Tables["satış"];
            baglanti.Close();
        }
        //Siparişleri Listelemek İçin Fonksiyon
        private void siparis_Listele()
        {
            
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from sipariş where tarih='" + DateTime.Now.ToString("d") + "'", baglanti);
            adapter.Fill(dataSet, "sipariş");
            giderSiparişTablosu.DataSource = dataSet.Tables["sipariş"];
            baglanti.Close();
           
        }
        //Rutin Giderleri Listelemek İçin FOnksiyon
        private void giderRutin_Listele()
        {
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from gider where tarih='" + DateTime.Now.ToString("d") + "'", baglanti);
            adapter.Fill(dataSet, "gider");
            giderRutinTablo.DataSource = dataSet.Tables["gider"];
            baglanti.Close();
        }
        //Toplam Ciroyu Hesaplayıp Döndüren Fonksiyon
        private double ciroHesapla()
        {

            double gelirToplam = 0.00;
            // i gelirtablosunun satır sayısından küçük oldukça yap
            for (int i = 0; i < gelirTablosu.Rows.Count;i++)
            {
                gelirToplam += Convert.ToDouble(gelirTablosu.Rows[i].Cells[9].Value);
                
            }

            double siparisToplam = 0.00;
            // i giderSipariştablosunun satır sayısından küçük oldukça yap
            for (int i = 0; i < giderSiparişTablosu.Rows.Count; i++)
            {
                siparisToplam += Convert.ToDouble(giderSiparişTablosu.Rows[i].Cells[7].Value);

            }

            double giderRutinToplam = 0.00;
            //  i giderRutinTablo satır sayısından küçük oldukça yap
            for (int i = 0; i < giderRutinTablo.Rows.Count; i++)
            {
                giderRutinToplam += Convert.ToDouble(giderRutinTablo.Rows[i].Cells[1].Value);

            }

            double ciro = gelirToplam - (siparisToplam + giderRutinToplam);
            return ciro;


        }
        private void GelirGiderRaporu_Load(object sender, EventArgs e)
        {
            satis_Listele();
            siparis_Listele();
            giderRutin_Listele();
            //Ciroyu Textboxa Yazdır
            try
            {
                ciroTxtBox.Text = ciroHesapla().ToString();
            }
            catch (Exception)
            {

                ;
            }
            
        }

        
    }
        
        
}

