
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmacilislisansgirmeekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmacilislisansgirmeekrani));
            this.txtmail = new System.Windows.Forms.TextBox();
            this.btnlisanskontrol = new System.Windows.Forms.Button();
            this.lbllisansal = new System.Windows.Forms.Label();
            this.txtlisanskey = new System.Windows.Forms.TextBox();
            this.lblmail_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(135, 18);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(362, 20);
            this.txtmail.TabIndex = 0;
            this.txtmail.Visible = false;
            // 
            // btnlisanskontrol
            // 
            this.btnlisanskontrol.BackColor = System.Drawing.Color.Transparent;
            this.btnlisanskontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlisanskontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlisanskontrol.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnlisanskontrol.Location = new System.Drawing.Point(233, 67);
            this.btnlisanskontrol.Name = "btnlisanskontrol";
            this.btnlisanskontrol.Size = new System.Drawing.Size(152, 37);
            this.btnlisanskontrol.TabIndex = 1;
            this.btnlisanskontrol.Text = "Lisansı Gir";
            this.btnlisanskontrol.UseVisualStyleBackColor = false;
            this.btnlisanskontrol.Click += new System.EventHandler(this.btnlisanskontrol_Click);
            // 
            // lbllisansal
            // 
            this.lbllisansal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllisansal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbllisansal.Location = new System.Drawing.Point(233, 41);
            this.lbllisansal.Name = "lbllisansal";
            this.lbllisansal.Size = new System.Drawing.Size(152, 23);
            this.lbllisansal.TabIndex = 2;
            this.lbllisansal.Text = "Lisans Satın Al";
            this.lbllisansal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbllisansal.Click += new System.EventHandler(this.lbllisansal_Click);
            // 
            // txtlisanskey
            // 
            this.txtlisanskey.Location = new System.Drawing.Point(135, 18);
            this.txtlisanskey.Name = "txtlisanskey";
            this.txtlisanskey.Size = new System.Drawing.Size(362, 20);
            this.txtlisanskey.TabIndex = 3;
            // 
            // lblmail_key
            // 
            this.lblmail_key.BackColor = System.Drawing.Color.Transparent;
            this.lblmail_key.Location = new System.Drawing.Point(73, 21);
            this.lblmail_key.Name = "lblmail_key";
            this.lblmail_key.Size = new System.Drawing.Size(56, 23);
            this.lblmail_key.TabIndex = 4;
            this.lblmail_key.Text = "Key";
            this.lblmail_key.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmacilislisansgirmeekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(617, 117);
            this.Controls.Add(this.lblmail_key);
            this.Controls.Add(this.lbllisansal);
            this.Controls.Add(this.btnlisanskontrol);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtlisanskey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(633, 156);
            this.MinimumSize = new System.Drawing.Size(633, 156);
            this.Name = "frmacilislisansgirmeekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DST";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmacilislisansgirmeekrani_FormClosed);
            this.Load += new System.EventHandler(this.frmacilislisansgirmeekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btnlisanskontrol;
        private System.Windows.Forms.Label lbllisansal;
        private System.Windows.Forms.TextBox txtlisanskey;
        private System.Windows.Forms.Label lblmail_key;
    }
}