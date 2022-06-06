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
    public partial class frmmusterigoruntule : Form
    {
        public frmmusterigoruntule()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txttel.Text.Length == 11)
            {
                if (txtad.Text != "")
                {
                    if (txtsoyad.Text != "")
                    {
                        if (txttc.Text.Length == 11)
                        {
                            if (txtadres.Text != "")
                            {
                                try
                                {
                                    ////////////////////////////////////////
                                    baglanti.Open();
                                    OleDbCommand komut = new OleDbCommand();
                                    komut.Connection = baglanti;
                                    komut.CommandText = "UPDATE Musteri SET Musteri_Tel_No='" + txttel.Text + "', Musteri_Ad='" + txtad.Text + "', Musteri_Soyad='" + txtsoyad.Text + "', Musteri_TC='" + txttc.Text + "', Musteri_Adres='" + txtadres.Text + "' WHERE Musteri_Satis_No=" + Convert.ToInt32(txtmusterisatisno.Text) + "";
                                    komut.ExecuteNonQuery();
                                    baglanti.Close();
                                    ///////////////////////////////////////
                                    MessageBox.Show("Güncelleme tamamlandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Güncelleme tamamlanamadı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Boş veri eklenemez. Lütfen gerekli bölümleri doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Boş veri eklenemez. Lütfen gerekli bölümleri doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Boş veri eklenemez. Lütfen gerekli bölümleri doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Boş veri eklenemez. Lütfen gerekli bölümleri doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Boş veri eklenemez. Lütfen gerekli bölümleri doldurun.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmmusterigoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}
