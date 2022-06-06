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
    public partial class frmayarlar_GenelAyarlar : Form
    {
        public frmayarlar_GenelAyarlar()
        {
            InitializeComponent();
        }

        private void frmayarlar_GenelAyarlar_Load(object sender, EventArgs e)
        {
            cmbmod.SelectedIndex = 0;
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                chkses.Checked = true;
            }
            if (Settings.GenelAyarlar.Default.Ses == 0)
            {
                chkses.Checked = false;
            }
        }

        private void chkses_CheckedChanged(object sender, EventArgs e)
        {
            if (chkses.Checked == true)
            {
                Settings.GenelAyarlar.Default.Ses = 1;
            }
            if(chkses.Checked==false)
            {
                Settings.GenelAyarlar.Default.Ses = 0;
            }
            Settings.GenelAyarlar.Default.Save();
        }

        private void frmayarlar_GenelAyarlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.GenelAyarlar.Default.Save();
        }

        private void cmbmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmod.SelectedIndex == 0)
            {
                Settings.GenelAyarlar.Default.Mod = 1000;
            }
            if (cmbmod.SelectedIndex < 0)
            {
                Settings.GenelAyarlar.Default.Mod = 0;
            }
            Settings.GenelAyarlar.Default.Save();
        }

        private void shkversiyonmail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkversiyonmail.Checked == true)
            {
                Settings.GenelAyarlar.Default.Yeni_Versiyon_Bildirim = 1;
            }
            if (chkversiyonmail.Checked == false)
            {
                Settings.GenelAyarlar.Default.Yeni_Versiyon_Bildirim = 0;
            }
            Settings.GenelAyarlar.Default.Save();
        }
    }
}
