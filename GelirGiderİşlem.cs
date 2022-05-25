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

namespace NDP_Proje
{
    public partial class GelirGiderİşlem : Form
    {
        public GelirGiderİşlem()
        {
            InitializeComponent();
        }
        // Gider Ekleme Ekranı İçin Buton
        private void button1_Click(object sender, EventArgs e)
        {
            GiderDüzenle giderDüzenleme = new GiderDüzenle();
            giderDüzenleme.Show();
        }
        // Gelir Gider Raporu Almak İçin Buton
        private void button2_Click(object sender, EventArgs e)
        {
            GelirGiderRaporu gelirGiderRapor = new GelirGiderRaporu();
            gelirGiderRapor.Show();
        }
    }
}
