
namespace DST__Dükkan_Stok_Takip_
{
    partial class frmfatura
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
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.Fatura = new System.Drawing.Printing.PrintDocument();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Document = this.Fatura;
            this.printPreviewControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.printPreviewControl1.Location = new System.Drawing.Point(9, 10);
            this.printPreviewControl1.Margin = new System.Windows.Forms.Padding(2);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(322, 410);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 0.34217279726261762D;
            this.printPreviewControl1.Click += new System.EventHandler(this.printPreviewControl1_Click);
            // 
            // Fatura
            // 
            this.Fatura.OriginAtMargins = true;
            this.Fatura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnyazdir
            // 
            this.btnyazdir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnyazdir.Location = new System.Drawing.Point(252, 425);
            this.btnyazdir.Margin = new System.Windows.Forms.Padding(2);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(79, 40);
            this.btnyazdir.TabIndex = 1;
            this.btnyazdir.Text = "Yazdır";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmfatura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 474);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.printPreviewControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmfatura";
            this.Text = "frmfatura";
            this.Load += new System.EventHandler(this.frmfatura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnyazdir;
        public System.Drawing.Printing.PrintDocument Fatura;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}