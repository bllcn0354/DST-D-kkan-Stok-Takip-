using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmacilislisansgirmeekrani : Form
    {
        public frmacilislisansgirmeekrani()
        {
            InitializeComponent();
        }

        public void mailgonder()
        {
            //serial üretme
            Random rasgelekey = new Random();
            int[] sayiuret = new int[21];
            //sayı
            sayiuret[0] = rasgelekey.Next(1, 9);
            sayiuret[1] = rasgelekey.Next(1, 9);
            sayiuret[2] = rasgelekey.Next(1, 9);
            sayiuret[3] = rasgelekey.Next(1, 9);
            sayiuret[4] = rasgelekey.Next(1, 9);
            sayiuret[5] = rasgelekey.Next(1, 9);
            sayiuret[6] = rasgelekey.Next(1, 9);
            sayiuret[7] = rasgelekey.Next(1, 9);
            sayiuret[8] = rasgelekey.Next(1, 9);
            sayiuret[9] = rasgelekey.Next(1, 9);
            // harf
            sayiuret[10] = rasgelekey.Next(65, 91);
            sayiuret[11] = rasgelekey.Next(65, 91);
            sayiuret[12] = rasgelekey.Next(65, 91);
            sayiuret[13] = rasgelekey.Next(65, 91);
            sayiuret[14] = rasgelekey.Next(65, 91);
            sayiuret[15] = rasgelekey.Next(65, 91);
            sayiuret[16] = rasgelekey.Next(65, 91);
            sayiuret[17] = rasgelekey.Next(65, 91);
            sayiuret[18] = rasgelekey.Next(65, 91);
            sayiuret[19] = rasgelekey.Next(65, 91);
            sayiuret[20] = rasgelekey.Next(65, 91);
            // harfe dönüştürme
            char[] harfuret = new char[10];
            harfuret[0] = Convert.ToChar(sayiuret[11]);
            harfuret[1] = Convert.ToChar(sayiuret[12]);
            harfuret[2] = Convert.ToChar(sayiuret[13]);
            harfuret[3] = Convert.ToChar(sayiuret[14]);
            harfuret[4] = Convert.ToChar(sayiuret[15]);
            harfuret[5] = Convert.ToChar(sayiuret[16]);
            harfuret[6] = Convert.ToChar(sayiuret[17]);
            harfuret[7] = Convert.ToChar(sayiuret[18]);
            harfuret[8] = Convert.ToChar(sayiuret[19]);
            harfuret[9] = Convert.ToChar(sayiuret[20]);

            //mail gönderme

            string key = harfuret[0].ToString() + harfuret[1].ToString() + sayiuret[0].ToString() + harfuret[2].ToString() + sayiuret[1].ToString() + harfuret[7].ToString() + sayiuret[2].ToString() + harfuret[3].ToString() + sayiuret[3].ToString() + harfuret[0].ToString() + sayiuret[4].ToString() + sayiuret[5].ToString() + harfuret[4].ToString() + sayiuret[5].ToString() + harfuret[3].ToString() + harfuret[5].ToString() + harfuret[6].ToString() + sayiuret[6].ToString() + sayiuret[7].ToString() + harfuret[7].ToString() + sayiuret[2].ToString() + harfuret[8].ToString() + sayiuret[8].ToString() + sayiuret[9].ToString() + harfuret[9].ToString();
            Settings.HesapAyarları.Default.SERIAL_KEY = key;
            Settings.HesapAyarları.Default.Save();
            string mailadresi = "bryazilimm@gmail.com";
            string mailsifre = "Asdewqfgh03";
            string lisanstalebimaili = "bryazilim.lisanstalebi@gmail.com";
            string body = txtmail.Text + " Mail adresinden lisans talebi aldınız. gönderilecek anahtar =   " + "( " + key + " )" + "  Bu anahtarı kimseyle paylaşmayın.";


            if (txtmail.Text != "")
            {
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
                    mail.Subject = "B&R Yazılım - Lisans Talebi";
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    smtp.Send(mail);
                    mail.Dispose();
                    MessageBox.Show("Lisans talebi gönderildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lisans talebi gönderilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("mail adresini gir.");
            }

        }



        public void lisanskontrol()
        {
            if (Settings.HesapAyarları.Default.SERIAL_KEY==txtlisanskey.Text)
            {
                Settings.HesapAyarları.Default.VERİLEN_KEY = txtlisanskey.Text;
                Settings.HesapAyarları.Default.HESAP_ADI = txtmail.Text;
                Settings.HesapAyarları.Default.LISANS_TURU = "STANDARD";
                Settings.HesapAyarları.Default.Save();
                frmarayuz frmarayuz = new frmarayuz();
                frmarayuz.Show();
                frmarayuz.Visible = true;
                Settings.HesapAyarları.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu anahtar geçersiz!", "DST", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void lbllisansal_Click(object sender, EventArgs e)
        {
            lblmail_key.Text = "Mail";
            btnlisanskontrol.Text = "Talep Gönder";
            txtmail.Visible = true;
            txtlisanskey.Visible = false;
           
            
        }

        private void btnlisanskontrol_Click(object sender, EventArgs e)
        {
            if (lblmail_key.Text == "Mail")
            {
                if (txtmail.Text != "")
                {
                    mailgonder();
                }
                else
                {
                    MessageBox.Show("Mail boş bırakılamaz.", "DST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (lblmail_key.Text == "Key")
            {
                if (txtlisanskey.Text != "")
                {
                    lisanskontrol();
                }
                else
                {
                    MessageBox.Show("Mailinizi kontrol edip size verilen ürün anahtarını key bölümüne giriniz.", "DST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            lblmail_key.Text = "Key";
            btnlisanskontrol.Text = "Lisans Gir";
            txtmail.Visible = false;
            txtlisanskey.Visible = true;




        }

        private void frmacilislisansgirmeekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Settings.HesapAyarları.Default.LISANS_TURU == "STANDARD")
            {
                MessageBox.Show("Bizi tercih ettiğiniz için teşekkürler.","DST",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Application.Exit();
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
        ArrayList hardDriveDetails = new ArrayList();
        string HDDModel;
        string HDDTip;
        string HDDSerial;
        private void frmacilislisansgirmeekrani_Load(object sender, EventArgs e)
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
            Settings.HesapAyarları.Default.HDD_NO = "Yok";//HDDSerial;
            Settings.HesapAyarları.Default.Save();
        }
    }
}
