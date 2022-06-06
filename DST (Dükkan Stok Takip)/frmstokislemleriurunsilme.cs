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
    public partial class frmstokislemleriurunsilme : Form
    {
        public frmstokislemleriurunsilme()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
        private void frmstokislemleriurunsilme_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("images/sil.png");
            
            verilerigoruntule();
        }
        private void verilerigoruntule()
        {
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler", baglanti);
            DataTable tablo = new DataTable();
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txturunno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txturunno.Text.Length == 5)
                {
                    string gelisfiyati;
                    string adet;
                    try
                    {
                        baglanti.Open();
                        OleDbCommand kmt1 = new OleDbCommand();
                        kmt1.Connection = baglanti;
                        kmt1.CommandText = "Select Urun_Adet, Urun_Gelis_Fiyati from Urunler where Urun_No like'" + Convert.ToInt32(txturunno.Text) + "'";
                        OleDbDataReader dr = kmt1.ExecuteReader();
                        while (dr.Read())
                        {
                            adet = dr["Urun_Adet"].ToString();
                            gelisfiyati = dr["Urun_Gelis_Fiyati"].ToString();
                            string aciklama = txturunno.Text + " numaralı ürün tamamen silinip mevcut adedince(" +adet+") geliş fiyatı("+gelisfiyati+")sisteme eklenmiştir.";
                            int gider = 0;
                            int karr = Convert.ToInt32(adet) * Convert.ToInt32(gelisfiyati);
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
                    }
                    catch (Exception)
                    {


                    }



                    baglanti.Close();
                    baglanti.Open();
                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from Urunler where Urun_No=" + txturunno.Text + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ürün Silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    verilerigoruntule();
                }
                else
                {
                    MessageBox.Show("Lütfen Silinecek Ürünü Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception)
            {

               
            }

            


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
