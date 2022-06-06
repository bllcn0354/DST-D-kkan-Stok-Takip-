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
    public partial class frmstokislemleriurunekleme : Form
    {
        public frmstokislemleriurunekleme()
        {
            InitializeComponent();
        }
        //veri tabanaı bağlantısı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        
        
        //değişkenler
        int glsfyt;
        int stsfyt;
        int urnadt;
        int kar;

        private void frmstokislemleriurunekleme_Load(object sender, EventArgs e)
        {
            //resim yükleme
            btnkaydet.BackgroundImage = Image.FromFile("images/kaydet.png");


            //ilk seçilen bölüm
            txturunno.Select();
            //tarih
            txttarih.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            //ürün türü item ekleme            
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

            // değer atama
            //urunno gireilecek karkter sayısını belirtme

            txturunno.MaxLength = 5;

        }  


          
               

       

        private void txturungelisfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txturunsatisfiyatii_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           
        }

        private void txturunadedi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txturungelisfiyati_TextChanged(object sender, EventArgs e)
        {
            if (txturungelisfiyati.Text != "" && txturunsatisfiyatii.Text != "" && txturunadedi.Text != "" && txturunadedi.Text!="0")
            {
                glsfyt = Convert.ToInt32(txturungelisfiyati.Text);
                stsfyt = Convert.ToInt32(txturunsatisfiyatii.Text);
                urnadt = Convert.ToInt32(txturunadedi.Text);
                if (urnadt != 0)
                {
                    kar = stsfyt - glsfyt;
                }
                else
                {
                    kar = stsfyt - glsfyt;
                }

                txturunkar.Text = kar.ToString();
            }
            else
            {
                txturunkar.Text = "0";
            }

        }

        private void txturunsatisfiyatii_TextChanged(object sender, EventArgs e)
        {
            if (txturungelisfiyati.Text != "" && txturunsatisfiyatii.Text != "" && txturunadedi.Text != "" && txturunadedi.Text != "0")
            {
                glsfyt = Convert.ToInt32(txturungelisfiyati.Text);
                stsfyt = Convert.ToInt32(txturunsatisfiyatii.Text);
                urnadt = Convert.ToInt32(txturunadedi.Text);
                if(urnadt>0)
                {
                    kar = stsfyt - glsfyt;
                }
                else
                {
                    kar = stsfyt - glsfyt;
                }
                
                txturunkar.Text = kar.ToString();
            }
            else
            {
                txturunkar.Text = "0";
            }

        }

        private void txturunadedi_TextChanged(object sender, EventArgs e)
        {
            if (txturungelisfiyati.Text != "" && txturunsatisfiyatii.Text != "" && txturunadedi.Text!="" && txturunadedi.Text != "0")
            {
                glsfyt = Convert.ToInt32(txturungelisfiyati.Text);
                stsfyt = Convert.ToInt32(txturunsatisfiyatii.Text);
                urnadt = Convert.ToInt32(txturunadedi.Text);
                if (urnadt != 0)
                {
                    kar = (stsfyt - glsfyt);
                }              

                txturunkar.Text = kar.ToString();
            }
            else
            {
                txturunkar.Text = "0";
            }
        }

        private void txturunno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       
        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            if (chbxgarantiyok.Checked == true)
            {
                txtgarantisuresi.Text = "Garanti Yok";
            }

                //kontrol
                if (txturunno.Text != "" && txturunno.Text.Length == 5)
            {
                lbluyari1.Visible = false;
                if (txturunad.Text != "")
                {
                    lbluyari2.Visible = false;
                    if (txturunmarkasi.Text != "")
                    {
                        lbluyari3.Visible = false;
                        if (txturunmodeli.Text != "")
                                {
                            lbluyari4.Visible = false;
                            if (cmburunturu.SelectedIndex >= 0)
                                    {
                                lbluyari5.Visible = false;
                                if (txturunadedi.Text != "0" && txturunadedi.Text != "")
                                        {
                                    lbluyari6.Visible = false;
                                    if (txtgarantisuresi.Text != "")
                                            {
                                        lbluyari7.Visible = false;
                                        if (txturungelisfiyati.Text != "")
                                                {
                                            lbluyari8.Visible = false;
                                            if (txturunsatisfiyatii.Text != "" && txturunsatisfiyatii.Text != "0")
                                                    {
                                                lbluyari9.Visible = false;
                                                if (txturunkar.Text != "")
                                                        {
                                                    lbluyari9.Visible = false;
                                                    lbluyari8.Visible = false;
                                                    if (txttarih.Text != "")
                                                            {

                                                       
                                                        if (chbxgarantiyok.Checked == true)
                                                        {



                                                            OleDbCommand komut = new OleDbCommand("INSERT INTO Urunler (Urun_No,Urun_Adi,Urun_Markasi,Urun_Modeli,Urun_Turu,Urun_Fiyati,Urun_Gelis_Fiyati,Urun_Kar,Urun_Garanti_Suresi,Urun_Adet,Urun_Gelis_Tarihi) values ('" + txturunno.Text.ToString() + "','" + txturunad.Text.ToString() + "','" + txturunmarkasi.Text.ToString() + "','" + txturunmodeli.Text.ToString() + "','" + cmburunturu.Text.ToString() + "','" + txturunsatisfiyatii.Text.ToString() + "','" + txturungelisfiyati.Text.ToString() + "','" + txturunkar.Text.ToString() + "','" + chbxgarantiyok.Text.ToString() + "','" + txturunadedi.Text.ToString() + "','" + DateTime.Now.Date.ToShortDateString() + "')", baglanti);
                                                            //ürünnumarası aynı olan bir değer girildiğinde kayıt yapmadan uyarı veriyor.                                                              
                                                            try
                                                            {
                                                                DialogResult = MessageBox.Show("Ürünü eklemek istediğinize emin misiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                                                if (DialogResult == DialogResult.Yes)
                                                                {
                                                                    komut.ExecuteNonQuery();
                                                                    MessageBox.Show("Ürün envantere eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    frmanasayfa frmanasayfa1 = new frmanasayfa();
                                                                }
                                                               
                                                               

                                                            }

                                                            catch (OleDbException ex)
                                                            {
                                                                if (ex.ErrorCode == -2147467259)
                                                                {
                                                                    MessageBox.Show("Girmiş olduğunuz ürün numarası kullanılmakta!!!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    lbluyari1.Visible = true;
                                                                    txturunno.Select();

                                                                }

                                                            }
                                                            //
                                                        }
                                                        else
                                                        {
                                                            OleDbCommand komut = new OleDbCommand("INSERT INTO Urunler (Urun_No,Urun_Adi,Urun_Markasi,Urun_Modeli,Urun_Turu,Urun_Fiyati,Urun_Gelis_Fiyati,Urun_Kar,Urun_Garanti_Suresi,Urun_Adet,Urun_Gelis_Tarihi) values ('" + txturunno.Text.ToString() + "','" + txturunad.Text.ToString() + "','" + txturunmarkasi.Text.ToString() + "','" + txturunmodeli.Text.ToString() + "','" + cmburunturu.Text.ToString() + "','" + txturunsatisfiyatii.Text.ToString() + "','" + txturungelisfiyati.Text.ToString() + "','" + txturunkar.Text.ToString() + "','" + txtgarantisuresi.Text.ToString() + "','" + txturunadedi.Text.ToString() + "','" + txttarih.Text.ToString() + "')", baglanti);
                                                            //ürünnumarası aynı olan bir değer girildiğinde kayıt yapmadan uyarı veriyor.                                                              
                                                            try
                                                            {
                                                                komut.ExecuteNonQuery();
                                                                MessageBox.Show("Ürün envantere eklendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                frmanasayfa frmanasayfa1 = new frmanasayfa();

                                                            }

                                                            catch (OleDbException ex)
                                                            {
                                                                if (ex.ErrorCode == -2147467259)
                                                                {
                                                                    MessageBox.Show("Girmiş olduğunuz ürün numarası kullanılmakta!!!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    lbluyari1.Visible = true;
                                                                    txturunno.Select();

                                                                }

                                                            }
                                                            //
                                                        }
                                                        try
                                                        {
                                                            string aciklama = txturunno.Text + " nolu ürün (" + txturunadedi.Text + ") adedince (" + txturungelisfiyati.Text + ") birim fiyatı ile" + " sisteme eklenmiştir.";
                                                            int gider;
                                                            int karr = 0;
                                                            gider = ((Convert.ToInt32(txturungelisfiyati.Text)) * (Convert.ToInt32(txturunadedi.Text)));
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
                                                       
                                                    }
                                                            else
                                                            {
                                                        
                                                                MessageBox.Show("Lütfen tarihi kontrol edin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }
                                                        }
                                                        else
                                                        {
                                                              lbluyari9.Visible = true;
                                                              lbluyari8.Visible = true;
                                                            MessageBox.Show("Lütfen geliş fiyatı ve satış fiyatını doğru doldurduğunuzdan emin olunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txturungelisfiyati.Select();
                                                        }
                                                    }
                                                    else
                                                    {
                                                lbluyari9.Visible = true;
                                                MessageBox.Show("Lütfen ürün satış fiyatı bölümünü doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        txturunsatisfiyatii.Select();
                                                    }
                                                }
                                                else
                                                {
                                            lbluyari8.Visible = true;
                                            MessageBox.Show("Lütfen ürün geliş fiyatı bölümünü doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    txturungelisfiyati.Select();
                                                }
                                            }
                                            else
                                            {
                                        lbluyari7.Visible = true;
                                                MessageBox.Show("Lütfen ürün garanti süresini doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txtgarantisuresi.Select();
                                            }
                                        }
                                        else
                                        {
                                    lbluyari6.Visible = true;
                                            MessageBox.Show("Lütfen ürün adedini doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txturunadedi.Select();
                                        }
                                    }
                                    else
                                    {
                                lbluyari5.Visible = true;
                                        MessageBox.Show("Lütfen ürün türünü seçiniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        cmburunturu.Select();
                                    }
                                }
                                else
                                {
                            lbluyari4.Visible = true;
                                    MessageBox.Show("Lütfen modeli bölümünü doldurunuz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txturunmodeli.Select();
                                }
                    }
                            else
                            {
                        lbluyari3.Visible = true;
                                MessageBox.Show("Lütfen marksaı bölümünü doldurunuz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txturunmarkasi.Select();
                            }
                }
                        else
                        {
                    lbluyari2.Visible = true;
                            MessageBox.Show("Lütfen ürün adı bölümünü doldurunuz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txturunad.Select();
                        }
            }
                    else
                    {
                lbluyari1.Visible = true;
                        MessageBox.Show("Lütfen ürün numarası bölümünü 5(beş) haneli olacak şekilde rakamlarla doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txturunno.Select();
                    }

            baglanti.Close();
            frmanasayfa frmanasayfa = new frmanasayfa();

            //datagridview e veri alma            
            
            baglanti.Close();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler", baglanti);
            baglanti.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            frmanasayfa.dataGridView1.DataSource = tablo;
            baglanti.Close();
           

        }
        int sayi1 = 0;
        private void txtgarantisuresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);           

            if (txtgarantisuresi .Text.Length == 0)
            {
                sayi1 = 1;
            }
            else
            {
                sayi1 = 0;
            }

            if (sayi1 == 1)
            {
                txtgarantisuresi .Text += " Yıl";
            }
        }

        private void txtgarantisuresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txturunsatisfiyatii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnkaydet.PerformClick();
            }
        }

        private void txturunno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturunad.Select();
            }
        }

        private void txturunad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturunmarkasi.Select();
            }
        }

       

        private void txturunmarkasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturunmodeli.Select();
            }
        }

        private void txturunmodeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmburunturu.Select();
            }
        }

        private void cmburunturu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturunadedi.Select();
            }
        }

        private void txturunadedi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtgarantisuresi.Select();
            }
        }

        private void txtgarantisuresi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturungelisfiyati.Select();
            }
        }

        private void txturungelisfiyati_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txturunsatisfiyatii.Select();
            }
        }

        private void frmstokislemleriurunekleme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnkaydet.PerformClick();
            }
        }

        private void chbxgarantiyok_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxgarantiyok.Checked == true)
            {
                txtgarantisuresi.Enabled = false;
            }
            else
            {
                txtgarantisuresi.Enabled = true;
            }
        }
    }
}
