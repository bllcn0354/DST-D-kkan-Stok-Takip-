using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DST__Dükkan_Stok_Takip_
{
    public partial class frmfatura : Form
    {
        public frmfatura()
        {
            InitializeComponent();
        }
        frmsaturunbilgisi frmsaturunbilgisi = new frmsaturunbilgisi();
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(frmsatisislemleri.faturayazisi , new Font("Calibri",11),Brushes.Black ,new PointF(0,0));
            
        }

        private void frmfatura_Load(object sender, EventArgs e)
        {
            
            printPreviewControl1.Zoom = 1;

           

        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {          
            Fatura.Print();           
            //printDialog1.ShowDialog();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
