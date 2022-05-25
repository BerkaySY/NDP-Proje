
namespace NDP_Proje
{
    partial class RafStok
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
            this.rafListe = new System.Windows.Forms.DataGridView();
            this.araLbl = new System.Windows.Forms.Label();
            this.araTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rafListe)).BeginInit();
            this.SuspendLayout();
            // 
            // rafListe
            // 
            this.rafListe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rafListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rafListe.Location = new System.Drawing.Point(154, 37);
            this.rafListe.Name = "rafListe";
            this.rafListe.RowTemplate.Height = 25;
            this.rafListe.Size = new System.Drawing.Size(634, 388);
            this.rafListe.TabIndex = 0;
            // 
            // araLbl
            // 
            this.araLbl.AutoSize = true;
            this.araLbl.Location = new System.Drawing.Point(12, 131);
            this.araLbl.Name = "araLbl";
            this.araLbl.Size = new System.Drawing.Size(127, 15);
            this.araLbl.TabIndex = 1;
            this.araLbl.Text = "Barkod No\'ya Göre Ara";
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(13, 149);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(126, 23);
            this.araTextBox.TabIndex = 2;
            this.araTextBox.TextChanged += new System.EventHandler(this.araTextBox_TextChanged);
            // 
            // RafStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.araLbl);
            this.Controls.Add(this.rafListe);
            this.Name = "RafStok";
            this.Text = "RafStok";
            this.Load += new System.EventHandler(this.RafStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rafListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rafListe;
        private System.Windows.Forms.Label araLbl;
        private System.Windows.Forms.TextBox araTextBox;
    }
}