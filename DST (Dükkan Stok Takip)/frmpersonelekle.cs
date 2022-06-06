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
    public partial class frmpersonelekle : Form
    {
        public frmpersonelekle()
        {
            InitializeComponent();
        }
        //veri tabanaı bağlantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");


        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            if (txtpersonelad.Text !="")
            {
                if (txtpersonelsoyad .Text != "")
                {
                    if (txtkullaniciadi.Text != "")
                    {
                        if (txtsifre.Text != "")
                        {
                            if (cmbxkullanicituru.Text != "")
                            {
                                try
                                {
                                    //kullanıcı ekleme
                                    OleDbCommand komut = new OleDbCommand("INSERT INTO Personel (Personel_Ad,Personel_Soyad,Maas,Personel_Kullanici_Adi,Personel_Sifre,Personel_Turu) values ('" + txtpersonelad.Text.ToString() + "','" + txtpersonelsoyad.Text.ToString() + "','" + txtmaas.Text +"','" + txtkullaniciadi.Text.ToString() + "','" + txtsifre.Text.ToString() + "','" + cmbxkullanicituru.Text.ToString() + "')", baglanti);
                                    komut.ExecuteNonQuery();
                                    MessageBox.Show("Kullanıcı Başarıyla Eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    baglanti.Close();
                                    this.Close();
                                }
                                catch (OleDbException ex)
                                {
                                    if (ex.ErrorCode == -2147467259)
                                    {
                                        MessageBox.Show("Girmiş olduğunuz kullanıcı adı kullanılmakta!!!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Eksik yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Eksik yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Eksik yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Eksik yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
            baglanti.Close();
          
            
        }

        private void frmpersonelekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Personel", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Open();
            da.Fill(tablo);
            frmpersonelislemleri frmpersonelislemleri = new frmpersonelislemleri();
            frmpersonelislemleri.dataGridView1.DataSource = tablo;
            frmpersonelislemleri.dataGridView1.Refresh();
            baglanti.Close();

            txtkullaniciadi.Text = "";
            txtpersonelad.Text = "";
            txtpersonelno.Text = "";
            txtpersonelsoyad.Text = "";
            txtsifre.Text = "";
        }

        private void txtpersonelsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
