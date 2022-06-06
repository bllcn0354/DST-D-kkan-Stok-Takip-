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
    public partial class frmsaturunbilgisi : Form
    {
        public frmsaturunbilgisi()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        public string gelisfiyat;
        int kalan,urunno;
        int sonuc;
       public string faturayazisi;
        public string personelkad;
        string txtglsfyt;
        string txtfyt;
        string txtkar;
        private void frmsaturunbilgisi_Load(object sender, EventArgs e)
        {
            btnSat.BackgroundImage = Image.FromFile("images/satonay.png");
            

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

            //picturebox logo ekleme
            pcbxlogo_resim.Load("images/B&R Yazılım Logo(2).png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sayii1;
        private void txturunno_TextChanged(object sender, EventArgs e)
        {
            if (txturunno.Text == "Ara")
            {
                txturunno.Text = "";

            }
            else
            {
                if (txturunno.Text != "")
                {
                    urunno = Convert.ToInt32(txturunno.Text);
                    lblurunno.Text = urunno.ToString();
                }
            }

            if (txturunno.Text != "")
            {
                 
                OleDbCommand komut = new OleDbCommand("Select Urun_Adi, Urun_Markasi, Urun_Modeli, Urun_Turu, Urun_Fiyati, Urun_Gelis_Fiyati, Urun_Garanti_Suresi, Urun_Adet from Urunler where Urun_No like'" + Convert.ToInt32(txturunno.Text) + "'", baglanti);
                baglanti.Open();
                if (txturunno.Text.Length == 5)
                {
                    OleDbDataReader dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        cmburunadi.Text = dr["Urun_Adi"].ToString();
                        cmburunmarkasi.Text = dr["Urun_Markasi"].ToString();
                        cmburunmodeli.Text = dr["Urun_Modeli"].ToString();
                        cmburunturu.Text = dr["Urun_Turu"].ToString();
                        txturunfiyati.Text = dr["Urun_Fiyati"].ToString();
                        cmbgaranti.Text = dr["Urun_Garanti_Suresi"].ToString();
                        lblmevcutadet.Text = dr["Urun_Adet"].ToString();
                        gelisfiyat=dr["Urun_Gelis_Fiyati"].ToString();
                       
                    }
                    cmburunadedi.Items.Clear();
                    sayii1 = Convert.ToInt32(lblmevcutadet.Text);
                    for (int i = 1; i <= sayii1; i++)
                    {
                        cmburunadedi.Items.Add(i.ToString());
                    }

                    if (cmburunadedi.SelectedIndex >= 0)
                    {
                        int fiyat = Convert.ToInt32(txturunfiyati.Text);
                        int adet = Convert.ToInt32(cmburunadedi.Text);
                        sonuc = fiyat * adet;
                        txttoplamodenecektutar.Text = sonuc.ToString();
                    }



                }
                else
                {
                    baglanti.Close();
                    cmburunadi.Text = "";
                    cmburunmarkasi.Text = "";
                    cmburunmodeli.Text = "";
                    cmburunturu.Text = "";
                    
                    cmburunturu.SelectedIndex = -1;
                    txturunfiyati.Text = "";
                    cmbgaranti.Text = "";
                    cmburunadedi.Items.Clear();
                    //   cmburunadedi.Text = "";
                    lblmevcutadet.Text = "0";
                    sayii1 = 0;
                }
                baglanti.Close();


                if (sayii1 > 0)
                {
                    chbxgaranti.Checked = true;
                }
                else
                {
                    chbxgaranti.Checked = false;
                }




            }

        }

        private void cmburunadedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmburunadedi.SelectedIndex >= 0)
            {
                int fiyat = Convert.ToInt32(txturunfiyati.Text);
                int adet = Convert.ToInt32(cmburunadedi.Text);
                sonuc = fiyat * adet;
                txttoplamodenecektutar.Text = sonuc.ToString() + " TL";

                btnSat.Enabled = true;
            }
           else
            {
                btnSat.Enabled = false;
            }

            if(cmburunturu.SelectedIndex==0|| cmburunturu.SelectedIndex == 1 || cmburunturu.SelectedIndex == 2 || cmburunturu.SelectedIndex == 3)
            {
                cmbsatisturu.SelectedIndex = 0;
            }
            else
            {
                cmbsatisturu.SelectedIndex = 1;
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmburunturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmburunturu.Text!="")
            {
                if (cmburunturu.SelectedIndex == 0)
                {
                    pcbxlogo_resim.Load("images/tel.png");
                }
                if (cmburunturu.SelectedIndex == 1)
                {
                    pcbxlogo_resim.Load("images/bilgisayar.png");
                }
                if (cmburunturu.SelectedIndex == 2)
                {
                    pcbxlogo_resim.Load("images/bilgisayar parçaları.png");
                }
                if (cmburunturu.SelectedIndex == 3)
                {
                    pcbxlogo_resim.Load("images/tablet.png");
                }
                if (cmburunturu.SelectedIndex == 4)
                {
                    pcbxlogo_resim.Load("images/kamera.png");
                }
                if (cmburunturu.SelectedIndex == 5)
                {
                    pcbxlogo_resim.Load("images/şarj aleti.png");
                }
                if (cmburunturu.SelectedIndex == 6)
                {
                    pcbxlogo_resim.Load("images/power.png");
                }
                if (cmburunturu.SelectedIndex == 7)
                {
                    pcbxlogo_resim.Load("images/kulaklık.png");
                }
                if (cmburunturu.SelectedIndex == 8)
                {
                    pcbxlogo_resim.Load("images/kılıf.png");
                }
                if (cmburunturu.SelectedIndex == 9)
                {
                    pcbxlogo_resim.Load("images/kırılmaz cam.png");
                }
                if (cmburunturu.SelectedIndex == 10)
                {
                    pcbxlogo_resim.Load("images/aksesuar.png");
                }
                if (cmburunturu.SelectedIndex == 11)
                {
                    pcbxlogo_resim.Load("images/hoparlör.png");
                }
                if (cmburunturu.SelectedIndex == 12)
                {
                    pcbxlogo_resim.Load("images/mikrafon.png");
                }
                if (cmburunturu.SelectedIndex == 13)
                {
                    pcbxlogo_resim.Load("images/usb.png");
                }
                if (cmburunturu.SelectedIndex == 14)
                {
                    pcbxlogo_resim.Load("images/hafıza kartı.png");
                }
                if (cmburunturu.SelectedIndex == 15)
                {
                    pcbxlogo_resim.Load("images/batarya.png");
                }
            }
            else
            {
                pcbxlogo_resim.Load("images/SOFTWARE (3).png");
            }







        }

        private void txturunno_MouseClick(object sender, MouseEventArgs e)
        {
            txturunno.Text = "";
        }
       
        private void txturunno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (txturunno.Text == "Ara")
            {
                txturunno.Text = "";
              
            }
            else
            {
                if (txturunno.Text != "")
                {
                    urunno = Convert.ToInt32(txturunno.Text);
                    if (cmburunadedi.SelectedIndex >= 0)
                    {
                       
                        
                    }
                  

                }    
            }

           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string tahsilturu;
            if (rdbkredi.Checked == true)
            {
                tahsilturu = rdbkredi.Text;
            }
            else
            {
                tahsilturu = rdbnakit.Text;
            }

            int satisfiyati1 = Convert.ToInt32(txturunfiyati.Text);
            int kar;


            kar = ((satisfiyati1) - (Convert.ToInt32(gelisfiyat))) * (Convert.ToInt32(cmburunadedi.Text));
            kar = kar * 1;


            if (txturunno.Text != "")
            {
                if (cmburunadi.Text != "")
                {
                    if (cmburunmarkasi.Text != "")
                    {
                        if (cmburunmodeli.Text != "")
                        {
                            if (txturunfiyati.Text != "")
                            {
                                if (cmbgaranti.Text != "")
                                {
                                    if (cmburunadedi.Text != "")
                                    {
                                        if (txttoplamodenecektutar.Text != "")
                                        {
                                            if (cmbsatisturu.SelectedIndex >= 0)
                                            {
                                                if (txtkullanici.Text != "")
                                                {

                                                    string tarih = DateTime.Now.ToShortDateString();
                                                    txttarih.Text = tarih;


                                                    OleDbCommand komut = new OleDbCommand("INSERT INTO Satis_İslemleri ([Urun_No],[Urun_Adi],[Urun_Markasi],[Urun_Modeli],[Urun_Turu],[Urun_Fiyati],[Urun_Garanti_Suresi],[Urun_Adedi],[Toplam_Tutar],[Satis_Turu],[Tahsil_Turu],[Not],[PersonelK_Ad],[Kar],[Tarih]) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", baglanti);
                                                    komut.Parameters.AddWithValue("@Urun_No", Convert.ToInt32(txturunno.Text));
                                                    komut.Parameters.AddWithValue("@Urun_Adi", cmburunadi.Text);
                                                    komut.Parameters.AddWithValue("@Urun_Markasi", cmburunmarkasi.Text);
                                                    komut.Parameters.AddWithValue("@Urun_Modeli", cmburunmodeli.Text);
                                                    komut.Parameters.AddWithValue("@Urun_Turu", cmburunturu.Text);
                                                    komut.Parameters.AddWithValue("@Urun_Fiyati", Convert.ToInt32(txturunfiyati.Text));
                                                    komut.Parameters.AddWithValue("@Urun_Garanti_Suresi", cmbgaranti.Text);
                                                    komut.Parameters.AddWithValue("@Urun_Adedi", Convert.ToInt32(cmburunadedi.Text));
                                                    komut.Parameters.AddWithValue("@Toplam_Tutar", sonuc);
                                                    komut.Parameters.AddWithValue("@Satis_Turu", cmbsatisturu.Text);
                                                    komut.Parameters.AddWithValue("@Tahsil_Turu", tahsilturu);
                                                    komut.Parameters.AddWithValue("@Not", txtnot.Text);
                                                    komut.Parameters.AddWithValue("@PersonelK_Ad", txtkullanici.Text);
                                                    komut.Parameters.AddWithValue("@Kar", (kar));
                                                    komut.Parameters.AddWithValue("@Tarih", DateTime.Now.Date.ToShortDateString());
                                                    komut.ExecuteNonQuery();
                                                    MessageBox.Show("Satış işleme alındı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                       
                                                   
                                                    //

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Alanları kontrol edin.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();




            baglanti.Open();

            OleDbCommand komut2 = new OleDbCommand("SELECT Max(Satis_No) AS EnSonSatis FROM Satis_İslemleri", baglanti);
           
           
                OleDbDataReader dr = komut2.ExecuteReader();
                while (dr.Read())
                {
                    txtsatisno.Text = dr["EnSonSatis"].ToString();
                }




            baglanti.Close();






            try
            {
                baglanti.Open();
                OleDbCommand kmt1 = new OleDbCommand();
                kmt1.Connection = baglanti;
                kmt1.CommandText = "SELECT * FROM Urunler WHERE Urun_No=" + Convert.ToInt32(txturunno.Text) + "";
                OleDbDataReader vo = kmt1.ExecuteReader();
                while (vo.Read())
                {
                    txtfyt = vo[5].ToString();
                    txtglsfyt = vo[6].ToString();
                    txtkar = vo[7].ToString();
                   // MessageBox.Show("'" + txtfyt + "-" + txtglsfyt + "'", "Gelir-Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("ürün verilerine erişilemiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int karr;
            int fyt;
            try
            {
                string aciklama = txturunno.Text + " nolu ürün (" + cmburunadedi.Text + ") adedince (" + txturunfiyati.Text + ") birim fiyatı ile satılıp gelir sisteme eklenmiştir.";
                karr = Convert.ToInt32(txtkar);
                karr = karr * (cmburunadedi.SelectedIndex + 1);
                fyt = Convert.ToInt32(txtfyt);
                fyt = fyt * (cmburunadedi.SelectedIndex + 1);
                int gider = 0;
                baglanti.Close();
                baglanti.Open();
                OleDbCommand kmt = new OleDbCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = ("INSERT INTO Raporlar([Tarih],[Gelir],[Gider],[Kar],[Aciklama]) VALUES (?,?,?,?,?)");
                kmt.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                kmt.Parameters.AddWithValue("@Gelir", fyt);
                kmt.Parameters.AddWithValue("@Gider", gider);
                kmt.Parameters.AddWithValue("@Kar", karr);
                kmt.Parameters.AddWithValue("@Aciklama", aciklama);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Satış gelir bölümüne eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






            //////////////////////////////////////////////////////////////////////////





            kalan = Convert.ToInt32(lblmevcutadet.Text) - ((cmburunadedi.SelectedIndex)+1);
           
            if (kalan == 0)
            {
                DialogResult = MessageBox.Show("Bu ürünün tamamını sattınız. Ürünü Silmek istermisiniz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                
                if (DialogResult==DialogResult.Yes)
                {
                 
                    frmfatura frmfatura = new frmfatura();
                    frmsatisislemleri frmsatisislemleri = new frmsatisislemleri();
                    //fatura yazdırma



                    DialogResult = MessageBox.Show("Fatura istiyormusunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        frmsatisislemleri.faturayazisi = "FATURA" + Environment.NewLine + Environment.NewLine;
                        string odemeturu;
                        if (rdbkredi.Checked == true)
                        {
                            odemeturu = "Kredi Kartı";
                        }
                        else
                        {
                            odemeturu = "Nakit";
                        }



                        frmsatisislemleri.faturayazisi += "Satış No: " + txtsatisno.Text + Environment.NewLine + "Personel No: " + txtperno.Text + Environment.NewLine + "Ürün No: " + txturunno.Text + Environment.NewLine + "Ürün Adı: " + cmburunadi.Text + Environment.NewLine + "Ürün Markası: " + cmburunmarkasi.Text + Environment.NewLine + "Ürün Modeli: " + cmburunmodeli.Text + Environment.NewLine + "Ürün Türü: " + cmburunturu.Text + Environment.NewLine + "Ürün Fiyatı: " + txturunfiyati.Text + Environment.NewLine + "Ürün Garanti Süresi: " + cmbgaranti.Text + Environment.NewLine + "Ürün Adedi: " + cmburunadedi.Text + Environment.NewLine + "Toplam Tutar: " + txttoplamodenecektutar.Text + Environment.NewLine + "Ödeme Türü: " + odemeturu;
                      
                        if (cmbsatisturu.SelectedIndex == 0)
                        {
                           
                           
                            frmsatismusteribilgisi frmsatismusteribilgisi = new frmsatismusteribilgisi();
                            frmsatismusteribilgisi.txtmusterisatisno.Text = txtsatisno.Text;
                            frmsatismusteribilgisi.txttarih.Text = txttarih.Text;
                            frmsatismusteribilgisi.ShowDialog();
                            frmfatura.ShowDialog();

                        }
                        else
                        {
                            frmfatura.ShowDialog();
                        }
                    }




                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from Urunler where Urun_No=" + txturunno.Text + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış İşlemi Gerçekleştirildi ve Ürün Tamamen Silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblmevcutadet.Text = kalan.ToString();
                    cmburunadedi.Items.Clear();
                    sayii1 = Convert.ToInt32(lblmevcutadet.Text);
                    for (int i = 1; i <= sayii1; i++)
                    {
                        cmburunadedi.Items.Add(i.ToString());
                    }

                }
                if (DialogResult == DialogResult.No)
                {

                   
                    frmfatura frmfatura = new frmfatura();
                   
                    //fatura yazdırma



                    DialogResult = MessageBox.Show("Fatura istiyormusunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        frmsatisislemleri.faturayazisi = "FATURA" + Environment.NewLine + Environment.NewLine;
                        string odemeturu;
                        if (rdbkredi.Checked == true)
                        {
                            odemeturu = "Kredi Kartı";
                        }
                        else
                        {
                            odemeturu = "Nakit";
                        }
                        frmsatisislemleri.faturayazisi += "Satış No: " + txtsatisno.Text + Environment.NewLine + "Personel No: " + txtperno.Text + Environment.NewLine + "Ürün No: " + txturunno.Text + Environment.NewLine + "Ürün Adı: " + cmburunadi.Text + Environment.NewLine + "Ürün Markası: " + cmburunmarkasi.Text + Environment.NewLine + "Ürün Modeli: " + cmburunmodeli.Text + Environment.NewLine + "Ürün Türü: " + cmburunturu.Text + Environment.NewLine + "Ürün Fiyatı: " + txturunfiyati.Text + Environment.NewLine + "Ürün Garanti Süresi: " + cmbgaranti.Text + Environment.NewLine + "Ürün Adedi: " + cmburunadedi.Text + Environment.NewLine + "Toplam Tutar: " + txttoplamodenecektutar.Text + Environment.NewLine + "Ödeme Türü: " + odemeturu;

                        if (cmbsatisturu.SelectedIndex == 0)
                        {
                            frmsatismusteribilgisi frmsatismusteribilgisi = new frmsatismusteribilgisi();
                            frmsatismusteribilgisi.txtmusterisatisno.Text = txtsatisno.Text;
                            frmsatismusteribilgisi.txttarih.Text = txttarih.Text;
                            frmsatismusteribilgisi.ShowDialog();
                            frmfatura.ShowDialog();
                        }
                        else
                        {
                            frmfatura.ShowDialog();
                        }
                    }


                    baglanti.Close();
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "UPDATE Urunler SET Urun_Adet='" + kalan + "' WHERE Urun_No=" + urunno + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Satış İşlemi Gerçekleştirildi ve Ürün Saklandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblmevcutadet.Text = kalan.ToString();
                    cmburunadedi.Items.Clear();
                    sayii1 = Convert.ToInt32(lblmevcutadet.Text);
                    for (int i = 1; i <= sayii1; i++)
                    {
                        cmburunadedi.Items.Add(i.ToString());
                    }

                }
            }
            else
            {
                frmarayuz frmarayuz = new frmarayuz();
                frmfatura frmfatura = new frmfatura();
                frmsatisislemleri frmsatisislemleri = new frmsatisislemleri();
                //fatura yazdırma



                DialogResult = MessageBox.Show("Fatura istiyormusunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult == DialogResult.Yes)
                {
                    frmsatisislemleri.faturayazisi = "FATURA" + Environment.NewLine + Environment.NewLine;
                    string odemeturu;
                    if (rdbkredi.Checked == true)
                    {
                        odemeturu = "Kredi Kartı";
                    }
                    else
                    {
                        odemeturu = "Nakit";
                    }

                    frmsatisislemleri.faturayazisi += "Satış No: " + txtsatisno.Text + Environment.NewLine + "Personel No: " + txtperno.Text + Environment.NewLine + "Ürün No: " + txturunno.Text + Environment.NewLine + "Ürün Adı: " + cmburunadi.Text + Environment.NewLine + "Ürün Markası: " + cmburunmarkasi.Text + Environment.NewLine + "Ürün Modeli: " + cmburunmodeli.Text + Environment.NewLine + "Ürün Türü: " + cmburunturu.Text + Environment.NewLine + "Ürün Fiyatı: " + txturunfiyati.Text + Environment.NewLine + "Ürün Garanti Süresi: " + cmbgaranti.Text + Environment.NewLine + "Ürün Adedi: " + cmburunadedi.Text + Environment.NewLine + "Toplam Tutar: " + txttoplamodenecektutar.Text + Environment.NewLine + "Ödeme Türü: " + odemeturu;

                    if (cmbsatisturu.SelectedIndex == 0)
                    {   
                        frmsatismusteribilgisi frmsatismusteribilgisi = new frmsatismusteribilgisi();
                        frmsatismusteribilgisi.txtmusterisatisno.Text = txtsatisno.Text;
                        frmsatismusteribilgisi.txttarih.Text = txttarih.Text;
                        frmsatismusteribilgisi.ShowDialog();
                        frmfatura.ShowDialog();
                    }
                    else
                    {
                        frmfatura.ShowDialog();
                    }
                }



                baglanti.Close();
                baglanti.Open();
                OleDbCommand  komut = new OleDbCommand();                
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Urunler SET Urun_Adet='" + kalan + "' WHERE Urun_No=" + urunno + "";
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış İşlemi Gerçekleştirildi.", "Bildirim", MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblmevcutadet.Text = kalan.ToString();
                cmburunadedi.Items.Clear();
                sayii1 = Convert.ToInt32(lblmevcutadet.Text);
                for (int i = 1; i <= sayii1; i++)
                {
                    cmburunadedi.Items.Add(i.ToString());
                }
            }

            

            
            // Urun_No = '"+ Convert.ToInt32(txturunno.Text) + "',Urun_Adi = '"+ cmburunadi.Text + "',Urun_Markasi = '"+ cmburunmarkasi.Text +"'
        }
    }
}
