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
    public partial class frmayarlar_altbolum : Form
    {
        public frmayarlar_altbolum()
        {
            InitializeComponent();
        }

        private void frmayarlar_altbolum_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chkaltbolum.Checked == true)
            {
                Settings.altbolumayarlari.Default.altbolum = 1;
                Settings.altbolumayarlari.Default.Save();
                
            }
            else
            {
                Settings.altbolumayarlari.Default.altbolum = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkaltin.Checked == true)
            {
                Settings.altbolumayarlari.Default.altin = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.altin = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkdolar.Checked == true)
            {
                Settings.altbolumayarlari.Default.dolar = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.dolar = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkeuro.Checked == true)
            {
                Settings.altbolumayarlari.Default.euro = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.euro = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkhaber1.Checked == true)
            {
                Settings.altbolumayarlari.Default.haber1 = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.haber1 = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkhaber2.Checked == true)
            {
                Settings.altbolumayarlari.Default.haber2 = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.haber2 = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chksaat.Checked == true)
            {
                Settings.altbolumayarlari.Default.saat = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.saat = 0;
                Settings.altbolumayarlari.Default.Save();
            }
            if (chkyapımci.Checked == true)
            {
                Settings.altbolumayarlari.Default.yapımci = 1;
                Settings.altbolumayarlari.Default.Save();
            }
            else
            {
                Settings.altbolumayarlari.Default.yapımci = 0;
                Settings.altbolumayarlari.Default.Save();
            }

        }

        private void frmayarlar_altbolum_Load(object sender, EventArgs e)
        {
            if (Settings.altbolumayarlari.Default.altbolum == 1)
            {
                chkaltbolum.Checked = true;
                
            }
            else
            {
                chkaltbolum.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.altin == 1)
            {
                chkaltin.Checked = true;

            }
            else
            {
                chkaltin.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.dolar == 1)
            {
                chkdolar.Checked = true;

            }
            else
            {
                chkdolar.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.euro == 1)
            {
                chkeuro.Checked = true;

            }
            else
            {
                chkeuro.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.haber1 == 1)
            {
                chkhaber1.Checked = true;

            }
            else
            {
                chkhaber1.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.haber2 == 1)
            {
                chkhaber2.Checked = true;

            }
            else
            {
                chkhaber2.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.yapımci == 1)
            {
                chkyapımci.Checked = true;

            }
            else
            {
                chkyapımci.Checked = false;
            }
            if (Settings.altbolumayarlari.Default.saat == 1)
            {
                chksaat.Checked = true;

            }
            else
            {
                chksaat.Checked = false;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkaltin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkaltin.Checked==true)
            {
                Settings.altbolumayarlari.Default.altin = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.altin = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkdolar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdolar.Checked == true)
            {
                Settings.altbolumayarlari.Default.dolar = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.dolar = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkeuro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeuro.Checked == true)
            {
                Settings.altbolumayarlari.Default.euro = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.euro = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkhaber1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhaber1.Checked == true)
            {
                Settings.altbolumayarlari.Default.haber1 = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.haber1 = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkhaber2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhaber2.Checked == true)
            {
                Settings.altbolumayarlari.Default.haber2 = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.haber2 = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkyapımci_CheckedChanged(object sender, EventArgs e)
        {
            if (chkyapımci.Checked == true)
            {
                Settings.altbolumayarlari.Default.yapımci = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.yapımci = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chksaat_CheckedChanged(object sender, EventArgs e)
        {
            if (chksaat.Checked == true)
            {
                Settings.altbolumayarlari.Default.saat = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.saat = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }

        private void chkaltbolum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkaltbolum.Checked == true)
            {
                Settings.altbolumayarlari.Default.altbolum = 1;
            }
            else
            {
                Settings.altbolumayarlari.Default.altbolum = 0;
            }
            Settings.altbolumayarlari.Default.Save();
        }
    }
}
