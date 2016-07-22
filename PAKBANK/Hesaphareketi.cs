using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PAKBANK
{
    public partial class Hesaphareketi : Form
    {
        public Hesaphareketi()
        {
            InitializeComponent();
        }

        //public static string HesapID;
        //public static string HesapNo;
        //public static string tarih;

        Font fntYazdirBaslik = new Font("Times New Roman", 16, FontStyle.Bold);
        Font fntYazdirDetay = new Font("Times New Roman", 12, FontStyle.Regular);
        StringFormat frmt = new StringFormat();
        SolidBrush sbyazdirBaslik = new SolidBrush(Color.Black);

        private void btnBul_Click(object sender, EventArgs e)
        {
            if(txtHesapNo.Text.Trim()!="")
            {
                HesapHareketleriGoster();
                ToplamlariGoster();
                HesapBilgileriGoster();
                btnYatırCek.Enabled = true;
                btnYazdir.Enabled = true;
            }
            else
                MessageBox.Show("Girilmesi zorunlu alanları boş bırakmayınız", "DİKKAT! Eksik Bilgi");

        }

        private void HesapBilgileriGoster()
        {
            StreamReader hesapOku = new StreamReader("HesapKartlari.txt");
            string okunan = hesapOku.ReadLine();
            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');
                if (txtHesapNo.Text == Degerler[1])
                {
                    txtAd.Text = Degerler[3];
                    txtSoyad.Text = Degerler[4];
                    txtTCNo.Text = Degerler[5].ToString();
                    txtHesapTuru.Text = Degerler[7];
                }
                okunan = hesapOku.ReadLine();
            }

            hesapOku.Close();
        }

        private void HesapHareketleriGoster()
        {
            int sayac = 0;
            lvHesapGoruntuleme.Items.Clear();
            StreamReader hesabıoku = new StreamReader("HesapHareketleri.txt");
            string okunan = hesabıoku.ReadLine();

            while (okunan != null)
            {
                string[] Degerler = okunan.Split(';');


                if (txtHesapNo.Text == Degerler[1])
                {
                    lvHesapGoruntuleme.Items.Add(Degerler[0]);
                    lvHesapGoruntuleme.Items[sayac].SubItems.Add(Degerler[1]);
                    lvHesapGoruntuleme.Items[sayac].SubItems.Add(Degerler[2]);
                    lvHesapGoruntuleme.Items[sayac].SubItems.Add(Degerler[3]);
                    lvHesapGoruntuleme.Items[sayac].SubItems.Add(Degerler[4]);
                    sayac++;
                }
                okunan = hesabıoku.ReadLine();
            }
            hesabıoku.Close();
        }

        private void Hesaphareketi_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 15;
            
        }

        private void ToplamlariGoster()
        {
            double toplamyatan = 0;
            double toplamcekilen = 0;
            for (int i = 0; i < lvHesapGoruntuleme.Items.Count; i++)
            {
                if (lvHesapGoruntuleme.Items[i].SubItems[4].Text=="yatan")
                {
                    toplamyatan += Convert.ToDouble(lvHesapGoruntuleme.Items[i].SubItems[3].Text);
                }
                else
                {
                    toplamcekilen += Convert.ToDouble(lvHesapGoruntuleme.Items[i].SubItems[3].Text);
                }
                txtYatirilanPara.Text = toplamyatan.ToString();
                txtCekilenPara.Text = toplamcekilen.ToString();
                txtBakiye.Text = (toplamyatan - toplamcekilen).ToString();
            }

            
            
            
        }

        private void btnYatırCek_Click(object sender, EventArgs e)
        {
            
            //HesapID = lvHesapGoruntuleme.Items[0].SubItems[0].Text;
            //HesapNo = lvHesapGoruntuleme.Items[0].SubItems[1].Text;
            //tarih = lvHesapGoruntuleme.Items[0].SubItems[0].Text;
            ParaYatirCek yatircek = new ParaYatirCek();

            yatircek.HesapBilgileriAl(lvHesapGoruntuleme.Items[0].SubItems[0].Text, lvHesapGoruntuleme.Items[0].SubItems[1].Text, lvHesapGoruntuleme.Items[0].SubItems[2].Text);  
            yatircek.ShowDialog();
            HesapHareketleriGoster();
            ToplamlariGoster();            
            
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            k = 0;
            ppdHesap.ShowDialog();
        }

        int k = 0;
        private void pDocHesap_PrintPage(object sender, PrintPageEventArgs e)
        {
            int j = 0;
            e.Graphics.DrawString("Müşteri : " + txtAd.Text + " " + txtSoyad.Text, fntYazdirBaslik, sbyazdirBaslik, 100, 100, frmt);
            e.Graphics.DrawString("HesapNo : " + txtHesapNo.Text, fntYazdirBaslik, sbyazdirBaslik, 100, 130, frmt);
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), fntYazdirBaslik, sbyazdirBaslik, 600, 50, frmt);
            e.Graphics.DrawString("HESAP HAREKETLERİ", fntYazdirBaslik, sbyazdirBaslik, 300, 200, frmt);
            e.Graphics.DrawString("ID       Hesap No       İşlem Tarihi       Tutar       İşlem Türü", fntYazdirBaslik, sbyazdirBaslik, 100, 240, frmt);
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", fntYazdirBaslik, sbyazdirBaslik, 80, 260);
            for (int i = k; i < lvHesapGoruntuleme.Items.Count; i++)
            {
                
                e.Graphics.DrawString(lvHesapGoruntuleme.Items[i].SubItems[0].Text, fntYazdirDetay, sbyazdirBaslik, 100, 300 + (j * 30),frmt);
                e.Graphics.DrawString(lvHesapGoruntuleme.Items[i].SubItems[1].Text, fntYazdirDetay, sbyazdirBaslik, 170, 300 + (j * 30), frmt);
                e.Graphics.DrawString(lvHesapGoruntuleme.Items[i].SubItems[2].Text, fntYazdirDetay, sbyazdirBaslik, 310, 300 + (j * 30), frmt);
                frmt.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(lvHesapGoruntuleme.Items[i].SubItems[3].Text, fntYazdirDetay, sbyazdirBaslik, 500, 300 + (j * 30), frmt);
                frmt.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(lvHesapGoruntuleme.Items[i].SubItems[4].Text, fntYazdirDetay, sbyazdirBaslik, 590, 300 + (j * 30), frmt);
                if (i % 22 == 0 && i != 0)
                {
                    e.HasMorePages = true;
                    k++;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                    k++;
                    j++;
                }
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", fntYazdirBaslik, sbyazdirBaslik, 80, 300 + (j * 30));

            e.Graphics.DrawString("Toplam Yatırılan Para : ", fntYazdirDetay, sbyazdirBaslik, 280, 330 + (j * 30), frmt);
            frmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtYatirilanPara.Text,fntYazdirDetay, sbyazdirBaslik, 500, 330 + (j * 30), frmt);
            frmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Toplam Çekilen Para : ", fntYazdirDetay, sbyazdirBaslik, 280, 360 + (j * 30), frmt);
            frmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtCekilenPara.Text, fntYazdirDetay, sbyazdirBaslik, 500, 360 + (j * 30), frmt);
            frmt.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Bakiye : ", fntYazdirDetay, sbyazdirBaslik, 280, 390 + (j * 30), frmt);
            frmt.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(txtBakiye.Text, fntYazdirDetay, sbyazdirBaslik, 500, 390 + (j * 30), frmt);

        }
    }
}
