using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }

        private void btnlisans_Click(object sender, EventArgs e)
        {
            frmhesap frmhesap = new frmhesap();            
            panel3.Controls.Clear();           
            frmhesap.ShowDialog();
        }

        private void btngenelayarlar_Click(object sender, EventArgs e)
        {
            frmayarlar_GenelAyarlar genelAyarlar = new frmayarlar_GenelAyarlar();
            genelAyarlar.Dock = DockStyle.Fill;
            genelAyarlar.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(genelAyarlar);
            genelAyarlar.Show();
        }

        private void btnmuhasebe_Click(object sender, EventArgs e)
        {
            frmayarlar_muhasebeayarlari frmayarlar_muhasebeayarlari = new frmayarlar_muhasebeayarlari();            
            panel3.Controls.Clear();            
            frmayarlar_muhasebeayarlari.ShowDialog();
        }

        private void btnyedekleme_Click(object sender, EventArgs e)
        {
            frmayarlar_Yedekleme frmayarlar_Yedekleme = new frmayarlar_Yedekleme();
            panel3.Controls.Clear();
            frmayarlar_Yedekleme.ShowDialog();
        }

        private void btnaltbolumayarlari_Click(object sender, EventArgs e)
        {
            frmayarlar_altbolum frmayarlar_altbolum = new frmayarlar_altbolum();
            panel3.Controls.Clear();
            frmayarlar_altbolum.ShowDialog();
        }

        private void btnyardim_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bryazilim.wordpress.com/iletisim/");
        }

        private void btnsifirlama_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Tüm ayarlarınız sıfırlanacak. Emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                Settings.altbolumayarlari.Default.Reset();
                Settings.GenelAyarlar.Default.Reset();
                Settings.MuhasebeAyarlari.Default.Reset();
                Settings.YedeklemeAyarlari.Default.Reset();
                MessageBox.Show("Tüm ayarlar sıfırlandı.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void pcblogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bryazilim.wordpress.com/");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
