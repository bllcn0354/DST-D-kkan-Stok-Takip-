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
    public partial class frmstokislemlerimevcuturunekleme : Form
    {
        public frmstokislemlerimevcuturunekleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        int urunno,kar;
        private void frmstokislemlerimevcuturunekleme_Load(object sender, EventArgs e)
        {
            //resim ekleme
            btnkaydet.BackgroundImage = Image.FromFile("images/kaydet.png");
            verilerigoruntule();

            ////ürün türü item ekleme            
            cmburunturu.Items.Add("Telefon");
            cmburunturu.Items.Add("Bilgisayar");
            cmburunturu.Items.Add("Donanım");
            cmburunturu.Items.Add("Tablet");
            cmburunturu.Items.Add("Kamera");
            cmburunturu.Items.Add("Şarj Aleti");
            cmburunturu.Items.Add("Powerbank");
            cmburunturu.Items.Add("Kulaklık");
            cmburunturu.Items.Add("Kılıf");
            cmburunturu.Items.Add("Kırılmaz Cam");
            cmburunturu.Items.Add("Aksesuar");
            cmburunturu.Items.Add("Hoparlör");
            cmburunturu.Items.Add("Mikrofon");
            cmburunturu.Items.Add("USB");
            cmburunturu.Items.Add("Hafıza Kartı");
            cmburunturu.Items.Add("Batarya");

        }

        private void verilerigoruntule()
        {
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler where Urun_Adet=0", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        int eskiadet;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            txtno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmburunturu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtfiyat.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtgelisfiyat.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtgaranti.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtadet.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txttarih.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();

            if (txtno.Text.Length == 5)
            {
                txtno.Enabled = true;
                txtad.Enabled = true;
                txtmarka.Enabled = true;
                txtmodel.Enabled = true;
                cmburunturu.Enabled = true;
                txtfiyat.Enabled = true;
                txtgelisfiyat.Enabled = true;
                txtgaranti.Enabled = true;
                txtadet.Enabled = true;
            }
            else
            {
                txtno.Enabled = false;
                txtad.Enabled = false;
                txtmarka.Enabled = false;
                txtmodel.Enabled = false;
                cmburunturu.Enabled = false;
                txtfiyat.Enabled = false;
                txtgelisfiyat.Enabled = false;
                txtgaranti.Enabled = false;
                txtadet.Enabled = false;
            }
           
            eskiadet = Convert.ToInt32(txtadet.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtno.Text.Length == 5)
            {
                urunno = Convert.ToInt32(txtno.Text);
                timer1.Enabled = false;
            }
        }

        private void txtgelisfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtadet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void chbxgarantiyok_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxgarantiyok.Checked == true)
            {
                txtgaranti.Text = "Garanti Yok";
                txtgaranti.Enabled = false;
            }
            else
            {
                txtgaranti.Text = "";
                txtgaranti.Enabled = true;
            }
        }

        private void txtgaranti_TextChanged(object sender, EventArgs e)
        {
           
        }
      
        private void txtgaranti_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        int sayi1 = 0;
        private void txtgaranti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (txtgaranti.Text.Length == 0)
            {
                sayi1 = 1;
            }
            else
            {
                sayi1 = 0;
            }

            if (sayi1 == 1)
            {
                txtgaranti.Text += " Yıl";
            }
        }

        private void btnkaydet_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnkaydet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnkaydet.PerformClick();
            }
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tablo = new DataTable();
                if (txtarama.Text == "")
                {

                }
                if (txtarama.Text.Length > 0)
                {
                    OleDbDataAdapter da0 = new OleDbDataAdapter("Select * from Urunler where Urun_Adi like'" + txtarama.Text + "'", baglanti);
                    da0.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Urunler where Urun_Markasi like'" + txtarama.Text + "'", baglanti);
                    da1.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Urunler where Urun_Modeli like'" + txtarama.Text + "'", baglanti);
                    da2.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    OleDbDataAdapter da3 = new OleDbDataAdapter("Select * from Urunler where Urun_Turu like'" + txtarama.Text + "'", baglanti);
                    da3.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    OleDbDataAdapter da = new OleDbDataAdapter("Select * from Urunler where Urun_No like'" + Convert.ToInt32(txtarama.Text) + "'", baglanti);
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
                else
                {
                    OleDbDataAdapter da = new OleDbDataAdapter("Select * from Urunler", baglanti);
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                }
            }
            catch (Exception)
            {

               
            }    
        }

        private void txtarama_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtarama.Text == "Ara")
            {
                txtarama.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtno.Text != "")
            {
                if (txtad.Text != "")
                {
                    if (txtmarka.Text != "")
                    {
                        if (txtmodel.Text != "")
                        {
                            if (cmburunturu.Text != "")
                            {
                                if (txtfiyat.Text != "")
                                {
                                    if (txtgelisfiyat.Text != "")
                                    {
                                        if (txtgaranti.Text != "")
                                        {
                                            if (txtadet.Text != "")
                                            {
                                                if (txttarih.Text != "")
                                                {

                                                    DialogResult = MessageBox.Show("Ürünü eklemek istediğinize emin misiniz?","Bildirim",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                                                    if (DialogResult == DialogResult.Yes)
                                                    {
                                                        try
                                                        {
                                                            string aciklama = txtno.Text + " nolu ürün tamamen bitmiş halde iken (" + txtadet.Text + ") adedince (" + txtgelisfiyat.Text + ") birim geliş fiyatı ile"  +  " sisteme eklenmiştir."  ;
                                                            int gider;
                                                            int karr = 0;
                                                            gider = (Convert.ToInt32(txtgelisfiyat.Text)) * ((Convert.ToInt32(txtadet.Text)) - eskiadet);
                                                            baglanti.Close();
                                                            baglanti.Open();
                                                            OleDbCommand kmt = new OleDbCommand();
                                                            kmt.Connection = baglanti;
                                                            kmt.CommandText = ("INSERT INTO Raporlar([Tarih],[Gelir],[Gider],[Kar],[Aciklama]) VALUES (?,?,?,?,?)");
                                                            kmt.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                                                            kmt.Parameters.AddWithValue("@Gelir", karr);
                                                            kmt.Parameters.AddWithValue("@Gider", gider);
                                                            kmt.Parameters.AddWithValue("@Kar", karr);
                                                            kmt.Parameters.AddWithValue("@Aciklama", aciklama);
                                                            kmt.ExecuteNonQuery();
                                                            baglanti.Close();
                                                        }
                                                        catch (Exception)
                                                        {

                                                        }
                                                        kar = (Convert.ToInt32(txtfiyat.Text)) - (Convert.ToInt32(txtgelisfiyat.Text));
                                                        try
                                                        {
                                                            baglanti.Open();
                                                            OleDbCommand komut = new OleDbCommand();
                                                            komut.Connection = baglanti;
                                                            komut.CommandText = "UPDATE Urunler SET Urun_No='" + Convert.ToInt32(txtno.Text) + "', Urun_Adi='" + txtad.Text + "', Urun_Markasi='" + txtmarka.Text + "', Urun_Modeli='" + txtmodel.Text + "', Urun_Turu='" + cmburunturu.Text + "', Urun_Fiyati='" + Convert.ToInt32(txtfiyat.Text) + "', Urun_Gelis_Fiyati='" + Convert.ToInt32(txtgelisfiyat.Text) + "', Urun_Kar='" + kar + "', Urun_Garanti_Suresi='" + txtgaranti.Text + "', Urun_Adet='" + Convert.ToInt32(txtadet.Text) + "' WHERE Urun_No=" + urunno + "";
                                                            komut.ExecuteNonQuery();
                                                            baglanti.Close();

                                                            MessageBox.Show("Ekleme Tamamlandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            verilerigoruntule();
                                                        }
                                                        catch (Exception)
                                                        {

                                                           
                                                        }                                                       
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Tarihi kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Adet bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Garanti bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Geliş fiyatı bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fiyat bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ürün türü bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Model bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Marka bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ad bölümünü doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ürün no bölümünü doldurun.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}
