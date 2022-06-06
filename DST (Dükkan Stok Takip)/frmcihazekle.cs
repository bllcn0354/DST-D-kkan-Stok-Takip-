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
    public partial class frmcihazekle : Form
    {
        public frmcihazekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");

        public int acilisamaci = 0;


        private void frmcihazekle_Load(object sender, EventArgs e)
        {
            // resim yükleme
            btnkaydet.BackgroundImage = Image.FromFile("images/kaydet.png");
            btnkaydet.BackgroundImageLayout = ImageLayout.Zoom;
            button1.BackgroundImage = Image.FromFile("images/çık.png");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            //seçimler            
            txttarih.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btnsifre1_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre1.Text;
            btnsifre1.BackColor = Color.DarkKhaki;
            btnsifre1.Enabled = false;
        }

        private void btnsifre2_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre2.Text;
            btnsifre2.BackColor = Color.DarkKhaki;
            btnsifre2.Enabled = false;
        }

        private void btnsifre3_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre3.Text;
            btnsifre3.BackColor = Color.DarkKhaki;
            btnsifre3.Enabled = false;
        }

        private void btnsifre4_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre4.Text;
            btnsifre4.BackColor = Color.DarkKhaki;
            btnsifre4.Enabled = false;
        }

        private void btnsifre5_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre5.Text;
            btnsifre5.BackColor = Color.DarkKhaki;
            btnsifre5.Enabled = false;
        }

        private void btnsifre6_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre6.Text;
            btnsifre6.BackColor = Color.DarkKhaki;
            btnsifre6.Enabled = false;
        }

        private void btnsifre7_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre7.Text;
            btnsifre7.BackColor = Color.DarkKhaki;
            btnsifre7.Enabled = false;
        }

        private void btnsifre8_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre8.Text;
            btnsifre8.BackColor = Color.DarkKhaki;
            btnsifre8.Enabled = false;
        }

        private void btnsifre9_Click(object sender, EventArgs e)
        {
            txtsifre.Text += btnsifre9.Text;
            btnsifre9.BackColor = Color.DarkKhaki;
            btnsifre9.Enabled = false;
        }

        private void btnyenidendene_Click(object sender, EventArgs e)
        {
            btnsifre1.BackColor = Color.Transparent;
            btnsifre2.BackColor = Color.Transparent;
            btnsifre3.BackColor = Color.Transparent;
            btnsifre4.BackColor = Color.Transparent;
            btnsifre5.BackColor = Color.Transparent;
            btnsifre6.BackColor = Color.Transparent;
            btnsifre7.BackColor = Color.Transparent;
            btnsifre8.BackColor = Color.Transparent;
            btnsifre9.BackColor = Color.Transparent;
            btnsifre1.Enabled = true;
            btnsifre2.Enabled = true;
            btnsifre3.Enabled = true;
            btnsifre4.Enabled = true;
            btnsifre5.Enabled = true;
            btnsifre6.Enabled = true;
            btnsifre7.Enabled = true;
            btnsifre8.Enabled = true;
            btnsifre9.Enabled = true;
            txtsifre.Text = "";
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
                cmbdurum.Enabled = false;

                if (txtmusteriad.Text != "")
                {
                    if (txtmusterisoyad.Text != "")
                    {
                        if (txttel.Text != "" || txttel.Text.Length == 11)
                        {
                            if (txtcihazadi.Text != "")
                            {
                                if (txtariza.Text != "")
                                {
                                    if (txtkullaniciadi.Text != "")
                                    {
                                        try
                                        {
                                            baglanti.Open();
                                            OleDbCommand komut = new OleDbCommand("INSERT INTO Cihaz_Tamir ([Cihaz_Adı],[Cihaz_Ariza],[Cihaz_Sifre],[Musteri_Ad],[Musteri_Soyad],[Musteri_Adres],[Musteri_Telefon_No],[Durum],[Maliyet],[Ucret],[kar],[PersonelK_Ad],[Not],[Tarih]) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)", baglanti);
                                            komut.Parameters.AddWithValue("@Cihaz_Adı", txtcihazadi.Text);
                                            komut.Parameters.AddWithValue("@Cihaz_Ariza", txtariza.Text);
                                            komut.Parameters.AddWithValue("@Cihaz_Sifre", txtsifre.Text);
                                            komut.Parameters.AddWithValue("@Musteri_Ad", txtmusteriad.Text);
                                            komut.Parameters.AddWithValue("@Musteri_Soyad", txtmusterisoyad.Text);
                                            komut.Parameters.AddWithValue("@Musteri_Adres", txtadres.Text);
                                            komut.Parameters.AddWithValue("@Musteri_Telefon_No", txttel.Text);
                                            komut.Parameters.AddWithValue("@Durum", cmbdurum.Text);   
                                            komut.Parameters.AddWithValue("@Maliyet", txtmaliyet.Text);                                              
                                            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
                                            komut.Parameters.AddWithValue("@kar", txtkar.Text);   
                                            komut.Parameters.AddWithValue("@PersonelK_Ad", txtkullaniciadi.Text);
                                            komut.Parameters.AddWithValue("@Not", txtnot.Text);
                                            komut.Parameters.AddWithValue("@Tarih", DateTime.Now.Date.ToShortDateString());
                                            komut.ExecuteNonQuery();
                                            MessageBox.Show("Cihaz Arıza Kaydı Tamamlandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            baglanti.Close();
                                            txtadres.Text = null;
                                        txtariza.Text = null;
                                        txtcihazadi.Text = null;
                                        txtkar.Text = null;
                                        txtkullaniciadi.Text = null;
                                        txtmaliyet.Text = null;
                                        txtmusteriad.Text = null;
                                        txtmusterisoyad.Text = null;
                                        txtnot.Text = null;
                                        txtsifre.Text = null;
                                        txttarih.Text = null;
                                        txttel.Text = null;
                                        txtUcret.Text = null;
                                        cmbdurum.Text = null;
                                        btnyenidendene.PerformClick();
                                        this.Hide();
                                        }
                                        catch (Exception)
                                        {
                                            baglanti.Close();
                                            MessageBox.Show("Bir sorunla karşılaşıldı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            this.Hide();
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Kullanıcı Bulunamıyor!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Arızayı belirtin", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cihazın adını belirtin", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Telefon numarsını 11 haneli olacak şekilde doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Müşteri ad-soyad bölümlerini doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri ad-soyad bölümlerini doldurun.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        int kar;
        private void txtUcret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kar = (Convert.ToInt32(txtUcret.Text)) - (Convert.ToInt32(txtmaliyet.Text));
                txtkar.Text = kar.ToString();
            }
            catch (Exception)
            {

               
            }

            
        }

        private void txtUcret_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmaliyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
