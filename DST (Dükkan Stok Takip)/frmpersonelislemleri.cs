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
    public partial class frmpersonelislemleri : Form
    {
        public frmpersonelislemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        public string kullaniciadicagir;

        private void frmpersonelislemleri_Load(object sender, EventArgs e)
        {
            verilerigoruntuler();
        }

        private void verilerigoruntuler()
        {
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Personel", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        frmpersonelekle frmpersonelekle = new frmpersonelekle();
        private void btnekle_Click(object sender, EventArgs e)
        {
          
            frmpersonelekle.ShowDialog();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Personel", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
       
      public string perno,perad,persoyad,kullaniciadi,sifre,tur,maas;

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmaas_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtpersonelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            if (txtkullaniciadi.Text.Length<1)
            {
                MessageBox.Show("Kullanıcı adını boş bırakamazsınız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtsifre.Text.Length < 1)
                {
                    MessageBox.Show("Şifreyi boş bırakamazsınız.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult = MessageBox.Show("Kullanıcıyı güncellemek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "UPDATE Personel SET Personel_Ad='" + txtpersonelad.Text + "', Personel_Soyad='" + txtpersonelsoyad.Text + "', Maas='" + txtmaas.Text + "', Personel_Kullanici_Adi='" + txtkullaniciadi.Text + "', Personel_Sifre='" + txtsifre.Text + "', Personel_Turu='" + cmbxkullanicituru.Text + "' WHERE Personel_Kullanici_Adi='" + kullaniciadidepolama + "'";
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Güncelleme Tamamlandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        verilerigoruntuler();
                    }
                }
            }

            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text != kullaniciadicagir)
            {
                if (txtkullaniciadi.Text != "" || txtpersonelno.Text!="")
                {
                    DialogResult = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "delete from Personel where Personel_Kullanici_Adi='" + txtkullaniciadi.Text + "'";
                        komut.ExecuteNonQuery();
                        baglanti.Close();


                        MessageBox.Show("Kullanıcı silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        verilerigoruntuler();

                        txtkullaniciadi.Text = "";
                        txtpersonelad.Text = "";
                        txtpersonelno.Text = "";
                        txtpersonelsoyad.Text = "";
                        txtsifre.Text = "";
                        cmbxkullanicituru.SelectedIndex = -1;

                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı seçmediniz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kendinizi Silemezsiniz!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string kullaniciadidepolama;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           

            perno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            perad= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            persoyad= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maas = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciadi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sifre= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tur= dataGridView1.CurrentRow.Cells[6].Value.ToString();
           

            txtpersonelno.Text = perno;
            txtpersonelad.Text = perad;
            txtpersonelsoyad.Text = persoyad;
            txtmaas.Text = maas;
            txtkullaniciadi.Text = kullaniciadi;
            txtsifre.Text = sifre;
            cmbxkullanicituru.Text = tur;


            kullaniciadidepolama = txtkullaniciadi.Text;

            if (txtkullaniciadi.Text != "")
            {
                btnguncelle.Enabled = true;
            }
            else
            {
                btnguncelle.Enabled = false;
            }

            if (btnguncelle.Enabled == true)
            {
                txtkullaniciadi.Enabled = true;
                txtpersonelad.Enabled = true;
                txtmaas.Enabled = true;
                txtpersonelsoyad.Enabled = true;
                txtsifre.Enabled = true;
                cmbxkullanicituru.Enabled = true;
            }
            else
            {
                txtkullaniciadi.Enabled = false;
                txtpersonelad.Enabled = false;
                txtpersonelno.Enabled = false;
                txtpersonelsoyad.Enabled = false;
                txtsifre.Enabled = false;
                cmbxkullanicituru.Enabled = false;
                txtmaas.Enabled = false; 
            }


        }
    }
}
