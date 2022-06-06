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
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");

       

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            verilerigoruntule();            
        }
        private void verilerigoruntule()
        {
            baglanti.Close();
            dataGridView1.Controls.Clear();
            //datagridview e veri alma           
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From Raporlar", baglanti);
            baglanti.Open();
            DataTable tablo1 = new DataTable();
            da.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
        }
        private void verilerigoruntule1()
        {
            baglanti.Close();
            string simdikitarihaybasi ="01." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();
            string simdikitarihaysonu = "30." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString();

            try
            {
                //datagridview e veri alma
                DataTable tablo1 = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Raporlar WHERE Tarih BETWEEN @tarih1 and @tarih2", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@tarih1", simdikitarihaybasi);
                da.SelectCommand.Parameters.AddWithValue("@tarih2", simdikitarihaysonu);
                baglanti.Open();
                da.Fill(tablo1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
                //Sütun değerlerini toplama girilen tarih aralığındaki toplam karı bulmak için
                int toplamgelir = 0;
                int toplamgider = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplamgelir += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    toplamgider += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                }
                int kar;
                lblgelir.Text = toplamgelir.ToString() + " TL";
                lblgider.Text = toplamgider.ToString() + " TL";
                kar = toplamgelir - toplamgider;
                lblkar.Text = kar.ToString() + " TL";
                /////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception)
            {
                MessageBox.Show("Tarih aralığı getirilemedi", "DST", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            verilerigoruntule1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            try
            {
                //datagridview e veri alma
                DataTable tablo1 = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Raporlar WHERE Tarih BETWEEN @tarih1 and @tarih2", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@tarih1", dtptakvimbaslangic.Value.ToShortDateString());
                da.SelectCommand.Parameters.AddWithValue("@tarih2", dtptakvimbitis.Value.ToShortDateString());
                baglanti.Open();
                da.Fill(tablo1);
                dataGridView1.DataSource = tablo1;
                baglanti.Close();
                //Sütun değerlerini toplama girilen tarih aralığındaki toplam karı bulmak için
                int toplamgelir = 0;
                int toplamgider = 0;
                int kar = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplamgelir += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    toplamgider += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    kar = toplamgelir - toplamgider;

                }               
                lblgelir.Text = toplamgelir.ToString() + " TL";
                lblgider.Text = toplamgider.ToString() + " TL";                
                lblkar.Text = kar.ToString() + " TL";
                /////////////////////////////////////////////////////////////////////////////////
            }
            catch (Exception)
            {
                MessageBox.Show("Tarih aralığı getirilemedi","DST",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
        private void dtptakvim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dtptakvimbaslangic.Value = DateTime.Now;
                dtptakvimbitis.Value = DateTime.Now;
                btnlistele.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Tarih aralığı getirilemedi", "DST", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
           
          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
