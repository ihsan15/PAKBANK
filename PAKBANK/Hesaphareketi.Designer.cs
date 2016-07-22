namespace PAKBANK
{
    partial class Hesaphareketi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesaphareketi));
            this.txtHesapTuru = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.btnYatırCek = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCekilenPara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYatirilanPara = new System.Windows.Forms.TextBox();
            this.lvHesapGoruntuleme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pDocHesap = new System.Drawing.Printing.PrintDocument();
            this.ppdHesap = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Enabled = false;
            this.txtHesapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapTuru.Location = new System.Drawing.Point(161, 223);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.Size = new System.Drawing.Size(226, 26);
            this.txtHesapTuru.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Hesap No :";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapNo.Location = new System.Drawing.Point(161, 41);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(226, 26);
            this.txtHesapNo.TabIndex = 0;
            // 
            // btnYatırCek
            // 
            this.btnYatırCek.Enabled = false;
            this.btnYatırCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatırCek.Location = new System.Drawing.Point(356, 457);
            this.btnYatırCek.Name = "btnYatırCek";
            this.btnYatırCek.Size = new System.Drawing.Size(97, 68);
            this.btnYatırCek.TabIndex = 4;
            this.btnYatırCek.Text = "Yatır  Çek";
            this.btnYatırCek.UseVisualStyleBackColor = true;
            this.btnYatırCek.Click += new System.EventHandler(this.btnYatırCek_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Bakiye :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Enabled = false;
            this.txtBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.Location = new System.Drawing.Point(238, 544);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(93, 26);
            this.txtBakiye.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Toplam Çekilen Para :";
            // 
            // txtCekilenPara
            // 
            this.txtCekilenPara.Enabled = false;
            this.txtCekilenPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCekilenPara.Location = new System.Drawing.Point(238, 502);
            this.txtCekilenPara.Name = "txtCekilenPara";
            this.txtCekilenPara.Size = new System.Drawing.Size(93, 26);
            this.txtCekilenPara.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Toplam Yatırılan Para :";
            // 
            // txtYatirilanPara
            // 
            this.txtYatirilanPara.Enabled = false;
            this.txtYatirilanPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYatirilanPara.Location = new System.Drawing.Point(238, 470);
            this.txtYatirilanPara.Name = "txtYatirilanPara";
            this.txtYatirilanPara.Size = new System.Drawing.Size(93, 26);
            this.txtYatirilanPara.TabIndex = 2;
            // 
            // lvHesapGoruntuleme
            // 
            this.lvHesapGoruntuleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHesapGoruntuleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHesapGoruntuleme.GridLines = true;
            this.lvHesapGoruntuleme.Location = new System.Drawing.Point(25, 261);
            this.lvHesapGoruntuleme.Name = "lvHesapGoruntuleme";
            this.lvHesapGoruntuleme.Size = new System.Drawing.Size(474, 179);
            this.lvHesapGoruntuleme.TabIndex = 64;
            this.lvHesapGoruntuleme.UseCompatibleStateImageBehavior = false;
            this.lvHesapGoruntuleme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tutar";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Türü";
            this.columnHeader5.Width = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Hesap Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "TC No :";
            // 
            // txtTCNo
            // 
            this.txtTCNo.Enabled = false;
            this.txtTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNo.Location = new System.Drawing.Point(161, 191);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(226, 26);
            this.txtTCNo.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Enabled = false;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(161, 159);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(226, 26);
            this.txtSoyad.TabIndex = 53;
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Location = new System.Drawing.Point(161, 73);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(226, 48);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Enabled = false;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(161, 127);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(226, 26);
            this.txtAd.TabIndex = 52;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Enabled = false;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(356, 539);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(97, 36);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(393, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "*";
            // 
            // pDocHesap
            // 
            this.pDocHesap.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDocHesap_PrintPage);
            // 
            // ppdHesap
            // 
            this.ppdHesap.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHesap.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHesap.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHesap.Document = this.pDocHesap;
            this.ppdHesap.Enabled = true;
            this.ppdHesap.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHesap.Icon")));
            this.ppdHesap.Name = "ppdHesap";
            this.ppdHesap.Visible = false;
            // 
            // Hesaphareketi
            // 
            this.AcceptButton = this.btnBul;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(520, 591);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtHesapTuru);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.btnYatırCek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCekilenPara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYatirilanPara);
            this.Controls.Add(this.lvHesapGoruntuleme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Name = "Hesaphareketi";
            this.Text = "Hesap Hareketleri";
            this.Load += new System.EventHandler(this.Hesaphareketi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesapTuru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Button btnYatırCek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCekilenPara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYatirilanPara;
        private System.Windows.Forms.ListView lvHesapGoruntuleme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument pDocHesap;
        private System.Windows.Forms.PrintPreviewDialog ppdHesap;
    }
}