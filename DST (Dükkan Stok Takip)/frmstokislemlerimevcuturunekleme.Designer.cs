
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmstokislemlerimevcuturunekleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtgelisfiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtgaranti = new System.Windows.Forms.TextBox();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cmburunturu = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chbxgarantiyok = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(830, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtarama
            // 
            this.txtarama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.Location = new System.Drawing.Point(582, 5);
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
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtno.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtno.Location = new System.Drawing.Point(181, 19);
            this.txtno.MaxLength = 5;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(500, 26);
            this.txtno.TabIndex = 2;
            this.txtno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_KeyPress);
            // 
            // txtad
            // 
            this.txtad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtad.BackColor = System.Drawing.Color.Gainsboro;
            this.txtad.Enabled = false;
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtad.Location = new System.Drawing.Point(181, 51);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(500, 26);
            this.txtad.TabIndex = 3;
            // 
            // txtmarka
            // 
            this.txtmarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmarka.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmarka.Enabled = false;
            this.txtmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtmarka.Location = new System.Drawing.Point(181, 81);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(500, 26);
            this.txtmarka.TabIndex = 4;
            // 
            // txtmodel
            // 
            this.txtmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmodel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmodel.Enabled = false;
            this.txtmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmodel.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtmodel.Location = new System.Drawing.Point(181, 113);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(500, 26);
            this.txtmodel.TabIndex = 5;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.txtfiyat.Enabled = false;
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtfiyat.Location = new System.Drawing.Point(181, 179);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(500, 26);
            this.txtfiyat.TabIndex = 7;
            this.txtfiyat.TextChanged += new System.EventHandler(this.txtfiyat_TextChanged);
            this.txtfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiyat_KeyPress);
            // 
            // txtgelisfiyat
            // 
            this.txtgelisfiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgelisfiyat.BackColor = System.Drawing.Color.Gainsboro;
            this.txtgelisfiyat.Enabled = false;
            this.txtgelisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgelisfiyat.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtgelisfiyat.Location = new System.Drawing.Point(181, 211);
            this.txtgelisfiyat.Name = "txtgelisfiyat";
            this.txtgelisfiyat.Size = new System.Drawing.Size(500, 26);
            this.txtgelisfiyat.TabIndex = 8;
            this.txtgelisfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgelisfiyat_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Numarası";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(140, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(104, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Markası";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(114, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Modeli";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(130, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Türü";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(123, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fiyatı";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(77, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Geliş Fiyatı";
            // 
            // txtgaranti
            // 
            this.txtgaranti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgaranti.BackColor = System.Drawing.Color.Gainsboro;
            this.txtgaranti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgaranti.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtgaranti.Location = new System.Drawing.Point(181, 243);
            this.txtgaranti.Name = "txtgaranti";
            this.txtgaranti.Size = new System.Drawing.Size(500, 26);
            this.txtgaranti.TabIndex = 9;
            this.txtgaranti.TextChanged += new System.EventHandler(this.txtgaranti_TextChanged);
            this.txtgaranti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgaranti_KeyDown);
            this.txtgaranti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgaranti_KeyPress);
            // 
            // txtadet
            // 
            this.txtadet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtadet.BackColor = System.Drawing.Color.Gainsboro;
            this.txtadet.Enabled = false;
            this.txtadet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadet.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtadet.Location = new System.Drawing.Point(181, 305);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(500, 26);
            this.txtadet.TabIndex = 11;
            this.txtadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadet_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(50, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Garanti Süresi";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkCyan;
            this.label9.Location = new System.Drawing.Point(126, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tarih";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(128, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Adet";
            // 
            // txttarih
            // 
            this.txttarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttarih.BackColor = System.Drawing.Color.Gainsboro;
            this.txttarih.Enabled = false;
            this.txttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttarih.ForeColor = System.Drawing.Color.DarkGreen;
            this.txttarih.Location = new System.Drawing.Point(181, 337);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(500, 26);
            this.txttarih.TabIndex = 12;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydet.Location = new System.Drawing.Point(0, 521);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(830, 99);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            this.btnkaydet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnkaydet_KeyDown);
            this.btnkaydet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnkaydet_KeyPress);
            // 
            // cmburunturu
            // 
            this.cmburunturu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmburunturu.BackColor = System.Drawing.Color.Gainsboro;
            this.cmburunturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburunturu.Enabled = false;
            this.cmburunturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburunturu.ForeColor = System.Drawing.Color.Green;
            this.cmburunturu.FormattingEnabled = true;
            this.cmburunturu.Location = new System.Drawing.Point(181, 145);
            this.cmburunturu.Name = "cmburunturu";
            this.cmburunturu.Size = new System.Drawing.Size(500, 28);
            this.cmburunturu.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chbxgarantiyok
            // 
            this.chbxgarantiyok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbxgarantiyok.AutoSize = true;
            this.chbxgarantiyok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbxgarantiyok.ForeColor = System.Drawing.Color.DarkGreen;
            this.chbxgarantiyok.Location = new System.Drawing.Point(181, 275);
            this.chbxgarantiyok.Name = "chbxgarantiyok";
            this.chbxgarantiyok.Size = new System.Drawing.Size(124, 24);
            this.chbxgarantiyok.TabIndex = 10;
            this.chbxgarantiyok.Text = "Garanti Yok";
            this.chbxgarantiyok.UseVisualStyleBackColor = true;
            this.chbxgarantiyok.CheckedChanged += new System.EventHandler(this.chbxgarantiyok_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttarih);
            this.panel1.Controls.Add(this.chbxgarantiyok);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.cmburunturu);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.txtmarka);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtmodel);
            this.panel1.Controls.Add(this.txtfiyat);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtgelisfiyat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtadet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtgaranti);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 369);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtarama);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 37);
            this.panel2.TabIndex = 24;
            // 
            // frmstokislemlerimevcuturunekleme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(830, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmstokislemlerimevcuturunekleme";
            this.Load += new System.EventHandler(this.frmstokislemlerimevcuturunekleme_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgaranti;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.ComboBox cmburunturu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chbxgarantiyok;
        public System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}