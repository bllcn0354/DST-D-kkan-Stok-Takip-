
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmayarlar_Yedekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmayarlar_Yedekleme));
            this.txtmail = new System.Windows.Forms.TextBox();
            this.cmbhedefzaman = new System.Windows.Forms.ComboBox();
            this.radiogunluk = new System.Windows.Forms.RadioButton();
            this.radiohaftalik = new System.Windows.Forms.RadioButton();
            this.radioaylik = new System.Windows.Forms.RadioButton();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.Gainsboro;
            this.txtmail.Enabled = false;
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtmail.Location = new System.Drawing.Point(38, 12);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(338, 26);
            this.txtmail.TabIndex = 0;
            // 
            // cmbhedefzaman
            // 
            this.cmbhedefzaman.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbhedefzaman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbhedefzaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhedefzaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbhedefzaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbhedefzaman.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbhedefzaman.FormattingEnabled = true;
            this.cmbhedefzaman.Location = new System.Drawing.Point(103, 42);
            this.cmbhedefzaman.Name = "cmbhedefzaman";
            this.cmbhedefzaman.Size = new System.Drawing.Size(273, 28);
            this.cmbhedefzaman.TabIndex = 1;
            // 
            // radiogunluk
            // 
            this.radiogunluk.AutoSize = true;
            this.radiogunluk.BackColor = System.Drawing.Color.Transparent;
            this.radiogunluk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiogunluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiogunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiogunluk.Location = new System.Drawing.Point(12, 47);
            this.radiogunluk.Name = "radiogunluk";
            this.radiogunluk.Size = new System.Drawing.Size(77, 24);
            this.radiogunluk.TabIndex = 2;
            this.radiogunluk.Text = "Günlük";
            this.radiogunluk.UseVisualStyleBackColor = false;
            this.radiogunluk.CheckedChanged += new System.EventHandler(this.radiogunluk_CheckedChanged);
            // 
            // radiohaftalik
            // 
            this.radiohaftalik.AutoSize = true;
            this.radiohaftalik.BackColor = System.Drawing.Color.Transparent;
            this.radiohaftalik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiohaftalik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiohaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiohaftalik.Location = new System.Drawing.Point(12, 70);
            this.radiohaftalik.Name = "radiohaftalik";
            this.radiohaftalik.Size = new System.Drawing.Size(80, 24);
            this.radiohaftalik.TabIndex = 3;
            this.radiohaftalik.Text = "Haftalık";
            this.radiohaftalik.UseVisualStyleBackColor = false;
            this.radiohaftalik.CheckedChanged += new System.EventHandler(this.radiohaftalik_CheckedChanged);
            // 
            // radioaylik
            // 
            this.radioaylik.AutoSize = true;
            this.radioaylik.BackColor = System.Drawing.Color.Transparent;
            this.radioaylik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioaylik.Enabled = false;
            this.radioaylik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioaylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioaylik.Location = new System.Drawing.Point(12, 93);
            this.radioaylik.Name = "radioaylik";
            this.radioaylik.Size = new System.Drawing.Size(58, 24);
            this.radioaylik.TabIndex = 4;
            this.radioaylik.Text = "Aylık";
            this.radioaylik.UseVisualStyleBackColor = false;
            this.radioaylik.CheckedChanged += new System.EventHandler(this.radioaylik_CheckedChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(105, 76);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(271, 39);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // frmayarlar_Yedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 119);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.radioaylik);
            this.Controls.Add(this.radiohaftalik);
            this.Controls.Add(this.radiogunluk);
            this.Controls.Add(this.cmbhedefzaman);
            this.Controls.Add(this.txtmail);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(427, 158);
            this.MinimumSize = new System.Drawing.Size(427, 158);
            this.Name = "frmayarlar_Yedekleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yedekleme";
            this.Load += new System.EventHandler(this.frmayarlar_Yedekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.ComboBox cmbhedefzaman;
        private System.Windows.Forms.RadioButton radiogunluk;
        private System.Windows.Forms.RadioButton radiohaftalik;
        private System.Windows.Forms.RadioButton radioaylik;
        private System.Windows.Forms.Button btnkaydet;
    }
}