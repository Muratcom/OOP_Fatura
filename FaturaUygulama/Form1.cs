using FaturaUygulama.Interface;
using FaturaUygulama.Models;
using FaturaUygulama.Services;
using FaturaUygulama.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AnaFatura ana;

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in Enum.GetValues(typeof(FaturaTipi)))
            {
                cmbFaturaTip.Items.Add(item);
            }

            

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            FaturaTipi faturatip = (FaturaTipi)cmbFaturaTip.SelectedItem;
           

            FaturaKes service = new FaturaKes(faturatip);
            ana = service.FaturaSec();

            Ihesapla hesap = (Ihesapla)ana;
            lblTutarC.Text = hesap.hesapla().ToString()+"  TL";
            


        }

  

        private void cmbFaturaTip_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FaturaTipi faturatip = (FaturaTipi)cmbFaturaTip.SelectedItem;
            FaturaKes service = new FaturaKes(faturatip);
            ana = service.FaturaSec();

            lblEndeks1.Text = ana.ilkendeks.ToString()+"  m3 kw";
            lblEndeks2.Text = ana.sonendeks.ToString() + "  m3 kw";
            lblMiktar.Text = ana.kullanimMiktari.ToString() + "  m3 kw";
            lblTarihC.Text = ana.tarih.ToString();
            lblAdsoyad.Text = ana.isim + " " + ana.Soyisim;
            lblTutarC.Text = "0";
        }
    }
}
