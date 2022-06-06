
namespace BRYazilimLisans
{
    partial class BRYazilimLisansProgrami
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnlisanstercihleri = new System.Windows.Forms.Button();
            this.btndemo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnlisanstercihleri);
            this.panel1.Controls.Add(this.btndemo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 541);
            this.panel1.TabIndex = 2;
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Transparent;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncikis.Location = new System.Drawing.Point(3, 351);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(197, 84);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnlisanstercihleri
            // 
            this.btnlisanstercihleri.BackColor = System.Drawing.Color.Transparent;
            this.btnlisanstercihleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlisanstercihleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlisanstercihleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlisanstercihleri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlisanstercihleri.Location = new System.Drawing.Point(3, 243);
            this.btnlisanstercihleri.Name = "btnlisanstercihleri";
            this.btnlisanstercihleri.Size = new System.Drawing.Size(197, 84);
            this.btnlisanstercihleri.TabIndex = 1;
            this.btnlisanstercihleri.Text = "LİSANS TERCİHLERİ";
            this.btnlisanstercihleri.UseVisualStyleBackColor = false;
            this.btnlisanstercihleri.Click += new System.EventHandler(this.btnlisanstercihleri_Click);
            // 
            // btndemo
            // 
            this.btndemo.BackColor = System.Drawing.Color.Transparent;
            this.btndemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndemo.Enabled = false;
            this.btndemo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndemo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btndemo.Location = new System.Drawing.Point(3, 135);
            this.btndemo.Name = "btndemo";
            this.btndemo.Size = new System.Drawing.Size(197, 84);
            this.btndemo.TabIndex = 0;
            this.btndemo.Text = "Demo";
            this.btndemo.UseVisualStyleBackColor = false;
            this.btndemo.Click += new System.EventHandler(this.btndemo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(221, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 541);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(669, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BRYazilimLisansProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BRYazilimLisans.Properties.Resources.SOFT_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BRYazilimLisansProgrami";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BRYazilimLisansProgrami_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnlisanstercihleri;
        private System.Windows.Forms.Button btndemo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

