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
    public partial class HesapAcilis : Form
    {
        public HesapAcilis()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void HesapAcilis_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 15;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            SonHesapIDBul();
            HesapNumarasiOlustur();
        }

        private void SonHesapIDBul()
        {
            StreamWriter DosyaAc = new StreamWriter("HesapKartlari.txt", true);
            DosyaAc.Close();
            StreamReader oku = new StreamReader("HesapKartlari.txt");
            string okunan = oku.ReadLine();
            if (okunan == null)
                txtHesapId.Text = "1";
            else
            {
                while (okunan != null)
                {
                    string[] degerler = okunan.Split(';');
                    txtHesapId.Text = (int.Parse(degerler[0]) + 1).ToString();

                    okunan = oku.ReadLine();
                }

            }
            oku.Close();
        }

        private void HesapNumarasiOlustur()
        {
            bool varmi = false;
            do
            {
                varmi= hesapvarmi();                
            } while (varmi);
            
        }

        private bool hesapvarmi()
        {
            txtHesapNo.Text = "ACC" + rnd.Next(1000, 10000).ToString();
            StreamReader oku = new StreamReader("HesapKartlari.txt");
            string okunan = oku.ReadLine();

            while (okunan != null)
            {
                string[] degerler = okunan.Split(';');

                if (txtHesapNo.Text == degerler[1]) // Eğer yeni hesap no ya sahip önceden hesap no varsa içeri gir.
                {
                    oku.Close();
                    return true;
                    //HesapNumarasiOlustur(); (Recursive(kendini baştan döndüren) metodlar)

                }

                okunan = oku.ReadLine();
            }
            oku.Close();
            return false;
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "" && txtTCNo.Text.Trim() != "" && txtHesaptakiPara.Text.Trim() != "")
            {
                StreamWriter yaz = new StreamWriter("HesapKartlari.txt", true);
                string hesapturu = " ";
                if (rbVadeli.Checked)
                {
                    hesapturu = "Vadeli";
                }
                else if (rbVadesiz.Checked)
                {
                    hesapturu = "Vadesiz";
                }

                StreamWriter hesaphareketleri = new StreamWriter("HesapHareketleri.txt", true);
                hesaphareketleri.WriteLine(txtHesapId.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + Convert.ToDouble(txtHesaptakiPara.Text) + ";" + "yatan");

                hesaphareketleri.Close();

                yaz.WriteLine(txtHesapId.Text + ";" + txtHesapNo.Text + ";" + txtTarih.Text + ";" + txtAd.Text + ";" + txtSoyad.Text + ";" + Convert.ToInt64(txtTCNo.Text) + ";" + Convert.ToDouble(txtHesaptakiPara.Text) + ";" + hesapturu);

                yaz.Close();


                MessageBox.Show("Başarılı bir şekilde kaydınız oluştu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                SonHesapIDBul();
                HesapNumarasiOlustur();
            }
            else
                MessageBox.Show("Girilmesi zorunlu alanları boş bırakmayınız", "DİKKAT! Eksik Bilgi");
            
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
            }
        }

    }
}
