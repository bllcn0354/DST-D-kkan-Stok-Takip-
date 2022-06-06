
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmfiyatbelirle
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
            this.txtfyt = new System.Windows.Forms.TextBox();
            this.btnfiyatbelirle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaliyet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtfyt
            // 
            this.txtfyt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfyt.Location = new System.Drawing.Point(96, 62);
            this.txtfyt.MaxLength = 15;
            this.txtfyt.Name = "txtfyt";
            this.txtfyt.Size = new System.Drawing.Size(201, 26);
            this.txtfyt.TabIndex = 0;
            this.txtfyt.Text = "0";
            this.txtfyt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfyt_KeyPress);
            // 
            // btnfiyatbelirle
            // 
            this.btnfiyatbelirle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfiyatbelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfiyatbelirle.Location = new System.Drawing.Point(96, 94);
            this.btnfiyatbelirle.Name = "btnfiyatbelirle";
            this.btnfiyatbelirle.Size = new System.Drawing.Size(201, 30);
            this.btnfiyatbelirle.TabIndex = 1;
            this.btnfiyatbelirle.Text = "Fiyat Belirle";
            this.btnfiyatbelirle.UseVisualStyleBackColor = true;
            this.btnfiyatbelirle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maliyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ucret";
            // 
            // txtmaliyet
            // 
            this.txtmaliyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmaliyet.Location = new System.Drawing.Point(96, 30);
            this.txtmaliyet.MaxLength = 15;
            this.txtmaliyet.Name = "txtmaliyet";
            this.txtmaliyet.Size = new System.Drawing.Size(201, 26);
            this.txtmaliyet.TabIndex = 4;
            this.txtmaliyet.Text = "0";
            this.txtmaliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaliyet_KeyPress);
            // 
            // frmfiyatbelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 166);
            this.Controls.Add(this.txtmaliyet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfiyatbelirle);
            this.Controls.Add(this.txtfyt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmfiyatbelirle";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiyat Belirle";
            this.Load += new System.EventHandler(this.frmfiyatbelirle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfyt;
        private System.Windows.Forms.Button btnfiyatbelirle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaliyet;
    }
}