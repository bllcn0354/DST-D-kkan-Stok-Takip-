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
    public partial class frmayarlar_muhasebeayarlari : Form
    {
        public frmayarlar_muhasebeayarlari()
        {
            InitializeComponent();
        }

        private void frmmuhasebeayarlari_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 31; i++)
            {
                cmbgun.Items.Add(i);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (cmbgun.SelectedIndex > 0)
            {
                Settings.MuhasebeAyarlari.Default.Maas_Odeme_Gunu = cmbgun.SelectedIndex + 1;
                Settings.MuhasebeAyarlari.Default.Save();
            }
            if (cmbgun.SelectedIndex < 0)
            {
                Settings.MuhasebeAyarlari.Default.Maas_Odeme_Gunu = 0;
                Settings.MuhasebeAyarlari.Default.Save();
            }
            Settings.MuhasebeAyarlari.Default.Save();
        }
    }
}
