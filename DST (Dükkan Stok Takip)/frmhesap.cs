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
    public partial class frmhesap : Form
    {
        public frmhesap()
        {
            InitializeComponent();
        }

        private void frmhesap_Load(object sender, EventArgs e)
        {
            txthesapadi.Text = Settings.HesapAyarları.Default.HESAP_ADI;
            txtserial_key.Text = Settings.HesapAyarları.Default.SERIAL_KEY;
            txtsuresi.Text = Settings.HesapAyarları.Default.SURESI;
            txttamad.Text = Settings.HesapAyarları.Default.TAM_AD;
            txttur.Text = Settings.HesapAyarları.Default.LISANS_TURU;
            txtversiyon.Text = Settings.HesapAyarları.Default.VERSIYON;
            Settings.HesapAyarları.Default.Save();
        }
    }
}
