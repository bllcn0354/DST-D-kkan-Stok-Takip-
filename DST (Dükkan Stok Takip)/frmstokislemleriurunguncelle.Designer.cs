
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmstokislemleriurunguncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtgelisfiyat = new System.Windows.Forms.TextBox();
            this.txtgaranti = new System.Windows.Forms.TextBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmburunturu = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtarama
            // 
            this.txtarama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.Location = new System.Drawing.Point(936, 4);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(245, 26);
            this.txtarama.TabIndex = 1;
            this.txtarama.Text = "Ara";
            this.txtarama.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            this.txtarama.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtarama_MouseMove);
            // 
            // txtno
            // 
            this.txtno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtno.BackColor = System.Drawing.Color.Gainsboro;
            this.txtno.Enabled = false;
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtno.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtno.Location = new System.Drawing.Point(366, 7);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(500, 22);
            this.txtno.TabIndex = 2;
            this.txtno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_KeyPress);
            // 
            // txtad
            // 
            this.txtad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtad.BackColor = System.Drawing.Color.Gainsboro;
            this.txtad.Enabled = false;
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtad.Location = new System.Drawing.Point(366, 32);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(500, 22);
            this.txtad.TabIndex = 3;
            // 
            // txtmarka
            // 
            this.txtmarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmarka.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmarka.Enabled = false;
            this.txtmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtmarka.Location = new System.Drawing.Point(366, 57);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(500, 22);
            this.txtmarka.TabIndex = 4;
            // 
            // txtmodel
            // 
            this.txtmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmodel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmodel.Enabled = false;
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmodel.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtmodel.Location = new System.Drawing.Point(366, 82);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(500, 22);
            this.txtmodel.TabIndex = 5;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfiyat.Enabled = false;
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfiyat.Location = new System.Drawing.Point(366, 134);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(500, 22);
            this.txtfiyat.TabIndex = 7;
            this.txtfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiyat_KeyPress);
            // 
            // txtgelisfiyat
            // 
            this.txtgelisfiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgelisfiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.txtgelisfiyat.Enabled = false;
            this.txtgelisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgelisfiyat.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtgelisfiyat.Location = new System.Drawing.Point(366, 159);
            this.txtgelisfiyat.Name = "txtgelisfiyat";
            this.txtgelisfiyat.Size = new System.Drawing.Size(500, 22);
            this.txtgelisfiyat.TabIndex = 8;
            this.txtgelisfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgelisfiyat_KeyPress);
            // 
            // txtgaranti
            // 
            this.txtgaranti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgaranti.BackColor = System.Drawing.Color.Gainsboro;
            this.txtgaranti.Enabled = false;
            this.txtgaranti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgaranti.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtgaranti.Location = new System.Drawing.Point(366, 184);
            this.txtgaranti.Name = "txtgaranti";
            this.txtgaranti.Size = new System.Drawing.Size(500, 22);
            this.txtgaranti.TabIndex = 9;
            this.txtgaranti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgaranti_KeyPress);
            // 
            // txtadet
            // 
            this.txtadet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtadet.BackColor = System.Drawing.Color.Gainsboro;
            this.txtadet.Enabled = false;
            this.txtadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadet.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtadet.Location = new System.Drawing.Point(366, 232);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(500, 22);
            this.txtadet.TabIndex = 11;
            this.txtadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadet_KeyPress);
            // 
            // txttarih
            // 
            this.txttarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttarih.BackColor = System.Drawing.Color.Gainsboro;
            this.txttarih.Enabled = false;
            this.txttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttarih.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttarih.Location = new System.Drawing.Point(366, 257);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(500, 22);
            this.txttarih.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün No";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(325, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(293, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Markası";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(301, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Modeli";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(317, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(310, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fiyatı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(270, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Geliş Fiyatı";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(250, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Garanti Süresi";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(316, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Adet";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(312, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tarih";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1184, 99);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmburunturu
            // 
            this.cmburunturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmburunturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburunturu.Enabled = false;
            this.cmburunturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburunturu.ForeColor = System.Drawing.Color.DarkGreen;
            this.cmburunturu.FormattingEnabled = true;
            this.cmburunturu.Location = new System.Drawing.Point(366, 107);
            this.cmburunturu.Name = "cmburunturu";
            this.cmburunturu.Size = new System.Drawing.Size(500, 24);
            this.cmburunturu.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(366, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Garanti Yok";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.cmburunturu);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.txtmarka);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtmodel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtfiyat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtgelisfiyat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtgaranti);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtadet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttarih);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 285);
            this.panel1.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtarama);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 36);
            this.panel2.TabIndex = 24;
            // 
            // frmstokislemleriurunguncelle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 664);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstokislemleriurunguncelle";
            this.Text = "frmstoktakipguncelle";
            this.Load += new System.EventHandler(this.frmstoktakipguncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtgelisfiyat;
        private System.Windows.Forms.TextBox txtgaranti;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmburunturu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}