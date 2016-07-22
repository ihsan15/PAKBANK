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

namespace PAKBANK
{
    public partial class ParaYatirCek : Form
    {
        public ParaYatirCek()
        {
            InitializeComponent();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            string islemturu;
            if (cbIslemTuru.SelectedIndex == 0)
            {
                islemturu = "yatan";
            }
            else
            {
                islemturu = "cekilen";
            }
            if (txtTutar.Text.Trim() != "")
            {                
                StreamWriter hesaphareketleri = new StreamWriter("HesapHareketleri.txt", true);
                hesaphareketleri.WriteLine(txtHesapId.Text + ";" + txtHesapNo.Text + ";" + DateTime.Now.ToShortDateString() + ";" + txtTutar.Text + ";" + islemturu);
                hesaphareketleri.Close();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Lütfen İşlem miktarını giriniz.","Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

        }

        private void ParaYatirCek_Load(object sender, EventArgs e)
        {
            cbIslemTuru.SelectedIndex = 1;
            //Hesaphareketi hesaphareketi = new Hesaphareketi(); // bunu kullansaydık çekerdik fakat 0 olarak tanılardık.
            //txtHesapId.Text = Hesaphareketi.HesapID;
            //txtHesapNo.Text = Hesaphareketi.HesapNo;
            //txtTarih.Text = Hesaphareketi.tarih;
        }

        public void HesapBilgileriAl(string ID,string HesapNo,string tarih)
        {
            txtHesapId.Text = ID;
            txtHesapNo.Text = HesapNo;
            txtTarih.Text = tarih;
        }
    }
}
