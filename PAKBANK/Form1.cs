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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void yeniHesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapAcilis yenihesap = new HesapAcilis();
            yenihesap.Show();
        }

        private void hesapİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hesaphareketi hesaphareket = new Hesaphareketi();
            hesaphareket.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
