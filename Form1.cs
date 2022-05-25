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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Stok işlemlerini Açmak için buton
        private void StokIslem_Click(object sender, EventArgs e)
        {
            Stok stokForm = new Stok();
            stokForm.Show();
            this.Hide();
        }
        //Müşteri İşlemleri İçin buton
        private void MüsteriIslem_Click(object sender, EventArgs e)
        {
            Müsteri müsteriForm = new Müsteri();
            müsteriForm.Show();
            this.Hide();
        }
        //Tedarikçi İşlemleri için Buton
        private void TedarikciIslem_Click(object sender, EventArgs e)
        {
            Tedarikçi tedarikciForm = new Tedarikçi();
            tedarikciForm.Show();
            this.Hide();
        }
        //GelirGider İşlemleri İçin buton
        private void GelirGiderIslem_Click(object sender, EventArgs e)
        {
            GelirGiderİşlem gelirGiderIslem = new GelirGiderİşlem();
            gelirGiderIslem.Show();
            
        }
        //Programı Tamamen kapatmak için
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
