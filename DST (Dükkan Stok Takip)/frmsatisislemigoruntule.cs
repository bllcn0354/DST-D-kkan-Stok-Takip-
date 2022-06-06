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
    public partial class frmsatisislemigoruntule : Form
    {
        public frmsatisislemigoruntule()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");

        private void txtadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txtadet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmsatisislemigoruntule_Load(object sender, EventArgs e)
        {
            txtnot.Select();
        }

        private void txtadet_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        int gelisfiyati;
        string gelisfiyatitext;
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtadet.Text == "0")
            {
                MessageBox.Show("Adede 0 giremezsiniz", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtadet.Text = "1";
            }


            if (txtadet.Text != "")
            {
               
               
                    /////////////////////////////////////////// veri tabanı geliş fiyatı öğrenme

                    baglanti.Open();
                    OleDbCommand komut1 = new OleDbCommand();
                    komut1.Connection = baglanti;
                    komut1.CommandText = "SELECT * FROM Urunler WHERE Urun_No=" + Convert.ToInt32(txturunno.Text) + "";
                    OleDbDataReader dr = komut1.ExecuteReader();
                    while (dr.Read())
                    {
                        gelisfiyatitext = Convert.ToDecimal(dr[6]).ToString();                        
                    }
                    gelisfiyati = Convert.ToInt32(gelisfiyatitext);
                    baglanti.Close();

                    ///////////////////////////////////////////
                    txtkar.Text = Convert.ToString((Convert.ToInt32(txtfiyat.Text) - gelisfiyati) * (Convert.ToInt32(txtadet.Text)));
                    txttoplamtutar.Text = Convert.ToString(Convert.ToInt32(txtfiyat.Text) * Convert.ToInt32(txtadet.Text));
                    //////////////////////////////////////////////////////////// veri tabanına kayıt

                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE Satis_İslemleri SET Urun_Adedi='" + Convert.ToInt32(txtadet.Text) + "', Toplam_Tutar='" + Convert.ToInt32(txttoplamtutar.Text) + "', Kar='" + Convert.ToInt32(txtkar.Text) + "' WHERE Satis_No=" + Convert.ToInt32(txtsatisno.Text) + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    /////////////////////////////////////////////////////////////
                    MessageBox.Show("Güncelleme Tamamlandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                

                
            }
        }
    }
}
