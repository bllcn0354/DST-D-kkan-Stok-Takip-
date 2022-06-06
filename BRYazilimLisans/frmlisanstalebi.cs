using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmlisanstalebi : Form
    {
        public frmlisanstalebi()
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
            string mailadresi = "bryazilimm@gmail.com";
            string mailsifre = "Asdewqfgh03";
            string lisanstalebimaili = "bryazilim.lisanstalebi@gmail.com";
            string body = txtkullanicimaili.Text + " Mail adresinden lisans talebi aldınız. gönderilecek anahtar =   " + "( " + key + " )" + "  Bu anahtarı kimseyle paylaşmayın.";
            

            if (txtkullanicimaili.Text != "")
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
                    MessageBox.Show("Mail gönderildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Mail gönderilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("mail adresini gir.");
            }

        }


        private void btngonder_Click(object sender, EventArgs e)
        {
            mailgonder();
        }
    }
}
