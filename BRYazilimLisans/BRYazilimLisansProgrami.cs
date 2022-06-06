using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace BRYazilimLisans
{
    public partial class BRYazilimLisansProgrami : Form
    {
        public BRYazilimLisansProgrami()
        {
            InitializeComponent();
        }


        ArrayList hardDriveDetails = new ArrayList();
        string HDDModel;
        string HDDTip;
        string HDDSerial;


        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btndemo_Click(object sender, EventArgs e)
        {
            
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

        private void BRYazilimLisansProgrami_Load(object sender, EventArgs e)
        {
            //PC HDD serial öğrenme
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString(); // Serial Number
                hardDriveDetails.Add(hd);
                 HDDModel = "Model : " + hd.Model;
                 HDDTip = " Type : " + hd.Type;
                 HDDSerial = "HDD Serial Number : " + hd.SerialNo;
            }
            StreamWriter SW = new StreamWriter(@"license information device.txt");
            SW.WriteLine(HDDSerial);
            SW.Close();

            //// serial üretme
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

            string key = harfuret[0].ToString() + harfuret[1].ToString() + sayiuret[0].ToString() + harfuret[2].ToString() + sayiuret[1].ToString() + harfuret[7].ToString() + sayiuret[2].ToString() + harfuret[3].ToString() + sayiuret[3].ToString() + harfuret[0].ToString() + sayiuret[4].ToString() + sayiuret[5].ToString() + harfuret[4].ToString() + sayiuret[5].ToString() + harfuret[3].ToString() + harfuret[5].ToString() + harfuret[6].ToString() + sayiuret[6].ToString() + sayiuret[7].ToString() + harfuret[7].ToString() + sayiuret[2].ToString() + harfuret[8].ToString() + sayiuret[8].ToString() + sayiuret[9].ToString() + harfuret[9].ToString();

            StreamWriter SW1 = new StreamWriter(@"license information.txt");
            SW1.WriteLine("DST Serial Number: " + key);
            SW1.Close();



            
        }

        private void btnlisanstercihleri_Click(object sender, EventArgs e)
        {
            frmlisanssec frmlisanssec = new frmlisanssec();
            frmlisanssec.ShowDialog();
        }
    }
}
