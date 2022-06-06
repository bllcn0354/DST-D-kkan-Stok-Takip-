using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRYazilimLisans
{
    public partial class frmlisanssec : Form
    {
        public frmlisanssec()
        {
            InitializeComponent();
        }

        private void frmlisanssec_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("DST_standartedition.png");
            button2.BackgroundImage = Image.FromFile("DST premiumedition.png");
            button3.BackgroundImage = Image.FromFile("DST proedition.png");

        }
    }
}
