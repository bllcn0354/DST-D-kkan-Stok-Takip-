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
    public partial class frmsatisislemleri : Form
    {
       
        public frmsatisislemleri()
        {
            InitializeComponent();
           
        }
        
        public static string faturayazisi;







       
        private void frmsatisislemleri_Load(object sender, EventArgs e)
        {
            btnsatt.BackgroundImage = Image.FromFile("images/sat.png");
           

           
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
            //satış türü item ekleme
            cmbsatisturu.Items.Add("Basit Satış");
            cmbsatisturu.Items.Add("Detaylı Satış");
            // garanti süresi item ekleme
            cmbgaranti.Items.Add("6 Ay");
            cmbgaranti.Items.Add("1 Yıl");
            cmbgaranti.Items.Add("2 Yıl");
            cmbgaranti.Items.Add("4 Yıl");
            //resim ekle
            pcbxdegisenresim.Load("images/wallpaper/küp.png");
        }

        
        // otomatik arama sistemi
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (txturunno.Text!="")
            {
               // this.BackColor = Color.Red;
            }
            else
            {
              //  this.BackColor = Color.Yellow ;
            }
           
        }


        void satisturunegoreislem()
        {
            if (cmbsatisturu.SelectedIndex==0)
            {
                txtmusteriad.Enabled = false;
                txtmusteriadres.Enabled = false;
               
                txtmusterisoyad.Enabled = false;
                txtmusteritc.Enabled = false;                
            }
            if (cmbsatisturu.SelectedIndex == 1)
            {
                txtmusteriad.Enabled = true;
                txtmusteriadres.Enabled = true;
                
                txtmusterisoyad.Enabled = true;
                txtmusteritc.Enabled = true;
            }
        }  


        private void frmsatisislemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
            {
                btnsat.PerformClick();
                
            }

        }
        string resim1 = "images/wallpaper/akıladam.png";
        string resim2 = "images/wallpaper/anlasel.png";
        string resim3 = "images/wallpaper/at.png";
        string resim4 = "images/wallpaper/ayar.png";
        string resim5 = "images/wallpaper/zamanpara.png";
        string resim6 = "images/wallpaper/dairemavi.png";
        string resim7 = "images/wallpaper/kaplan.png";
        string resim8 = "images/wallpaper/kartal.png";
        string resim9 = "images/wallpaper/kiz.png";
        string resim10 = "images/wallpaper/küp.png";
        string resim11 = "images/wallpaper/mavirenktonu.png";
        string resim12 = "images/wallpaper/robotel.png";
        string resim13 = "images/wallpaper/sincapmısır.png";
        string kullanilanresim;
        int sayi = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Width>=1500)
            {
                pcbxdegisenresim.Visible = true;
               // pcbxdegisenresim.Size = new Size(710,500);
            }
            else
            {
                pcbxdegisenresim.Visible = false;
              //  pcbxdegisenresim.Size = new Size(147, 293);
            }

            sayi += 1;

            if (sayi == 1)
            {
                kullanilanresim = resim1;
            }
            if (sayi == 2)
            {
                kullanilanresim = resim2;
            }
            if (sayi == 3)
            {
                kullanilanresim = resim3;
            }
            if (sayi == 4)
            {
                kullanilanresim = resim4;
            }
            if (sayi == 5)
            {
                kullanilanresim = resim5;
            }
            if (sayi == 6)
            {
                kullanilanresim = resim6;
            }
            if (sayi == 7)
            {
                kullanilanresim = resim7;
            }
            if (sayi == 8)
            {
                kullanilanresim = resim8;
            }
            if (sayi == 9)
            {
                kullanilanresim = resim9;
            }
            if (sayi == 10)
            {
                kullanilanresim = resim10;
            }
            if (sayi >= 11)
            {
                kullanilanresim = resim11;
            }
            if (sayi >= 12)
            {
                kullanilanresim = resim12;
            }
            if (sayi >= 13)
            {
                kullanilanresim = resim13;
            }
            if (sayi >= 13)
            {
                sayi = 0;
            }
            pcbxdegisenresim.Load(kullanilanresim);
        }

       

        private void cmbsatisturu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

          

        private void btnsat_Click_1(object sender, EventArgs e)
        {
            if (txturunno.TextLength != 5)
            {
               
            }
            else
            {
                faturayazisi = "FATURA" + Environment.NewLine + Environment.NewLine;



                string odemeturu;
                if (rdbkredi.Checked == true)
                {
                    odemeturu = "Kredi Kartı";
                }
                else
                {
                    odemeturu = "Nakit";
                }
                faturayazisi +=  "Satış No: " + txtsatisno.Text + Environment.NewLine+ "Personel No: "+ txtpersonelno.Text + Environment.NewLine+ "Ürün No: " + txturunno.Text + Environment.NewLine + "Ürün Adı: " + cmburunadi.Text + Environment.NewLine + "Ürün Markası: " + cmburunmarkasi.Text + Environment.NewLine + "Ürün Modeli: " + cmburunmodeli.Text + Environment.NewLine + "Ürün Türü: " + cmburunturu.Text + Environment.NewLine + "Ürün Fiyatı: " + txturunfiyati.Text + Environment.NewLine + "Ürün Garanti Süresi: " + cmbgaranti.Text + Environment.NewLine + "Ürün Adedi: " + cmburunadedi .Text + Environment.NewLine + "Toplam Tutar: " + txttoplamodenecektutar .Text + Environment.NewLine + "Ödeme Türü: " + odemeturu ;
                if (txtmusteriad.Enabled == true)
                {
                    faturayazisi += Environment.NewLine + Environment.NewLine + "Müşteri No: " + txtmusterino.Text + Environment.NewLine + "Müşteri Adı: " + txtmusteriad.Text + Environment.NewLine + "Müşteri Soyad: " + txtmusterisoyad.Text + Environment.NewLine + "Müşteri TC: " + txtmusteritc.Text + Environment.NewLine + "Müşteri Adres: " + txtmusteriadres.Text ;
                }


                frmfatura frmfatura = new frmfatura();
                frmfatura.Show();
            }
        }

        private void chbxgaranti_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txturunno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (txturunno.Text == "Ara")
            {
                txturunno.SelectAll();
            }
          
        }
        int sayii1;
        private void txturunno_TextChanged(object sender, EventArgs e)
        {
            
            
            
            //ürün numarasına göre arama sistemi


            //  if (txturunno.Text == "015")
            //  {
            //        this.BackColor = Color.Black;
            //   }
            //  if (txturunno.Text == "025")
            //  {
            //      this.BackColor = Color.Red;
            //  }
            //  if (txturunno.Text == "055")
            // {
            //      this.BackColor = Color.Pink;
            //  }
            if (txturunno.Text != "")
            {
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb");
                OleDbCommand komut = new OleDbCommand("Select Urun_Adi, Urun_Markasi, Urun_Modeli, Urun_Turu, Urun_Fiyati, Urun_Garanti_Suresi, Urun_Adet from Urunler where Urun_No like'" + Convert.ToInt32(txturunno.Text) + "'", baglanti);
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
                        int sonuc = fiyat * adet;
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
                    txturunfiyati.Text = "";
                    cmbgaranti.Text = "";
                    cmburunadedi.Items.Clear();
                 //   cmburunadedi.Text = "";
                    lblmevcutadet.Text = "0";
                    sayii1 = 0;
                }
                baglanti.Close();
               
             
                if (sayii1>0)
                {
                        chbxgaranti.Checked = true;
                }
                else
                {
                        chbxgaranti.Checked = false;
                }




            }
            
        }
        int sayi1 = 0;
        private void txturunfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            if (txturunfiyati.Text.Length == 0)
            {
                sayi1 = 1;
            }
            else
            {
                sayi1 = 0;
            }

            if (sayi1 == 1)
            {
                txturunfiyati.Text += " TL";
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcbxdegisenresim_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void cmbgaranti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmburunadedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmburunadedi.SelectedIndex >= 0)
            {
                int fiyat = Convert.ToInt32(txturunfiyati.Text);
                int adet = Convert.ToInt32(cmburunadedi.Text);
                int sonuc = fiyat * adet;
                txttoplamodenecektutar.Text = sonuc.ToString() + " TL";
            }
        }

        private void pcbxdegisenresim_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmsaturunbilgisi frmsaturunbilgisi = new frmsaturunbilgisi();
            frmsaturunbilgisi.txtkullanici.Text = lblperkad.Text;
            frmsaturunbilgisi.txtperno.Text = lblperno.Text;
            frmsaturunbilgisi.ShowDialog();
        }

        private void txturunno_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmburunadedi_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmburunturu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

