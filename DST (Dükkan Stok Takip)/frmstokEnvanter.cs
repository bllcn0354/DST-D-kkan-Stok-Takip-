using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmstokEnvanter : Form
    {
        public frmstokEnvanter()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        private void frmstokEnvanter_Load(object sender, EventArgs e)
        {
            verilerigoruntule1();
        }
        public void verilerigoruntule1()
        {
            dataGridView1.Controls.Clear();
            //datagridview e veri alma           
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler", baglanti);
            baglanti.Open();
            DataTable urunlertablosu = new DataTable();
            da.Fill(urunlertablosu);
            dataGridView1.DataSource = urunlertablosu;
            baglanti.Close();
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
    }
}
