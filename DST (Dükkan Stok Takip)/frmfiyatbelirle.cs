using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmfiyatbelirle : Form
    {
        public frmfiyatbelirle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
       public int islemno;
        private void button1_Click(object sender, EventArgs e)
        {
            int kar = Convert.ToInt32(txtfyt.Text) - Convert.ToInt32(txtmaliyet.Text);
            string karr = kar.ToString();
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Ucret='" + txtfyt.Text + "', Maliyet='" + txtmaliyet.Text + "', Kar='" + karr + "' WHERE İslem_No=" + islemno + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtfyt.Text = null;
            this.Hide();
            
        }

        private void txtfyt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmaliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmfiyatbelirle_Load(object sender, EventArgs e)
        {

        }
    }
}
