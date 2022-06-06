using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net.Mail;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmacilisekrani : Form
    {
        public frmacilisekrani()
        {
            InitializeComponent();
        }
        // parça tarih
        string programincalistirildigigun = DateTime.Now.Day.ToString();
        string programincalistirildigiay = DateTime.Now.Month.ToString();
        string programincalistirildigiyil = DateTime.Now.Year.ToString();


        // toplu tarih
        DateTime demobaslangic;


        ArrayList hardDriveDetails = new ArrayList();


        string HDDmodel;
        string HDDtip;
        string HDDserial;
        private void btndemo_Click(object sender, EventArgs e)
        {
            //hdd özellikleri öğrenme
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString(); //serialnumber
                hardDriveDetails.Add(hd);
                 HDDmodel = "Model : " + hd.Model;
                 HDDtip = " Type : " + hd.Type;
                 HDDserial = "Serial Number: (" + hd.SerialNo + ")";
            }
            ////////////////////////////////////////////////////////////////
            
            ////////////////////////////////////////////////////////////////////


            //lisans bitiş tarihi//////////////////////////////////////////////////////////////////////////
            demobaslangic = DateTime.Today;
           
            //////////////////////////////////////////////////////////////////////////////////////////////



            // demo kullanıcı adı şifre
           
            DialogResult = MessageBox.Show("DST Demo kullanıyorsunuz. Kullanıcıadı: user Şifre: 12345678   (Deneme sürümü 3 günlüktür).","DST",MessageBoxButtons.OK ,MessageBoxIcon.Information);

            

            
            //mail gönderme
            string mailadresi = "bryazilimm@gmail.com";
            string mailsifre = "Asdewqfgh03";
            string lisanstalebimaili = "bryazilim.lisanstalebi@gmail.com";
            string body = HDDserial + "   Numaralı HDD DST Demoyu kullanmaya başladı.";
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
                    mail.Subject = "B&R Yazılım - Demo Kullanma Bildirimi";
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    smtp.Send(mail);
                    mail.Dispose();
                }
                catch
                {
                    
                }

            // demoyu aç

           
            
            this.Visible = false;
        }


        internal class HardDrive
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

        private void btncikis_Click(object sender, EventArgs e)
        {
          
        }
        
        private void frmacilisekrani_Load(object sender, EventArgs e)
        {
           
        }

        private void frmacilisekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnlisanstercihleri_Click(object sender, EventArgs e)
        {
           

                   
        }

       
    }
}

    