
namespace NDP_Proje
{
    partial class SatışRaporu
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
            this.satisRaporu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.satisRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // satisRaporu
            // 
            this.satisRaporu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.satisRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisRaporu.Location = new System.Drawing.Point(12, 12);
            this.satisRaporu.Name = "satisRaporu";
            this.satisRaporu.RowTemplate.Height = 25;
            this.satisRaporu.Size = new System.Drawing.Size(954, 498);
            this.satisRaporu.TabIndex = 0;
            // 
            // SatışRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(978, 522);
            this.Controls.Add(this.satisRaporu);
            this.Name = "SatışRaporu";
            this.Text = "SatışRaporu";
            this.Load += new System.EventHandler(this.SatışRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView satisRaporu;
    }
}