﻿/****************************************************************************
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
    public partial class SatışRaporu : Form
    {
        public SatışRaporu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8JRNM7R;Initial Catalog=NDPProje;Integrated Security=True");
        DataSet dataSet = new DataSet();
        //Günlük Satışları Raporlamaya Yarayan Fonksiyon
        private void Satis_Raporla()
        {

            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from satış where tarih='" + DateTime.Now.ToString("d") + "'", baglanti);
            adapter.Fill(dataSet, "satış");
            satisRaporu.DataSource = dataSet.Tables["satış"];
            baglanti.Close();
        }
        //Form Açıldığında Günlük Satışı Raporla
        private void SatışRaporu_Load(object sender, EventArgs e)
        {
            Satis_Raporla();
        }
    }
}
