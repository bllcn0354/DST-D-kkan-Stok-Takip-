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
    public partial class frmanasayfa : Form
    {

        public frmanasayfa()
        {
            InitializeComponent();
           
        }

           


        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|DST_Data.accdb;Persist Security Info=True;Jet OLEDB:Database Password=BRSOFTyazilim");
       public string kullanicituru;





        public void verilerigoruntule1()
        {
            baglanti.Close();
            dataGridView1.Controls.Clear();
            //datagridview e veri alma           
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Urunler", baglanti);
            baglanti.Open();
            DataTable urunlertablosu = new DataTable();
            da.Fill(urunlertablosu);
            dataGridView1.DataSource = urunlertablosu;
            baglanti.Close();


        }
        public void verilerigoruntule2()
        {
            baglanti.Close();
            dataGridView1.Controls.Clear();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Satis_İslemleri", baglanti);
            baglanti.Open();
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            baglanti.Close();


        }
        public void verilerigoruntule3()
        {
            baglanti.Close();
            dataGridView1.Controls.Clear();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Raporlar", baglanti);
            DataTable tablo3 = new DataTable();
            baglanti.Open();
            da.Fill(tablo3);
            dataGridView1.DataSource = tablo3;
            baglanti.Close();


        }
        public void verilerigoruntule4()
        {
            baglanti.Close();
            dataGridView1.Controls.Clear();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Musteri", baglanti);
            baglanti.Open();
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView1.DataSource = tablo4;
            baglanti.Close();


        }

        public void verilerigoruntule5()
        {
            baglanti.Close();
            string islemealindi = "İşleme Alındı";
            string beklemede = "Beklemede";
            string servisde = "Serviste";
            string islembitti = "İşlem Bitti";

            dataGridView1.Controls.Clear();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Cihaz_Tamir where Durum='" + islemealindi + "' or Durum='" + beklemede + "' or Durum='" + servisde + "' or Durum='" + islembitti + "'", baglanti);
            baglanti.Open();
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView1.DataSource = tablo4;
            baglanti.Close();
        }

        public void verilerigoruntule6()
        {
            baglanti.Close();
            string teslimedilenler = "Teslim Edildi";
            dataGridView1.Controls.Clear();
            //datagridview e veri alma
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Cihaz_Tamir where Durum='" + teslimedilenler + "'", baglanti);
            baglanti.Open();
            DataTable tablo4 = new DataTable();
            da.Fill(tablo4);
            dataGridView1.DataSource = tablo4;
            baglanti.Close();
        }


        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Close();
            btnurunlertablosu.PerformClick();
            cmbxaramaturusec.SelectedIndex = 0;
            
            pcbxdesen.Load("images/desen1.png");
           // pcbxgif.Load("images/anasayfagif.gif");

            verilerigoruntule1();

           
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            sagtik_datagridview.Enabled = true;
            sagtik_datagridview_cihaz.Enabled = true;
            dataGridView1.ContextMenuStrip = sagtik_datagridview;
            verilerigoruntule1();
            btnurunlertablosu.BackColor = Color.AliceBlue;
            //diğerlerini aynı yapma
            btnsatisislemleritablosu.BackColor = Color.Transparent;           
            btnmusteritablo.BackColor = Color.Transparent;
            btncihazlartablosu.BackColor = Color.Transparent;
            btnbitenislemlertablo.BackColor = Color.Transparent;
            //yazı rengi
            btnurunlertablosu.ForeColor = Color.DarkBlue;

            //diğerleri
            btnmusteritablo.ForeColor = Color.DarkCyan;           
            btnsatisislemleritablosu.ForeColor = Color.DarkCyan;
            btncihazlartablosu.ForeColor = Color.DarkCyan;
            btnbitenislemlertablo.ForeColor = Color.DarkCyan;
            //
            cmbxaramaturusec.Items.Clear();            
            cmbxaramaturusec.Items.Add("Genel Arama");
            cmbxaramaturusec.Items.Add("Tarihe Göre Arama");      
            cmbxaramaturusec.SelectedIndex = 0;

                   
        }


       
        

        
        
        private void timer1_Tick(object sender, EventArgs e)
        {

          




        }

        private void button4_Click(object sender, EventArgs e)
        {
            sagtik_datagridview.Enabled = true;
            sagtik_datagridview_cihaz.Enabled = true;
            dataGridView1.ContextMenuStrip = sagtik_datagridview;
            verilerigoruntule4();
            btnmusteritablo.BackColor = Color.AliceBlue;
            //diğerlerini aynı yapma
            btnsatisislemleritablosu.BackColor = Color.Transparent;            
            btnurunlertablosu.BackColor = Color.Transparent;
            btncihazlartablosu.BackColor = Color.Transparent;
            btnbitenislemlertablo.BackColor = Color.Transparent;
            //yazı rengi
            btnmusteritablo.ForeColor = Color.DarkBlue;
            //diğerleri
            btnsatisislemleritablosu.ForeColor = Color.DarkCyan;
            btnurunlertablosu.ForeColor = Color.DarkCyan;
            btncihazlartablosu.ForeColor = Color.DarkCyan;
            btnbitenislemlertablo.ForeColor = Color.DarkCyan;


            cmbxaramaturusec.Items.Clear();            
            cmbxaramaturusec.Items.Add("Genel Arama");
            cmbxaramaturusec.Items.Add("Tarihe Göre Arama");
            cmbxaramaturusec.SelectedIndex = 0;
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = sagtik_datagridview;
            sagtik_datagridview.Enabled = true;
            sagtik_datagridview_cihaz.Enabled = true;
            verilerigoruntule2();
           
           btnsatisislemleritablosu .BackColor = Color.AliceBlue;
            //diğerlerini aynı yapma
            btnurunlertablosu.BackColor = Color.Transparent;            
            btnmusteritablo.BackColor = Color.Transparent;
            btncihazlartablosu.BackColor = Color.Transparent;
            btnbitenislemlertablo.BackColor = Color.Transparent;

            //yazı rengi
            btnsatisislemleritablosu.ForeColor = Color.DarkBlue;

            //diğerleri
            btnmusteritablo.ForeColor = Color.DarkCyan;
            btncihazlartablosu.ForeColor = Color.DarkCyan;
            btnurunlertablosu.ForeColor = Color.DarkCyan;
            btnbitenislemlertablo.ForeColor = Color.DarkCyan;


            cmbxaramaturusec.Items.Clear();           
            cmbxaramaturusec.Items.Add("Genel Arama");            
            cmbxaramaturusec.Items.Add("Tarihe Göre Arama");
            cmbxaramaturusec.SelectedIndex = 0;
            


        }
        frmfatura frmfatura = new frmfatura();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();

            try
            {
                if (btncihazlartablosu.BackColor == Color.AliceBlue)
                {
                    DataTable tablo = new DataTable();
                    if (txtarama.Text == "")
                    {

                    }
                    if (cmbxaramaturusec.SelectedIndex == 1) // tarihe göre arama
                    {
                        string yazitut;
                        if (txtarama.Text.Length == 4)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text.Length == 7)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text == "")
                        {

                        }
                        if (txtarama.Text.Length == 10)
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Cihaz_Tamir where Tarih like'" + txtarama.Text + "'", baglanti);
                            da.Fill(tablo);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                    if (txtarama.Text.Length > 0)
                    {
                        OleDbDataAdapter da0 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Cihaz_Adı like'" + txtarama.Text + "'", baglanti);
                        da0.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Ad like'" + txtarama.Text + "'", baglanti);
                        da1.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Soyad like'" + txtarama.Text + "'", baglanti);
                        da2.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da3 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Telefon_No like'" + txtarama.Text + "'", baglanti);
                        da3.Fill(tablo);
                        dataGridView1.DataSource = tablo;                        
                    }
                    else
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Cihaz_Tamir", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                }
                if (btnbitenislemlertablo.BackColor == Color.AliceBlue)
                {
                    DataTable tablo = new DataTable();
                    if (txtarama.Text == "")
                    {

                    }
                    string teslimedildi = "Teslim Edildi";
                    if (cmbxaramaturusec.SelectedIndex == 1) // tarihe göre arama
                    {
                        string yazitut;
                        if (txtarama.Text.Length == 4)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text.Length == 7)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text == "")
                        {

                        }
                        if (txtarama.Text.Length == 10)
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Cihaz_Tamir where Tarih like'" + txtarama.Text + "' and Durum='" + teslimedildi + "'", baglanti);
                            da.Fill(tablo);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                    if (txtarama.Text.Length > 0)
                    {
                        OleDbDataAdapter da0 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Cihaz_Adı like'" + txtarama.Text + "' and Durum='" + teslimedildi + "'", baglanti);
                        da0.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Ad like'" + txtarama.Text + "' and Durum='" + teslimedildi + "'", baglanti);
                        da1.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Soyad like'" + txtarama.Text + "' and Durum='" + teslimedildi + "'", baglanti);
                        da2.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da3 = new OleDbDataAdapter("Select * from Cihaz_Tamir where Musteri_Telefon_No like'" + txtarama.Text + "' and Durum='" + teslimedildi + "'", baglanti);
                        da3.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Cihaz_Tamir Where Durum='" + teslimedildi + "'", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                }

                if (btnurunlertablosu.BackColor == Color.AliceBlue)
                {
                    DataTable tablo = new DataTable();
                    if (txtarama.Text == "")
                    {

                    }
                    
                    if (cmbxaramaturusec.SelectedIndex == 1) // tarihe göre arama
                    {
                        string yazitut;
                        if (txtarama.Text.Length == 4)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text.Length == 7)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text == "")
                        {

                        }
                        if (txtarama.Text.Length == 10)
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Urunler where Urun_Gelis_Tarihi like'" + txtarama.Text + "'", baglanti);
                            da.Fill(tablo);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                    if (txtarama.Text.Length > 0)
                    {
                        OleDbDataAdapter da0 = new OleDbDataAdapter("Select * from Urunler where Urun_Adi like'" + txtarama.Text + "' ", baglanti);
                        da0.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Urunler where Urun_Markasi like'" + txtarama.Text + "'", baglanti);
                        da1.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Urunler where Urun_Modeli like'" + txtarama.Text + "' ", baglanti);
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
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Urunler ", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                }


                if (btnsatisislemleritablosu.BackColor == Color.AliceBlue)
                {
                    DataTable tablo = new DataTable();
                    if (txtarama.Text == "")
                    {

                    }
                    if (cmbxaramaturusec.SelectedIndex == 1)
                    {

                        string yazitut;
                        if (txtarama.Text.Length == 4)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;


                        }
                        if (txtarama.Text.Length == 7)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }


                        if (txtarama.Text == "")
                        {

                        }
                        if (txtarama.Text.Length == 10)
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Satis_İslemleri where Tarih like'" + txtarama.Text + "'", baglanti);
                            da.Fill(tablo);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                    if (txtarama.Text.Length > 0)
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Satis_İslemleri where Urun_Adi like'" + txtarama.Text + "'", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Satis_İslemleri where Urun_Markasi like'" + txtarama.Text + "'", baglanti);
                        da1.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Satis_İslemleri where Urun_Modeli like'" + txtarama.Text + "'", baglanti);
                        da2.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da3 = new OleDbDataAdapter("Select * from Satis_İslemleri where Urun_Turu like'" + txtarama.Text + "'", baglanti);
                        da3.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da4 = new OleDbDataAdapter("Select * from Satis_İslemleri where Satis_No like'" + Convert.ToInt32(txtarama.Text) + "'", baglanti);
                        da4.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da5 = new OleDbDataAdapter("Select * from Satis_İslemleri where Urun_No like'" + Convert.ToInt32(txtarama.Text) + "'", baglanti);
                        da5.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Satis_İslemleri", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }


                }
                if (btnmusteritablo.BackColor == Color.AliceBlue)
                {
                    DataTable tablo = new DataTable();
                    if (txtarama.Text == "")
                    {

                    }
                    if (cmbxaramaturusec.SelectedIndex == 1)
                    {
                        string yazitut;
                        if (txtarama.Text.Length == 4)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text.Length == 7)
                        {
                            yazitut = txtarama.Text;
                            txtarama.Text = ".";
                            txtarama.Text += yazitut;
                        }
                        if (txtarama.Text == "")
                        {

                        }
                        if (txtarama.Text.Length == 10)
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Musteri where Tarih like'" + txtarama.Text + "'", baglanti);
                            da.Fill(tablo);
                            dataGridView1.DataSource = tablo;
                        }
                    }
                    if (txtarama.Text.Length > 0)
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Musteri where Musteri_Ad like'" + txtarama.Text + "'", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da1 = new OleDbDataAdapter("Select * from Musteri where Musteri_Soyad like'" + txtarama.Text + "'", baglanti);
                        da1.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da2 = new OleDbDataAdapter("Select * from Musteri where Musteri_Adres like'" + txtarama.Text + "'", baglanti);
                        da2.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da3 = new OleDbDataAdapter("Select * from Musteri where Musteri_Tel_No like'" + txtarama.Text + "'", baglanti);
                        da3.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                        OleDbDataAdapter da4 = new OleDbDataAdapter("Select * from Musteri where Musteri_TC like'" + txtarama.Text + "'", baglanti);
                        da4.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    else
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Musteri", baglanti);
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                }
            }
            catch (Exception)
            {


            }
           
            
       

                baglanti.Close();
        }

        private void textBox1_TabStopChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cmbxaramaturusec.SelectedIndex == 0)
            {
                txtarama.Text = "Ara";
            }
            
            if (cmbxaramaturusec.SelectedIndex == 1)
            {
                txtarama.Text = "yıl/ay/gün";
            }
            

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(txtarama.Text== "yıl/ay/gün")
            {
                txtarama.Text = "";
            }
            if (txtarama.Text == "Ara")
            {
                txtarama.Text = "";
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtarama.Text  = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbxaramaturusec.SelectedIndex == 1)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        string deger;
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.Controls.Clear();
            if (btnsatisislemleritablosu.BackColor == Color.AliceBlue)
            {
                deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                btnmusteritablo.PerformClick();
                try
                {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Musteri where Musteri_Satis_No like'" + Convert.ToInt32(deger) + "'", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                
                }
                catch (Exception)
                {
                    MessageBox.Show("Seçili satışın müşteri bilgilerine ulaşılamıyor.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                
            }
            else
            {
                if (btnmusteritablo.BackColor == Color.AliceBlue)
                {
                    deger = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    btnsatisislemleritablosu.PerformClick();
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from Satis_İslemleri where Satis_No like'" + Convert.ToInt32(deger) + "'", baglanti);
                        DataTable tablo = new DataTable();
                        da.Fill(tablo);
                        dataGridView1.DataSource = tablo;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Seçili müşterinin satış bilgilerine ulaşılamıyor.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    if (btncihazlartablosu.BackColor == Color.AliceBlue)
                    {
                       
                            baglanti.Open();
                            deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            frmcihazekle frmcihazekle = new frmcihazekle();                           
                            OleDbCommand cmd = new OleDbCommand("Select * from Cihaz_Tamir where İslem_No=" + Convert.ToInt32(deger) + "", baglanti);
                            OleDbDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                frmcihazekle.txtcihazadi.Text = dr[1].ToString();
                                frmcihazekle.txtariza.Text = dr[2].ToString();
                                frmcihazekle.txtsifre.Text = dr[3].ToString();
                                frmcihazekle.txtmusteriad.Text = dr[4].ToString();
                                frmcihazekle.txtmusterisoyad.Text = dr[5].ToString();
                                frmcihazekle.txtadres.Text = dr[6].ToString();
                                frmcihazekle.txttel.Text = dr[7].ToString();
                                frmcihazekle.cmbdurum.Text = dr[8].ToString();
                                frmcihazekle.txtmaliyet.Text = dr[9].ToString();
                                frmcihazekle.txtUcret.Text = dr[10].ToString();
                                frmcihazekle.txtkar.Text = dr[11].ToString();                               
                                frmcihazekle.txtkullaniciadi.Text = dr[12].ToString();
                                frmcihazekle.txtnot.Text = dr[13].ToString();
                                frmcihazekle.txttarih.Text = dr[14].ToString(); 
                            }
                        baglanti.Close();
                        frmcihazekle.lblislemno.Text = deger;
                        frmcihazekle.acilisamaci = 1;
                        /////////////////
                       frmcihazekle. cmbdurum.Enabled = false;
                        frmcihazekle.txtkar.Enabled = false;
                        frmcihazekle.txtnot.Enabled = false;
                        //////////////
                        frmcihazekle.txtadres.Enabled = false;
                        frmcihazekle.txtariza.Enabled = false;
                        frmcihazekle.txtcihazadi.Enabled = false;
                        frmcihazekle.txtmusteriad.Enabled = false;
                        frmcihazekle.txtmusterisoyad.Enabled = false;
                        frmcihazekle.txtsifre.Enabled = false;
                        frmcihazekle.txttel.Enabled = false;
                        frmcihazekle.groupBox1.Enabled = false;
                        frmcihazekle.txtmaliyet.Enabled = false;
                        frmcihazekle.txtkar.Enabled = false;
                        frmcihazekle.txtUcret.Enabled = false;
                        frmcihazekle.btnyenidendene.Enabled = false;
                        frmcihazekle.btnkaydet.Visible = false;
                        frmcihazekle.button1.Visible = true;                        
                        frmcihazekle.Show();

                    }
                    else
                    {
                        if (btnbitenislemlertablo.BackColor == Color.AliceBlue)
                        {

                            baglanti.Open();
                            deger = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            frmcihazekle frmcihazekle = new frmcihazekle();
                            OleDbCommand cmd = new OleDbCommand("Select * from Cihaz_Tamir where İslem_No=" + Convert.ToInt32(deger) + "", baglanti);
                            OleDbDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                frmcihazekle.txtcihazadi.Text = dr[1].ToString();
                                frmcihazekle.txtariza.Text = dr[2].ToString();
                                frmcihazekle.txtsifre.Text = dr[3].ToString();
                                frmcihazekle.txtmusteriad.Text = dr[4].ToString();
                                frmcihazekle.txtmusterisoyad.Text = dr[5].ToString();
                                frmcihazekle.txtadres.Text = dr[6].ToString();
                                frmcihazekle.txttel.Text = dr[7].ToString();
                                frmcihazekle.cmbdurum.Text = dr[8].ToString();
                                frmcihazekle.txtmaliyet.Text = dr[9].ToString();
                                frmcihazekle.txtUcret.Text = dr[10].ToString();
                                frmcihazekle.txtkar.Text = dr[11].ToString();
                                frmcihazekle.txtkullaniciadi.Text = dr[12].ToString();
                                frmcihazekle.txtnot.Text = dr[13].ToString();
                                frmcihazekle.txttarih.Text = dr[14].ToString();
                            }
                            baglanti.Close();
                            frmcihazekle.lblislemno.Text = deger;
                            frmcihazekle.acilisamaci = 1;
                            /////////////////
                            frmcihazekle.cmbdurum.Enabled = false;
                            frmcihazekle.txtkar.Enabled = false;
                            frmcihazekle.txtnot.Enabled = false;
                            //////////////
                            frmcihazekle.txtadres.Enabled = false;
                            frmcihazekle.txtariza.Enabled = false;
                            frmcihazekle.txtcihazadi.Enabled = false;
                            frmcihazekle.txtmusteriad.Enabled = false;
                            frmcihazekle.txtmusterisoyad.Enabled = false;
                            frmcihazekle.txtsifre.Enabled = false;
                            frmcihazekle.txttel.Enabled = false;
                            frmcihazekle.groupBox1.Enabled = false;
                            frmcihazekle.txtmaliyet.Enabled = false;
                            frmcihazekle.txtkar.Enabled = false;
                            frmcihazekle.txtUcret.Enabled = false;
                            frmcihazekle.btnyenidendene.Enabled = false;
                            frmcihazekle.btnkaydet.Visible = false;
                            frmcihazekle.button1.Visible = true;
                            frmcihazekle.Show();

                        }
                    }
                }
            }
            
            
        }

        private void görüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnurunlertablosu.BackColor == Color.AliceBlue)
            {
                frmurungoruntule frmurungoruntule = new frmurungoruntule();
                frmurungoruntule.txturunno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmurungoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmurungoruntule.txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmurungoruntule.txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmurungoruntule.txttur.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmurungoruntule.txtfiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmurungoruntule.txtgelisfiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmurungoruntule.txtkar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmurungoruntule.txtgaranti.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmurungoruntule.txtadet.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmurungoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmurungoruntule.ShowDialog();
            }
            if (btnsatisislemleritablosu.BackColor == Color.AliceBlue)
            {
                frmsatisislemigoruntule frmsatisislemigoruntule = new frmsatisislemigoruntule();
                frmsatisislemigoruntule.txtsatisno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmsatisislemigoruntule.txturunno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmsatisislemigoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmsatisislemigoruntule.txtmarka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmsatisislemigoruntule.txtmodel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmsatisislemigoruntule.txttur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmsatisislemigoruntule.txtfiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmsatisislemigoruntule.txtgaranti.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmsatisislemigoruntule.txtadet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmsatisislemigoruntule.txttoplamtutar.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmsatisislemigoruntule.cmbsatisturu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmsatisislemigoruntule.cmbtahsilturu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                frmsatisislemigoruntule.txtnot.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                frmsatisislemigoruntule.txtkadi.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                frmsatisislemigoruntule.txtkar.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                frmsatisislemigoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                frmsatisislemigoruntule.ShowDialog();
            }
            if (btnmusteritablo.BackColor == Color.AliceBlue)
            {
                frmmusterigoruntule frmmusterigoruntule = new frmmusterigoruntule();
                frmmusterigoruntule.txttel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmmusterigoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmmusterigoruntule.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmmusterigoruntule.txttc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmmusterigoruntule.txtadres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmmusterigoruntule.txtmusterisatisno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmmusterigoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmmusterigoruntule.txtad.Enabled = false;
                frmmusterigoruntule.txtadres.Enabled = false;
                frmmusterigoruntule.txtmusterisatisno.Enabled = false;
                frmmusterigoruntule.txtsoyad.Enabled = false;
                frmmusterigoruntule.txttarih.Enabled = false;
                frmmusterigoruntule.txttc.Enabled = false;
                frmmusterigoruntule.txttel.Enabled = false;
                frmmusterigoruntule.ShowDialog();
            }



        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//farenin sağ tuşuna basılmışsa
            {
                
                int satir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dataGridView1.Rows[satir].Selected = true;//bu tıkladığımız alanı seçtiriyoruz
                    dataGridView1.CurrentCell = dataGridView1.Rows[satir].Cells[0];
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnurunlertablosu.BackColor == Color.AliceBlue)
            {
                frmurungoruntule frmurungoruntule = new frmurungoruntule();
                frmurungoruntule.txturunno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmurungoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmurungoruntule.txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmurungoruntule.txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmurungoruntule.txttur.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmurungoruntule.txtfiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmurungoruntule.txtgelisfiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmurungoruntule.txtkar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmurungoruntule.txtgaranti.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmurungoruntule.txtadet.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmurungoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmurungoruntule.ShowDialog();
                btnurunlertablosu.PerformClick();
            }
            if (btnsatisislemleritablosu.BackColor == Color.AliceBlue)
            {
                frmsatisislemigoruntule frmsatisislemigoruntule = new frmsatisislemigoruntule();
                frmsatisislemigoruntule.txtsatisno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmsatisislemigoruntule.txturunno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmsatisislemigoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmsatisislemigoruntule.txtmarka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmsatisislemigoruntule.txtmodel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmsatisislemigoruntule.txttur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmsatisislemigoruntule.txtfiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmsatisislemigoruntule.txtgaranti.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frmsatisislemigoruntule.txtadet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frmsatisislemigoruntule.txttoplamtutar.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frmsatisislemigoruntule.cmbsatisturu.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frmsatisislemigoruntule.cmbtahsilturu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                frmsatisislemigoruntule.txtnot.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                frmsatisislemigoruntule.txtkadi.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                frmsatisislemigoruntule.txtkar.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                frmsatisislemigoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                frmsatisislemigoruntule.Size = new Size(879, 435);
                frmsatisislemigoruntule.txtadet.Enabled = true;                
                frmsatisislemigoruntule.cmbtahsilturu.Enabled = true;
                frmsatisislemigoruntule.txtnot.Enabled = true;               
                frmsatisislemigoruntule.ShowDialog();
                btnsatisislemleritablosu.PerformClick();
            }
            if (btnmusteritablo.BackColor == Color.AliceBlue)
            {
                frmmusterigoruntule frmmusterigoruntule = new frmmusterigoruntule();
                frmmusterigoruntule.txttel.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmmusterigoruntule.txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmmusterigoruntule.txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmmusterigoruntule.txttc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmmusterigoruntule.txtadres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmmusterigoruntule.txtmusterisatisno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmmusterigoruntule.txttarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frmmusterigoruntule.Size = new Size(316, 470);
                frmmusterigoruntule.txtad.Enabled = true;
                frmmusterigoruntule.txtadres.Enabled = true;
                frmmusterigoruntule.txtmusterisatisno.Enabled = true;
                frmmusterigoruntule.txtsoyad.Enabled = true;
                frmmusterigoruntule.txttarih.Enabled = true;
                frmmusterigoruntule.txttc.Enabled = true;
                frmmusterigoruntule.txttel.Enabled = true;
                frmmusterigoruntule.ShowDialog();
                btnmusteritablo.PerformClick();

            }
        }
        string birincilanahtar;
        string fiyat;
        string kar;
        string satisno;
        string aciklama;
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (btnsatisislemleritablosu.BackColor == Color.AliceBlue)
            {
                DialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz?","DST",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (DialogResult==DialogResult.Yes)
                {
                    try
                    {
                        
                        birincilanahtar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "Select * from Satis_İslemleri where Satis_No=" + Convert.ToInt32(birincilanahtar) + "";
                        OleDbDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            satisno = dr[0].ToString();
                            fiyat = dr[6].ToString();
                            kar = dr[14].ToString();
                            
                        }                        
                        baglanti.Close();

                        aciklama = satisno + " nolu satış iptal edilip sistemden eksiltilmiştir.";
                        int fyt = Convert.ToInt32(fiyat);
                        int kr = Convert.ToInt32(kar);
                        int gider = (fyt);
                            baglanti.Close();
                            baglanti.Open();
                            OleDbCommand kmt = new OleDbCommand();
                            kmt.Connection = baglanti;
                            kmt.CommandText = ("INSERT INTO Raporlar([Tarih],[Gelir],[Gider],[Kar],[Aciklama]) VALUES (?,?,?,?,?)");
                            kmt.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                            kmt.Parameters.AddWithValue("@Gelir", 0);
                            kmt.Parameters.AddWithValue("@Gider", gider);
                            kmt.Parameters.AddWithValue("@Kar", 0);
                            kmt.Parameters.AddWithValue("@Aciklama", aciklama.ToString());
                            kmt.ExecuteNonQuery();
                            baglanti.Close();
                       


                        MessageBox.Show("Satış raporlar bölümünden eksiltildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnsatisislemleritablosu.PerformClick();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Satış raporlar bölümünden eksiltilemedi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnsatisislemleritablosu.PerformClick();
                    }


                    try
                    {
                        birincilanahtar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "delete from Satis_İslemleri where Satis_No=" + Convert.ToInt32(birincilanahtar) + "";
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Satış silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnsatisislemleritablosu.PerformClick();

                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Satış silinemedi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                
            }
            if (btnmusteritablo.BackColor == Color.AliceBlue)
            {
                DialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz?", "DST", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        birincilanahtar = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        baglanti.Open();
                        OleDbCommand komut = new OleDbCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "delete from Musteri where Musteri_Satis_No=" + Convert.ToInt32(birincilanahtar) + "";
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Müşteri silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnmusteritablo.PerformClick();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Müşteri silinemedi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
               
            }
            if (btnurunlertablosu.BackColor == Color.AliceBlue)
            {
                DialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz?", "DST", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        try
                        {
                            birincilanahtar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                            baglanti.Open();
                            OleDbCommand komut = new OleDbCommand();
                            komut.Connection = baglanti;
                            komut.CommandText = "delete from Urunler where Urun_No=" + Convert.ToInt32(birincilanahtar) + "";
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Ürün silindi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnurunlertablosu.PerformClick();
                        }
                        catch (Exception)
                        {

                           
                        }
                      
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ürün silinemedi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }




        }

        private void btncihazlartablosu_Click(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = sagtik_datagridview_cihaz;
            sagtik_datagridview.Enabled = true;
            sagtik_datagridview_cihaz.Enabled = true;

            //verileri çekme
            verilerigoruntule5();
            //
            btncihazlartablosu.BackColor = Color.AliceBlue;
            //diğerlerini aynı yapma
            btnsatisislemleritablosu.BackColor = Color.Transparent;
            btnmusteritablo.BackColor = Color.Transparent;
            btnurunlertablosu.BackColor = Color.Transparent;
            btnbitenislemlertablo.BackColor = Color.Transparent;
            //yazı rengi
            btncihazlartablosu.ForeColor = Color.DarkBlue;

            //diğerleri
            btnmusteritablo.ForeColor = Color.DarkCyan;
            btnsatisislemleritablosu.ForeColor = Color.DarkCyan;
            btnurunlertablosu.ForeColor = Color.DarkCyan;
            btnbitenislemlertablo.ForeColor = Color.DarkCyan;
            //
            cmbxaramaturusec.Items.Clear();
            cmbxaramaturusec.Items.Add("Genel Arama");
            cmbxaramaturusec.Items.Add("Tarihe Göre Arama");
            cmbxaramaturusec.SelectedIndex = 0;

        }

        private void sagtik_datagridview_cihaz_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fiyatBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmfiyatbelirle frmfiyatbelirle = new frmfiyatbelirle();
                frmfiyatbelirle.islemno = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                frmfiyatbelirle.ShowDialog();
                btncihazlartablosu.PerformClick();
            }
            catch (Exception)
            {

               
            }
            
        }

        private void işlemeAlındıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Durum='" + "İşleme Alındı" + "' WHERE İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            btncihazlartablosu.PerformClick();

        }

        private void beklemedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Durum='" + "Beklemede" + "' WHERE İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            btncihazlartablosu.PerformClick();
        }

        private void servisdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Durum='" + "Serviste" + "' WHERE İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            btncihazlartablosu.PerformClick();
        }

        private void işlemBittiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Durum='" + "İşlem Bitti" + "' WHERE İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            btncihazlartablosu.PerformClick();
        }
        string maliyet;
        string ucret;
       
        private void tamamlandıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string birincilanahtar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Cihaz_Tamir SET Durum='" + "Teslim Edildi" + "' WHERE İslem_No=" + Convert.ToInt32(birincilanahtar) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            try
            {
                baglanti.Open();
                OleDbCommand kmt1 = new OleDbCommand();
                kmt1.Connection = baglanti;
                kmt1.CommandText = "SELECT * FROM Cihaz_Tamir WHERE İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                OleDbDataReader vo = kmt1.ExecuteReader();
                while (vo.Read())
                {
                    ucret = vo[10].ToString();
                    maliyet = vo[9].ToString();
                }
                baglanti.Close();

               
            }
            catch (Exception)
            {
                MessageBox.Show("ürün verilerine erişilemiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            int gelir = Convert.ToInt32(ucret);
            int gider = Convert.ToInt32(maliyet);
            int kar = gelir - gider;
            try
            {
                string aciklama = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " nolu işlem (" + ucret + ") fiyatı ile tamamlanıp teslim edilmiş ve gelir sisteme eklenmiştir.";                
                baglanti.Close();
                baglanti.Open();
                OleDbCommand kmt = new OleDbCommand();
                kmt.Connection = baglanti;
                kmt.CommandText = ("INSERT INTO Raporlar([Tarih],[Gelir],[Gider],[Kar],[Aciklama]) VALUES (?,?,?,?,?)");
                kmt.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                kmt.Parameters.AddWithValue("@Gelir", gelir);
                kmt.Parameters.AddWithValue("@Gider", gider);
                kmt.Parameters.AddWithValue("@Kar", kar);
                kmt.Parameters.AddWithValue("@Aciklama", aciklama);
                kmt.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gelir bölümüne eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btncihazlartablosu.PerformClick();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = "delete from Cihaz_Tamir where İslem_No=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem gerçekleştirilemedi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            btncihazlartablosu.PerformClick();
        }

        private void btnbitenislemlertablo_Click(object sender, EventArgs e)
        {
            //verileri çekme
            verilerigoruntule6();
            //
            btnbitenislemlertablo.BackColor = Color.AliceBlue;
            //diğerlerini aynı yapma
            btnsatisislemleritablosu.BackColor = Color.Transparent;
            btnmusteritablo.BackColor = Color.Transparent;
            btnurunlertablosu.BackColor = Color.Transparent;
            btncihazlartablosu.BackColor = Color.Transparent;
            //yazı rengi
            btnbitenislemlertablo.ForeColor = Color.DarkBlue;

            //diğerleri
            btnmusteritablo.ForeColor = Color.DarkCyan;
            btnsatisislemleritablosu.ForeColor = Color.DarkCyan;
            btnurunlertablosu.ForeColor = Color.DarkCyan;
            btncihazlartablosu.ForeColor = Color.DarkCyan;
            //
            cmbxaramaturusec.Items.Clear();
            cmbxaramaturusec.Items.Add("Genel Arama");
            cmbxaramaturusec.Items.Add("Tarihe Göre Arama");
            cmbxaramaturusec.SelectedIndex = 0;

            sagtik_datagridview.Enabled = false;
            sagtik_datagridview_cihaz.Enabled = false;
        }
    }
}
