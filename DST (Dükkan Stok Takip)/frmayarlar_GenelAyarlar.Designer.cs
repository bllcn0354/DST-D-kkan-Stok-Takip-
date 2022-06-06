
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmayarlar_GenelAyarlar
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
            this.chkses = new System.Windows.Forms.CheckBox();
            this.chkversiyonmail = new System.Windows.Forms.CheckBox();
            this.cmbmod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkses
            // 
            this.chkses.AutoSize = true;
            this.chkses.Checked = true;
            this.chkses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkses.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkses.Location = new System.Drawing.Point(34, 24);
            this.chkses.Name = "chkses";
            this.chkses.Size = new System.Drawing.Size(84, 22);
            this.chkses.TabIndex = 0;
            this.chkses.Text = "Sesi Aç";
            this.chkses.UseVisualStyleBackColor = true;
            this.chkses.CheckedChanged += new System.EventHandler(this.chkses_CheckedChanged);
            // 
            // chkversiyonmail
            // 
            this.chkversiyonmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkversiyonmail.Enabled = false;
            this.chkversiyonmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkversiyonmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.chkversiyonmail.Location = new System.Drawing.Point(34, 53);
            this.chkversiyonmail.Name = "chkversiyonmail";
            this.chkversiyonmail.Size = new System.Drawing.Size(146, 68);
            this.chkversiyonmail.TabIndex = 1;
            this.chkversiyonmail.Text = "Yeni versiyon çıktığında haber ver";
            this.chkversiyonmail.UseVisualStyleBackColor = true;
            this.chkversiyonmail.CheckedChanged += new System.EventHandler(this.shkversiyonmail_CheckedChanged);
            // 
            // cmbmod
            // 
            this.cmbmod.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbmod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmod.Enabled = false;
            this.cmbmod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbmod.ForeColor = System.Drawing.Color.DarkCyan;
            this.cmbmod.FormattingEnabled = true;
            this.cmbmod.Items.AddRange(new object[] {
            "Standart"});
            this.cmbmod.Location = new System.Drawing.Point(234, 22);
            this.cmbmod.Name = "cmbmod";
            this.cmbmod.Size = new System.Drawing.Size(156, 26);
            this.cmbmod.TabIndex = 5;
            this.cmbmod.SelectedIndexChanged += new System.EventHandler(this.cmbmod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "GENEL AYARLAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkses);
            this.groupBox1.Controls.Add(this.chkversiyonmail);
            this.groupBox1.Controls.Add(this.cmbmod);
            this.groupBox1.Location = new System.Drawing.Point(151, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mod";
            // 
            // btncik
            // 
            this.btncik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncik.BackColor = System.Drawing.Color.Maroon;
            this.btncik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncik.ForeColor = System.Drawing.Color.Azure;
            this.btncik.Location = new System.Drawing.Point(706, -1);
            this.btncik.Name = "btncik";
            this.btncik.Size = new System.Drawing.Size(25, 25);
            this.btncik.TabIndex = 10;
            this.btncik.Text = "x";
            this.btncik.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btncik.UseVisualStyleBackColor = false;
            this.btncik.Visible = false;
            // 
            // frmayarlar_GenelAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(729, 552);
            this.Controls.Add(this.btncik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmayarlar_GenelAyarlar";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmayarlar_GenelAyarlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmayarlar_GenelAyarlar_FormClosed);
            this.Load += new System.EventHandler(this.frmayarlar_GenelAyarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncik;
        public System.Windows.Forms.CheckBox chkses;
        public System.Windows.Forms.CheckBox chkversiyonmail;
        public System.Windows.Forms.ComboBox cmbmod;
        public System.Windows.Forms.Label label2;
    }
}