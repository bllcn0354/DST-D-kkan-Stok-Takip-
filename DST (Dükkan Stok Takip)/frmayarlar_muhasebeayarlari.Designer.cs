
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmayarlar_muhasebeayarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmayarlar_muhasebeayarlari));
            this.cmbgun = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbgun
            // 
            this.cmbgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbgun.FormattingEnabled = true;
            this.cmbgun.Location = new System.Drawing.Point(80, 12);
            this.cmbgun.Name = "cmbgun";
            this.cmbgun.Size = new System.Drawing.Size(138, 26);
            this.cmbgun.TabIndex = 0;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(224, 8);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(99, 33);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maaş Günü";
            // 
            // frmayarlar_muhasebeayarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 62);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cmbgun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(344, 101);
            this.MinimumSize = new System.Drawing.Size(344, 101);
            this.Name = "frmayarlar_muhasebeayarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe Ayarları";
            this.Load += new System.EventHandler(this.frmmuhasebeayarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbgun;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
    }
}