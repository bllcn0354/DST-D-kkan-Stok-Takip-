using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmsatismusteribilgisi : Form
    {
        public frmsatismusteribilgisi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            frmsaturunbilgisi frmsaturunbilgisi = new frmsaturunbilgisi();

            //müşteri bilgisi bölümü ekleme
            if (txtmusteriadres.Text.Length>0 && txtmusteritelno.Text.Length>0 && txtmusterisoyad.Text.Length>0 && txtmusteritc.Text.Length>0)
            {
               frmsatisislemleri.faturayazisi += Environment.NewLine + Environment.NewLine + "Müşteri No: " + txtmusteriad.Text + Environment.NewLine + "Müşteri Adı: " + txtmusteritelno.Text + Environment.NewLine + "Müşteri Soyad: " + txtmusterisoyad.Text + Environment.NewLine + "Müşteri TC: " + txtmusteritc.Text + Environment.NewLine + "Müşteri Adres: " + txtmusteriadres.Text;
            }

            if (txtmusteritelno.Text != "")
            {
                if (txtmusterisoyad.Text != "")
                {
                    if (txtmusteritc.Text != "")
                    {
                        if (txtmusteriadres.Text != "")
                        {
                            

                            OleDbCommand komut = new OleDbCommand("INSERT INTO Musteri (Musteri_Tel_No,Musteri_Ad,Musteri_Soyad,Musteri_TC,Musteri_Adres,Musteri_Satis_No,Tarih) values ('" + txtmusteritelno.Text + "','" + txtmusteriad.Text + "','" + txtmusterisoyad.Text + "','" + txtmusteritc.Text + "','" + txtmusteriadres.Text + "','" + Convert.ToInt32(txtmusterisatisno.Text) + "','" + DateTime.Now.Date.ToShortDateString() + "')", baglanti);
                            //ürünnumarası aynı olan bir değer girildiğinde kayıt yapmadan uyarı veriyor.                                                              
                            try
                            {
                                baglanti.Open();
                                    komut.ExecuteNonQuery();
                                    MessageBox.Show("Müşteri kaydedildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frmanasayfa frmanasayfa1 = new frmanasayfa();

                                txtmusteritelno.Text = "";
                                txtmusteriadres.Text = "";
                                txtmusteriad.Text = "";
                                txtmusterisoyad.Text = "";
                                txtmusteritc.Text = "";
                                baglanti.Close();
                                this.Close();


                            }

                            catch (OleDbException ex)
                            {
                                if (ex.ErrorCode == -2147467259)
                                {
                                    baglanti.Close();
                                    MessageBox.Show("Girmiş olduğunuz TC kimlik numarası başkasına ait!!!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Bilgileri kontrol edin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bilgileri kontrol edin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgileri kontrol edin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol edin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmsatismusteribilgisi_Load(object sender, EventArgs e)
        {
            btnkaydet.BackgroundImage = Image.FromFile("images/kaydet.png");
        }

        private void txtmusterisoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmusteritelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmusteritc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
