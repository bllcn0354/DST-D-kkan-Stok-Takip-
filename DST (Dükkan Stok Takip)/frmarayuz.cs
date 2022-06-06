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
using System.Media;
using System.Collections;
using System.Management;
using System.Net.Mail;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmarayuz : Form
    {
        public frmarayuz()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");


        public frmsatisislemleri frmsat = new frmsatisislemleri ();
        public frmanasayfa frmana = new frmanasayfa();
        public frmstokislemleri frmstok = new frmstokislemleri();
        public frmpersonelislemleri frmpersonel = new frmpersonelislemleri();        
        public frmraporlar frmrapor = new frmraporlar();
        public frmayarlar frmayar = new frmayarlar();
        public frmsaturunbilgisi frmsaturunbilgisi = new frmsaturunbilgisi();
        public frmcihazekle frmcihazekle = new frmcihazekle();

        int sayi = 0;
        string deger = "0";
        public string perno;

        int sayi1 = 0;
        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            
            
            if (sayi1 < 2)
            {
                webBrowser1.Navigate("https://altin.doviz.com/gram-altin");
                webBrowser2.Navigate("https://bigpara.hurriyet.com.tr/doviz/dolar/");
                webBrowser3.Navigate("https://bigpara.hurriyet.com.tr/doviz/euro/");
                webBrowser4.Navigate("https://www.dinargundem.com/dinar-haberleri/");
                webBrowser5.Navigate("https://www.haber7.com/sondakika");

            }
            sayi1 += 1;
            if (Settings.GenelAyarlar.Default.Ses==1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }

            }



            frmana.verilerigoruntule1();
            frmana.Refresh();
            frmana.btnurunlertablosu.PerformClick();
            if (Settings.altbolumayarlari.Default.altbolum==1)
            {
                pnlalt.Visible = true;
            }
            else
            {
                pnlalt.Visible = false;
            }
            

            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon_Sec.png");   
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////

            // form açma
            ortabolum.Controls.Clear();
            frmana .Dock = DockStyle.Fill;
            frmana.TopLevel = false;
            ortabolum.Controls.Add(frmana);            
            frmana.Show();
           
        }

        private void btnsatisislemleri_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
            


            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon_Sec.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////



            // form açma
            ortabolum.Controls.Clear();
            frmsat.Dock = DockStyle.Fill;
            frmsat.TopLevel = false;
            ortabolum.Controls.Add(frmsat);
            frmsat.lblperkad.Text = lblkullanici.Text;
            frmsat.lblperno.Text = lblperno.Text;
            frmsat.Show();
        }

        private void btnstokislemleri_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
            


            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon_Sec.png");////////////////
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////


            // form açma
            ortabolum.Controls.Clear();
            frmstok.Dock = DockStyle.Fill;
            frmstok.TopLevel = false;
            ortabolum.Controls.Add(frmstok);
            frmstok.Show();
        }

        private void btnpersonelislemleri_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
            


            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon_Sec.png");///////////
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////


            // form açma
            ortabolum.Controls.Clear();
            frmpersonel .Dock = DockStyle.Fill;
            frmpersonel.TopLevel = false;
            ortabolum.Controls.Add(frmpersonel);
            frmpersonel.kullaniciadicagir = lblkullanici.Text;
            frmpersonel.Show();
        }

        

        private void btnraporlar_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
            


            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon_Sec.png");/////////////
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////


            // form açma
            ortabolum.Controls.Clear();
            frmrapor .Dock = DockStyle.Fill;
            frmrapor.TopLevel = false;
            ortabolum.Controls.Add(frmrapor);
            frmrapor.Show();
        }

       

        private void btnayarlar_Click_1(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
            


            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon_Sec.png");////////////
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            //////////


            // form açma
            ortabolum.Controls.Clear();
            frmayar.Dock = DockStyle.Fill;
            frmayar.TopLevel = false;
            ortabolum.Controls.Add(frmayar);
            frmayar.Show();
        }

       
        
        private void verilerigoruntule()
        {
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler", baglanti);
            baglanti.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
          frmana.dataGridView1.DataSource = tablo;
            baglanti.Close();
            frmana.Refresh();
            
        }


        ArrayList hardDriveDetails = new ArrayList();
        string HDDModel;
        string HDDTip;
        string HDDSerial;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //  Settings.HesapAyarları.Default.Reset();
            


            if (Settings.HesapAyarları.Default.LISANS_TURU == "")
            {
                frmacilislisansgirmeekrani frmacilislisansgirmeekrani = new frmacilislisansgirmeekrani();
                frmacilislisansgirmeekrani.ShowDialog();
            }
            else
            {
                kullanicigirisipaneli.Enabled = true;
                
                this.BackgroundImage = Image.FromFile("images/DST1.png");
                this.Enabled = true;
                frmana.kullanicituru = txtkullanicituru.Text;
                try
                {
                    // butonlara icon ekleme 
                    btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
                    btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
                    btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
                    btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
                    btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
                    btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
                    btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
                    btncik.BackgroundImage = Image.FromFile("images/çık.png");



                    // btnminimize.BackgroundImage = Image.FromFile("images/kucult.png");
                }
                catch (Exception)
                {
                    MessageBox.Show("Programın dosyaları silinmiş.", "DST", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                deger = "1";







                // serial kontrol
                //PC HDD serial öğrenme
                ManagementObjectSearcher moSearcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                foreach (ManagementObject wmi_HD in moSearcher.Get())
                {
                    HardDrive hd = new HardDrive();  // User Defined Class
                    hd.Model = wmi_HD["Model"].ToString();  //Model Number
                    hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                    hd.SerialNo = "Yok"; //wmi_HD["SerialNumber"].ToString(); // Serial Number
                    hardDriveDetails.Add(hd);
                    HDDModel = "Model : " + hd.Model;
                    HDDTip = " Type : " + hd.Type;
                    HDDSerial = "HDD Serial Number : " + hd.SerialNo;
                }
                if (Settings.HesapAyarları.Default.HDD_NO == HDDSerial && Settings.HesapAyarları.Default.SERIAL_KEY == Settings.HesapAyarları.Default.VERİLEN_KEY)
                {
                    this.Visible = true;
                    try
                    {
                        //mail gönderme   Lisans üzerinden kaç pc açılıyor kontrol için                 
                        string mailadresi = "bryazilimm@gmail.com";
                        string mailsifre = "Asdewqfgh03";
                        string lisanstalebimaili = "bryazilim.lisanstalebi@gmail.com";
                        string body = Settings.HesapAyarları.Default.HESAP_ADI + " / (" + HDDSerial + ") HDD Seri NO";

                        MailMessage mail = new MailMessage();
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new System.Net.NetworkCredential(mailadresi, mailsifre);
                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        mail.To.Add(lisanstalebimaili);
                        mail.From = new MailAddress(mailadresi, "B&R Software");
                        mail.Subject = "B&R Yazılım - Lisans Talebi";
                        mail.Body = body;
                        mail.IsBodyHtml = true;
                        smtp.Send(mail);
                        mail.Dispose();
                        MessageBox.Show("Hoş Geldiniz", "DST", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    tmrlisanskontrol.Enabled = true;
                }

               
            }

        }


        class HardDrive
        {
            private string model = null;
            private string type = null;
            private string serialNo = null;
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            public string SerialNo
            {
                get { return serialNo; }
                set { serialNo = value; }
            }
        }



        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsatisislemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode   ==   Keys.Enter   )
            {
                // form açma
                ortabolum.Controls.Clear();
                frmsat.Dock = DockStyle.Fill;
                frmsat.TopLevel = false;
                ortabolum.Controls.Add(frmsat);
                frmsat.Show();
                MessageBox.Show ("Satış Gerçekleştirildi.");
                frmsat.btnsat.PerformClick();
                
            }
        }
        frmstokislemlerimevcuturunekleme frmstokislemlerimevcuturunekleme = new frmstokislemlerimevcuturunekleme();
        private void frmarayuz_KeyDown(object sender, KeyEventArgs e)
        {
          

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }

            

            //başlıkda yazı çıkarma
          

            ortabolum.Controls.Clear();
            ortabolum.Controls.Add(kullanicigirisipaneli);
            txtsifre.Text = "";
            txtsifre.Select();


            kullanicigirisipaneli.Visible = true;
            ustmenu.Visible = false;
            pnlalt.Visible = false;
            webBrowser1.Visible = false;
            ustmenu.Enabled = false;            
        }

        private void frmarayuz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.GenelAyarlar.Default.Save();
            Settings.altbolumayarlari.Default.Save();
            Settings.HesapAyarları.Default.Save();
            Settings.MuhasebeAyarlari.Default.Save();
            Settings.YedeklemeAyarlari.Default.Save();
        }
       public  int artansayi = 180;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //artansayi -= 1;
            //lbluyari.Text = "Kullanıcı Adı ve Şifre girilmezse sistem " + artansayi.ToString() + " saniye içerisinde kapanacaktır!";    

           // if (artansayi == 0)
           // {
               // this.Close();              
          //  }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();
            this.Close();

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
       

        private void ustmenu_Paint(object sender, PaintEventArgs e)
        {

        }
        string kullaniciadi = "user";
        string sifre = "12345678";
       
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
                OleDbCommand komut = new OleDbCommand("Select * from Personel where Personel_Kullanici_Adi like'" + txtkullaniciadi.Text + "'", baglanti);
                baglanti.Open();
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    kullaniciadi = dr["Personel_Kullanici_Adi"].ToString();
                    sifre = dr["Personel_Sifre"].ToString();
                }
            baglanti.Close();


            





            if (txtkullaniciadi.Text == kullaniciadi)
            {
                if (txtsifre.Text == sifre)
                {
                    
                    tmracilislogo.Enabled = true;   
                }
                else
                {
                    if (txtsifre.Text.Length ==8)
                    {
                        if (txtsifre.Text != sifre)
                        {
                            MessageBox.Show("Şifre hatalı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ustmenu.Enabled = false;
                        }
                        
                    }
                    
                }
            }
            else
            {
                if (txtkullaniciadi.Text.Length == 8)
                {
                    MessageBox.Show("Kullanıcı Adı hatalı!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ustmenu.Enabled = false;
                }                
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btnayarlar_MouseMove(object sender, MouseEventArgs e)
        {
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon_Sec.png");
        }

        private void btnayarlar_MouseLeave(object sender, EventArgs e)
        {
           
          
            if (ortabolum.Controls.Contains(frmayar))
            {
                btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon_Sec.png");
            }
            else
            {
                btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            }
            

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btnkilitle.BackgroundImage = Image.FromFile("images/guvenlidosya_Sec.png");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnkilitle.BackgroundImage = Image.FromFile("images/guvenlidosya.png");
        }

        private void btnpersonelislemleri_MouseMove(object sender, MouseEventArgs e)
        {
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon_Sec.png");
        }

        private void btnpersonelislemleri_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmpersonel))
            {
                btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon_Sec.png");
            }
            else
            {
                btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            }
        }

        private void btnstokislemleri_MouseMove(object sender, MouseEventArgs e)
        {
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon_Sec.png");
        }

        private void btnstokislemleri_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmstok))
            {
                btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon_Sec.png");
            }
            else
            {
                btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            }
        }

        private void btnsatisislemleri_MouseMove(object sender, MouseEventArgs e)
        {
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon_Sec.png");
        }

        private void btnsatisislemleri_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmsat))
            {
                btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon_Sec.png");
            }
            else
            {
                btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            }
        }

        private void btnanasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon_Sec.png");

        }

        private void btnanasayfa_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmana))
            {
                btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon_Sec.png");
            }
            else
            {
                btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            }
        }

        private void btnraporlar_MouseMove(object sender, MouseEventArgs e)
        {
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon_Sec.png");
        }

        private void btnraporlar_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmrapor))
            {
                btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon_Sec.png");
            }
            else
            {
                btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            }
        }

       
       

        private void timer4_Tick(object sender, EventArgs e)
        {
            btnkilitle.PerformClick();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (Settings.altbolumayarlari.Default.altbolum==1)
            {
                pnlalt.Visible = true;
            }
            else
            {
                pnlalt.Visible = false;
            }
            if (Settings.altbolumayarlari.Default.saat == 1)
            {
                lblsaat.Visible = true;
            }
            else
            {
                lblsaat.Visible = false;
            }
            if (Settings.altbolumayarlari.Default.yapımci == 1)
            {
                lblsirket.Visible = true;
            }
            else
            {
                lblsirket.Visible = false;
            }

            // döviz    

            if (Settings.altbolumayarlari.Default.altin==1)
            {
                lblaltin.Visible = true;
                try
                {
                    HtmlElementCollection komut = webBrowser1.Document.All;
                    foreach (HtmlElement name in komut)
                    {

                        if (name.GetAttribute("className") == "text-xl font-semibold text-white")
                        {
                            lblaltin.Text = "Altın: " + name.InnerText;
                        }
                    }
                }
                catch (Exception)
                {


                }
            }
            else
            {
                lblaltin.Visible = false;
            }
           

            if (Settings.altbolumayarlari.Default.dolar == 1)
            {
                lbldolar.Visible = true;
                try
                {
                    HtmlElementCollection komut1 = webBrowser2.Document.All;
                    foreach (HtmlElement name in komut1)
                    {

                        if (name.GetAttribute("className") == "value up")
                        {
                            lbldolar.Text = "Dolar: " + name.InnerText;

                        }
                    }

                }
                catch (Exception)
                {

                }
            }
            else
            {
                lbldolar.Visible = false;
            }


            if (Settings.altbolumayarlari.Default.euro == 1)
            {
                lbleuro.Visible = true;
                try
                {
                    HtmlElementCollection komut2 = webBrowser3.Document.All;
                    foreach (HtmlElement name in komut2)
                    {

                        if (name.GetAttribute("className") == "value up")
                        {
                            lbleuro.Text = "Euro: " + name.InnerText;
                        }
                    }
                }
                catch (Exception)
                {



                }
            }
            else
            {
                lbleuro.Visible = false;
            }
            if (Settings.altbolumayarlari.Default.haber2 == 1)
            {
                lblhaber2.Visible = true;
                try
                {
                    HtmlElementCollection komut3 = webBrowser4.Document.All;
                    foreach (HtmlElement name in komut3)
                    {

                        if (name.GetAttribute("className") == "t8")
                        {
                            lblhaber2.Text = "                                                                              " + name.InnerText;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                lblhaber2.Visible = false;
            }
            if (Settings.altbolumayarlari.Default.haber1 == 1)
            {
                lblhaber1.Visible = true;
                try
                {
                    HtmlElementCollection komut4 = webBrowser5.Document.All;
                    foreach (HtmlElement name in komut4)
                    {

                        if (name.GetAttribute("className") == "title")
                        {
                            lblhaber1.Text = "                                                                              " + name.InnerText;
                        }
                    }
                }
                catch (Exception)
                {

                }

            }
            else
            {
                lblhaber1.Visible = false;
            }


        }


        
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (sayi <= 1)
            {
                this.BackgroundImageLayout = ImageLayout.Zoom;
                this.BackgroundImage = Image.FromFile("images/wallpaper/B&R Yazılım Logo(2).png");
            }
            
            
            kullanicigirisipaneli.Visible = false;
            sayi += 1;
            if (sayi == 7)
            {
                ustmenu.Visible = true;
                
                ustmenu.Enabled = true;



                //
                verilerigoruntule();                
                ortabolum.Controls.Clear();
                this.Visible = false;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                btnsatisislemleri.PerformClick();
                btnanasayfa.PerformClick();
                this.BackgroundImage = Image.FromFile("images/SOFT (1).png");
                this.Visible = true;

                // this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                // btnsatisislemleri.PerformClick();
                // btnanasayfa.PerformClick();
                // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                // this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                // timer2.Enabled = false;

                // kullanıcı online yapma

                //  lblkullanici.Text = kullaniciadi;
                // lblkullanicidurum.Text = kullanicidurumu;


                OleDbCommand komut1 = new OleDbCommand("Select * from Personel where Personel_Kullanici_Adi like'" + txtkullaniciadi.Text + "'", baglanti);
                baglanti.Open();

                OleDbDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    lblkullanici.Text = dr1["Personel_Kullanici_Adi"].ToString();
                    txtkullanicituru.Text = dr1["Personel_Turu"].ToString();
                    lblperno.Text = dr1["Personel_No"].ToString();
                }

                baglanti.Close();

                if (txtkullanicituru.Text == "Yönetici")
                {
                    btnstokislemleri.Visible = true;
                    btnpersonelislemleri.Visible = true;
                    btnraporlar.Visible = true;
                    btnayarlar.Visible = true;

                    frmana.düzenleToolStripMenuItem.Enabled = true;
                    frmana.silToolStripMenuItem.Enabled = true;

                }
                else
                {
                    btnstokislemleri.Visible = false;
                    btnpersonelislemleri.Visible = false;
                    btnraporlar.Visible = false;
                    btnayarlar.Visible = false;

                    frmana.düzenleToolStripMenuItem.Enabled = false;
                    frmana.silToolStripMenuItem.Enabled = false;
                }

                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = Image.FromFile("images/SOFT (1).png");
                sayi = 0;
                tmracilislogo.Enabled = false;
                btnanasayfa.PerformClick();
                btnanasayfa.PerformClick();
                btnanasayfa.PerformClick();
                tmrdoviz_altin.Enabled = true;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // KOMUTLAR.Default.Reset();
            // KOMUTLAR.Default.Save();
            mailgonder();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlalt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbldolar_Click(object sender, EventArgs e)
        {

        }

        private void lblhaber_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dinargundem.com/dinar-haberleri/");
        }

        private void tmrkayanyazi_Tick(object sender, EventArgs e)
        {
            lblhaber1.Text = lblhaber1.Text.Substring(1) + lblhaber1.Text.Substring(0,1);
            lblhaber2.Text = lblhaber2.Text.Substring(1) + lblhaber2.Text.Substring(0, 1);
            lblsirket.Text = lblsirket.Text.Substring(1) + lblsirket.Text.Substring(0, 1);

            lblsaat.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

        private void lblhaber1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.haber7.com/sondakika");
        }

        private void lblhaber3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bryazilim.wordpress.com/");
        
        }

        private void btncihaztakip_Click(object sender, EventArgs e)
        {
            if (Settings.GenelAyarlar.Default.Ses == 1)
            {
                if (deger == "1")
                {
                    SoundPlayer Ses = new SoundPlayer();
                    string Dizin = Application.StartupPath + "\\volumes/click-sesi.wav";
                    Ses.SoundLocation = Dizin;
                    Ses.Play();
                }
            }
           

            ////////// seçim işlemleri
            btnanasayfa.BackgroundImage = Image.FromFile("images/anasayfaicon.png");
            btnayarlar.BackgroundImage = Image.FromFile("images/ayarlaricon.png");
            btnpersonelislemleri.BackgroundImage = Image.FromFile("images/personelicon.png");
            btnraporlar.BackgroundImage = Image.FromFile("images/raporlaricon.png");
            btnstokislemleri.BackgroundImage = Image.FromFile("images/stokicon.png");
            btnsatisislemleri.BackgroundImage = Image.FromFile("images/satışicon.png");
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle_Sec.png");
            //////////

            // form açma
            ortabolum.Controls.Clear();
            frmcihazekle.Dock = DockStyle.Fill;
            frmcihazekle.TopLevel = false;
            ortabolum.Controls.Add(frmcihazekle);
            frmcihazekle.txtkullaniciadi.Text = lblkullanici.Text;
            frmcihazekle.acilisamaci = 0;
            /////////////////
            frmcihazekle.cmbdurum.Enabled = false;
            frmcihazekle.txtkar.Enabled = true;
            frmcihazekle.txtnot.Enabled = true;
            //////////////
            frmcihazekle.txtadres.Enabled = true;
            frmcihazekle.txtariza.Enabled = true;
            frmcihazekle.txtcihazadi.Enabled = true;
            frmcihazekle.txtmusteriad.Enabled = true;
            frmcihazekle.txtmusterisoyad.Enabled = true;
            frmcihazekle.txtsifre.Enabled = true;
            frmcihazekle.txttel.Enabled = true;
            frmcihazekle.groupBox1.Enabled = true;
            frmcihazekle.txtmaliyet.Enabled = true;
            frmcihazekle.txtkar.Enabled = false;
            frmcihazekle.txtUcret.Enabled = true;
            frmcihazekle.btnyenidendene.Enabled = true;
            frmcihazekle.button1.Visible = false;
            frmcihazekle.btnkaydet.Visible = true;
            frmcihazekle.Show();

        }

        private void btncihaztakip_MouseLeave(object sender, EventArgs e)
        {
            if (ortabolum.Controls.Contains(frmcihazekle))
            {
                btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle_Sec.png");
            }
            else
            {
                btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle.png");
            }
        }

        private void btncihaztakip_MouseMove(object sender, MouseEventArgs e)
        {
            btncihaztakip.BackgroundImage = Image.FromFile("images/cihazekle_Sec.png");
        }
        bool durum = false;
        private void tmrlisanskontrol_Tick(object sender, EventArgs e)
        {
            if (durum==true)
            {
                tmrlisanskontrol.Enabled = false;
            }
            if (Settings.HesapAyarları.Default.LISANS_TURU=="")
            {
                frmacilislisansgirmeekrani frmacilislisansgirmeekrani = new frmacilislisansgirmeekrani();
                frmacilislisansgirmeekrani.ShowDialog();
            }
            else
            {
                // serial kontrol
                //PC HDD serial öğrenme
                ManagementObjectSearcher moSearcher = new
                ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

                foreach (ManagementObject wmi_HD in moSearcher.Get())
                {
                    HardDrive hd = new HardDrive();  // User Defined Class
                    hd.Model = wmi_HD["Model"].ToString();  //Model Number
                    hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                    hd.SerialNo = "Yok";//wmi_HD["SerialNumber"].ToString(); // Serial Number
                    hardDriveDetails.Add(hd);
                    HDDModel = "Model : " + hd.Model;
                    HDDTip = " Type : " + hd.Type;
                    HDDSerial = "HDD Serial Number : " + hd.SerialNo;
                }
                if (Settings.HesapAyarları.Default.LISANS_TURU != "")
                {
                    this.Visible = true;
                    try
                    {
                        //mail gönderme   Lisans üzerinden kaç pc açılıyor kontrol için                 
                        string mailadresi = "bryazilimm@gmail.com";
                        string mailsifre = "Asdewqfgh03";
                        string lisanstalebimaili = "bryazilim.lisanstalebi@gmail.com";
                        string body = Settings.HesapAyarları.Default.HESAP_ADI + " / (" + HDDSerial + ") HDD Seri NO";

                        MailMessage mail = new MailMessage();
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new System.Net.NetworkCredential(mailadresi, mailsifre);
                        smtp.Port = 587;
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        mail.To.Add(lisanstalebimaili);
                        mail.From = new MailAddress(mailadresi, "B&R Software");
                        mail.Subject = "B&R Yazılım - Lisans Talebi";
                        mail.Body = body;
                        mail.IsBodyHtml = true;
                        smtp.Send(mail);
                        mail.Dispose();
                        durum = true;
                        tmrlisanskontrol.Interval = 3600000;
                        MessageBox.Show("Hoş Geldiniz", "DST", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     tmrlisanskontrol.Enabled = false;
                    }
                    catch (Exception)
                    {


                    }
                }
                else
                {
                    tmrlisanskontrol.Interval = 3600000;
                    MessageBox.Show("Lisansınız yoktur.", "B&R Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            
        }
        public void mailgonder()
        {            
            //mail gönderme            
            string mailadresi = "bryazilimm@gmail.com";
            string mailsifre = "Asdewqfgh03";
            string lisanstalebimaili = Settings.HesapAyarları.Default.HESAP_ADI;
            string body = DateTime.Now.ToShortDateString() + " DST Data Yedekleme Dosyası";

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential(mailadresi, mailsifre);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                mail.To.Add(lisanstalebimaili);
                mail.From = new MailAddress(mailadresi, "B&R Software");
                mail.Subject = "B&R Yazılım - Otomatik Yedekleme";
                mail.Body = body;
                Attachment attachment;
                attachment = new Attachment(@"DST_Data.accdb");
                mail.Attachments.Add(attachment);
                mail.IsBodyHtml = true;
                smtp.Send(mail);
                mail.Dispose();
                Settings.YedeklemeAyarlari.Default.Durum = 1;
                Settings.YedeklemeAyarlari.Default.Save();
                MessageBox.Show("Yedekleme başarılı bir şekilde tammalandı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Bir sorunla karşılaşıldı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }
        private void tmryedekleme_Tick(object sender, EventArgs e)
        {
            

            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 1)
            {
                if (DateTime.Now.Hour > Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                {
                    Settings.YedeklemeAyarlari.Default.Durum = 0;
                    Settings.YedeklemeAyarlari.Default.Save();
                }



                if (Settings.YedeklemeAyarlari.Default.Durum == 0)
                {
                    ///yedekleme kodları
                    if (DateTime.Now.Hour == Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                    {
                        mailgonder();
                       
                    }
                    
                }
            }
            
            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 2)
            {
                int hedefgun = 10;
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                {
                    hedefgun = 1;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                {
                    hedefgun = 2;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                {
                    hedefgun = 3;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                {
                    hedefgun = 4;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                {
                    hedefgun = 5;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    hedefgun = 6;
                }
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    hedefgun = 7;
                }
                if (hedefgun > Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                {
                    Settings.YedeklemeAyarlari.Default.Durum = 0;
                    Settings.YedeklemeAyarlari.Default.Save();
                }
                if (Settings.YedeklemeAyarlari.Default.Durum == 0)
                {
                   
                    ///yedekleme kodları

                    if (hedefgun == Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                    {

                        mailgonder();
                       
                            
                       
                    }

                }
            }
            
            if (Settings.YedeklemeAyarlari.Default.Periyod_Turu == 3)
            {
                if (DateTime.Now.Day > Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                {
                    Settings.YedeklemeAyarlari.Default.Durum = 0;
                    Settings.YedeklemeAyarlari.Default.Save();
                }

                if (Settings.YedeklemeAyarlari.Default.Durum == 0)
                {
                    ///yedekleme kodları
                    if (DateTime.Now.Day == Settings.YedeklemeAyarlari.Default.Hedef_Zaman)
                    {

                        mailgonder();                        
                           
                    }
                    
                }
               
            }
        }
    }
}
