using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmstokislemleri : Form
    {
        public frmstokislemleri()
        {
            InitializeComponent();
        }
        frmstokislemleriurunekleme frmurunekleme = new frmstokislemleriurunekleme();
        private void frmstokislemleri_Load(object sender, EventArgs e)
        {
           
            btnurunekleme.Select();
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnurunekleme_Click(object sender, EventArgs e)
        {

           

            frmurunekleme.Dock = DockStyle.Fill;
            frmurunekleme.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frmurunekleme);
            frmurunekleme.Show();
        }

        private void btnmevcuturunekleme_Click(object sender, EventArgs e)
        {
            
            
            frmstokislemlerimevcuturunekleme frmstokislemlerimevcuturunekleme = new frmstokislemlerimevcuturunekleme();
            frmstokislemlerimevcuturunekleme.Dock = DockStyle.Fill;
            frmstokislemlerimevcuturunekleme.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frmstokislemlerimevcuturunekleme);
            frmstokislemlerimevcuturunekleme.Show();
        }

        private void btnurunsilme_Click(object sender, EventArgs e)
        {
            
            frmstokislemleriurunsilme frmstokislemleriurunsilme = new frmstokislemleriurunsilme();
            frmstokislemleriurunsilme.Dock = DockStyle.Fill;
            frmstokislemleriurunsilme.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frmstokislemleriurunsilme);
            frmstokislemleriurunsilme.Show();
        }

        private void btnurunguncelleme_Click(object sender, EventArgs e)
        {
           
            frmstokislemleriurunguncelle frmstokislemleriurunguncelle = new frmstokislemleriurunguncelle();
            frmstokislemleriurunguncelle.Dock = DockStyle.Fill;
            frmstokislemleriurunguncelle.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(frmstokislemleriurunguncelle);
            frmstokislemleriurunguncelle.Show();

        }

        private void btnenvanter_Click(object sender, EventArgs e)
        {
            frmstokEnvanter envanter = new frmstokEnvanter();
            envanter.Dock = DockStyle.Fill;
            envanter.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(envanter);
            envanter.Show();
        }
    }
}
