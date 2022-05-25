
namespace NDP_Proje
{
    partial class SiparişListesi
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
            this.siparisListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisListe
            // 
            this.siparisListe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.siparisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisListe.Location = new System.Drawing.Point(12, 12);
            this.siparisListe.Name = "siparisListe";
            this.siparisListe.RowTemplate.Height = 25;
            this.siparisListe.Size = new System.Drawing.Size(1026, 533);
            this.siparisListe.TabIndex = 0;
            // 
            // SiparişListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1050, 557);
            this.Controls.Add(this.siparisListe);
            this.Name = "SiparişListesi";
            this.Text = "SiparişListesi";
            this.Load += new System.EventHandler(this.SiparişListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siparisListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView siparisListe;
    }
}