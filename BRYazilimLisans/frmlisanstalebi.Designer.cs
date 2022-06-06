
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmlisanstalebi
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
            this.btngonder = new System.Windows.Forms.Button();
            this.txtkullanicimaili = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngonder
            // 
            this.btngonder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngonder.BackColor = System.Drawing.Color.DimGray;
            this.btngonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngonder.ForeColor = System.Drawing.Color.White;
            this.btngonder.Location = new System.Drawing.Point(53, 32);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(344, 23);
            this.btngonder.TabIndex = 10;
            this.btngonder.Text = "Lisans Talebi Gönder";
            this.btngonder.UseVisualStyleBackColor = false;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // txtkullanicimaili
            // 
            this.txtkullanicimaili.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtkullanicimaili.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtkullanicimaili.Location = new System.Drawing.Point(53, 6);
            this.txtkullanicimaili.Name = "txtkullanicimaili";
            this.txtkullanicimaili.Size = new System.Drawing.Size(344, 20);
            this.txtkullanicimaili.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Eposta";
            // 
            // frmlisanstalebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(429, 61);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txtkullanicimaili);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlisanstalebi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlisanstalebi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtkullanicimaili;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btngonder;
    }
}