
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmraporlar
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
            this.pnlustbolum = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngenelrapor = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtptakvimbitis = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.dtptakvimbaslangic = new System.Windows.Forms.DateTimePicker();
            this.btnaylikrapor = new System.Windows.Forms.Button();
            this.btngunlukrapor = new System.Windows.Forms.Button();
            this.pnlortabolum = new System.Windows.Forms.Panel();
            this.pnlaltbolum = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cizgi = new System.Windows.Forms.Label();
            this.lblkar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgider = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblgelir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlustbolum.SuspendLayout();
            this.pnlortabolum.SuspendLayout();
            this.pnlaltbolum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlustbolum
            // 
            this.pnlustbolum.Controls.Add(this.label2);
            this.pnlustbolum.Controls.Add(this.label1);
            this.pnlustbolum.Controls.Add(this.btngenelrapor);
            this.pnlustbolum.Controls.Add(this.button5);
            this.pnlustbolum.Controls.Add(this.dtptakvimbitis);
            this.pnlustbolum.Controls.Add(this.button4);
            this.pnlustbolum.Controls.Add(this.btnlistele);
            this.pnlustbolum.Controls.Add(this.dtptakvimbaslangic);
            this.pnlustbolum.Controls.Add(this.btnaylikrapor);
            this.pnlustbolum.Controls.Add(this.btngunlukrapor);
            this.pnlustbolum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlustbolum.Location = new System.Drawing.Point(0, 0);
            this.pnlustbolum.Name = "pnlustbolum";
            this.pnlustbolum.Size = new System.Drawing.Size(1300, 66);
            this.pnlustbolum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // btngenelrapor
            // 
            this.btngenelrapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenelrapor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btngenelrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenelrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngenelrapor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btngenelrapor.Location = new System.Drawing.Point(892, 0);
            this.btngenelrapor.Name = "btngenelrapor";
            this.btngenelrapor.Size = new System.Drawing.Size(136, 66);
            this.btngenelrapor.TabIndex = 5;
            this.btngenelrapor.Text = "Genel";
            this.btngenelrapor.UseVisualStyleBackColor = true;
            this.btngenelrapor.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Location = new System.Drawing.Point(59, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "Gider Ekle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtptakvimbitis
            // 
            this.dtptakvimbitis.Location = new System.Drawing.Point(195, 21);
            this.dtptakvimbitis.Name = "dtptakvimbitis";
            this.dtptakvimbitis.Size = new System.Drawing.Size(200, 20);
            this.dtptakvimbitis.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Gelir Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlistele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistele.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlistele.Location = new System.Drawing.Point(195, 43);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(200, 23);
            this.btnlistele.TabIndex = 1;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtptakvimbaslangic
            // 
            this.dtptakvimbaslangic.Location = new System.Drawing.Point(195, 2);
            this.dtptakvimbaslangic.Name = "dtptakvimbaslangic";
            this.dtptakvimbaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtptakvimbaslangic.TabIndex = 0;
            this.dtptakvimbaslangic.ValueChanged += new System.EventHandler(this.dtptakvim_ValueChanged);
            // 
            // btnaylikrapor
            // 
            this.btnaylikrapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaylikrapor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnaylikrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaylikrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaylikrapor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnaylikrapor.Location = new System.Drawing.Point(1028, 0);
            this.btnaylikrapor.Name = "btnaylikrapor";
            this.btnaylikrapor.Size = new System.Drawing.Size(136, 66);
            this.btnaylikrapor.TabIndex = 2;
            this.btnaylikrapor.Text = "Aylık Rapor";
            this.btnaylikrapor.UseVisualStyleBackColor = true;
            this.btnaylikrapor.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngunlukrapor
            // 
            this.btngunlukrapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngunlukrapor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btngunlukrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngunlukrapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngunlukrapor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btngunlukrapor.Location = new System.Drawing.Point(1164, 0);
            this.btngunlukrapor.Name = "btngunlukrapor";
            this.btngunlukrapor.Size = new System.Drawing.Size(136, 66);
            this.btngunlukrapor.TabIndex = 0;
            this.btngunlukrapor.Text = "Günlük Rapor";
            this.btngunlukrapor.UseVisualStyleBackColor = true;
            this.btngunlukrapor.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlortabolum
            // 
            this.pnlortabolum.Controls.Add(this.pnlaltbolum);
            this.pnlortabolum.Controls.Add(this.dataGridView1);
            this.pnlortabolum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlortabolum.Location = new System.Drawing.Point(0, 66);
            this.pnlortabolum.Name = "pnlortabolum";
            this.pnlortabolum.Size = new System.Drawing.Size(1300, 549);
            this.pnlortabolum.TabIndex = 2;
            // 
            // pnlaltbolum
            // 
            this.pnlaltbolum.Controls.Add(this.label8);
            this.pnlaltbolum.Controls.Add(this.label7);
            this.pnlaltbolum.Controls.Add(this.label4);
            this.pnlaltbolum.Controls.Add(this.cizgi);
            this.pnlaltbolum.Controls.Add(this.lblkar);
            this.pnlaltbolum.Controls.Add(this.label6);
            this.pnlaltbolum.Controls.Add(this.lblgider);
            this.pnlaltbolum.Controls.Add(this.label5);
            this.pnlaltbolum.Controls.Add(this.lblgelir);
            this.pnlaltbolum.Controls.Add(this.label3);
            this.pnlaltbolum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlaltbolum.Location = new System.Drawing.Point(0, 277);
            this.pnlaltbolum.Name = "pnlaltbolum";
            this.pnlaltbolum.Size = new System.Drawing.Size(1300, 272);
            this.pnlaltbolum.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(0, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1300, 10);
            this.label8.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(0, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1300, 10);
            this.label7.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(0, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1300, 10);
            this.label4.TabIndex = 14;
            // 
            // cizgi
            // 
            this.cizgi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cizgi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cizgi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cizgi.Location = new System.Drawing.Point(412, 0);
            this.cizgi.Name = "cizgi";
            this.cizgi.Size = new System.Drawing.Size(11, 272);
            this.cizgi.TabIndex = 13;
            // 
            // lblkar
            // 
            this.lblkar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblkar.AutoSize = true;
            this.lblkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkar.Location = new System.Drawing.Point(525, 46);
            this.lblkar.Name = "lblkar";
            this.lblkar.Size = new System.Drawing.Size(40, 42);
            this.lblkar.TabIndex = 12;
            this.lblkar.Text = "0";
            this.toolTip1.SetToolTip(this.lblkar, "Net Kar");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(429, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kar:";
            this.toolTip1.SetToolTip(this.label6, "Net Kar");
            // 
            // lblgider
            // 
            this.lblgider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblgider.AutoSize = true;
            this.lblgider.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgider.Location = new System.Drawing.Point(153, 164);
            this.lblgider.Name = "lblgider";
            this.lblgider.Size = new System.Drawing.Size(40, 42);
            this.lblgider.TabIndex = 10;
            this.lblgider.Text = "0";
            this.toolTip1.SetToolTip(this.lblgider, "Gider");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gider:";
            this.toolTip1.SetToolTip(this.label5, "Gider");
            // 
            // lblgelir
            // 
            this.lblgelir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblgelir.AutoSize = true;
            this.lblgelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgelir.Location = new System.Drawing.Point(153, 46);
            this.lblgelir.Name = "lblgelir";
            this.lblgelir.Size = new System.Drawing.Size(40, 42);
            this.lblgelir.TabIndex = 8;
            this.lblgelir.Text = "0";
            this.toolTip1.SetToolTip(this.lblgelir, "Ciro");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gelir:";
            this.toolTip1.SetToolTip(this.label3, "Ciro");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1300, 549);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmraporlar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1300, 615);
            this.Controls.Add(this.pnlortabolum);
            this.Controls.Add(this.pnlustbolum);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmraporlar";
            this.Text = "frmraporlar";
            this.Load += new System.EventHandler(this.frmraporlar_Load);
            this.pnlustbolum.ResumeLayout(false);
            this.pnlustbolum.PerformLayout();
            this.pnlortabolum.ResumeLayout(false);
            this.pnlaltbolum.ResumeLayout(false);
            this.pnlaltbolum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlustbolum;
        private System.Windows.Forms.Panel pnlortabolum;
        private System.Windows.Forms.Button btngenelrapor;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnaylikrapor;
        private System.Windows.Forms.Button btngunlukrapor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlaltbolum;
        private System.Windows.Forms.DateTimePicker dtptakvimbaslangic;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DateTimePicker dtptakvimbitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblgelir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblgider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cizgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}