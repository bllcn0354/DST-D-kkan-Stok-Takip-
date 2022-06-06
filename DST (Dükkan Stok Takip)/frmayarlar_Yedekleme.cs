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
    public partial class frmayarlar_Yedekleme : Form
    {
        public frmayarlar_Yedekleme()
        {
            InitializeComponent();
        }

        private void radiogunluk_CheckedChanged(object sender, EventArgs e)
        {
            cmbhedefzaman.Items.Clear();   
            for (int i = 1; i < 25; i++)
            {
                cmbhedefzaman.Items.Add(i);
            }
            
        }

        private void radiohaftalik_CheckedChanged(object sender, EventArgs e)
        {
            cmbhedefzaman.Items.Clear();
            for (int i = 1; i < 8; i++)
            {
                cmbhedefzaman.Items.Add(i);
            }
        }

        private void radioaylik_CheckedChanged(object sender, EventArgs e)
        {
            cmbhedefzaman.Items.Clear();
            for (int i = 1; i < 31; i++)
            {
                cmbhedefzaman.Items.Add(i);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (radiogunluk.Checked == true)
            {
                Settings.YedeklemeAyarlari.Default.Mail = txtmail.Text;
                Settings.YedeklemeAyarlari.Default.Periyod_Turu = 1;
                Settings.YedeklemeAyarlari.Default.Hedef_Zaman = cmbhedefzaman.SelectedIndex + 1;
                Settings.YedeklemeAyarlari.Default.Save();
            }
            if (radiohaftalik.Checked == true)
            {
                Settings.YedeklemeAyarlari.Default.Mail = txtmail.Text;
                Settings.YedeklemeAyarlari.Default.Periyod_Turu = 2;
                Settings.YedeklemeAyarlari.Default.Hedef_Zaman = cmbhedefzaman.SelectedIndex + 1;
                Settings.YedeklemeAyarlari.Default.Save();
            }
            if (radioaylik.Checked == true)
            {
                Settings.YedeklemeAyarlari.Default.Mail = txtmail.Text;
                Settings.YedeklemeAyarlari.Default.Periyod_Turu = 3;
                Settings.YedeklemeAyarlari.Default.Hedef_Zaman = cmbhedefzaman.SelectedIndex + 1;
                Settings.YedeklemeAyarlari.Default.Save();
            }
        }

        private void frmayarlar_Yedekleme_Load(object sender, EventArgs e)
        {
            txtmail.Text = Settings.HesapAyarları.Default.HESAP_ADI;
            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 1)
            {
                radiogunluk.Checked = true;
                cmbhedefzaman.SelectedIndex = Settings.YedeklemeAyarlari.Default.Hedef_Zaman-1;
            }
            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 2)
            {
                radiohaftalik.Checked = true;
                cmbhedefzaman.SelectedIndex = Settings.YedeklemeAyarlari.Default.Hedef_Zaman-1;
            }
            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 3)
            {
                radioaylik.Checked = true;
                cmbhedefzaman.SelectedIndex = Settings.YedeklemeAyarlari.Default.Hedef_Zaman-1;
            }
        }
    }
}
