
namespace NDP_Proje
{
    partial class DepoStok
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
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.araLbl = new System.Windows.Forms.Label();
            this.depoListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.depoListe)).BeginInit();
            this.SuspendLayout();
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(13, 143);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(126, 23);
            this.araTextBox.TabIndex = 5;
            this.araTextBox.TextChanged += new System.EventHandler(this.araTextBox_TextChanged);
            // 
            // araLbl
            // 
            this.araLbl.AutoSize = true;
            this.araLbl.Location = new System.Drawing.Point(12, 125);
            this.araLbl.Name = "araLbl";
            this.araLbl.Size = new System.Drawing.Size(127, 15);
            this.araLbl.TabIndex = 4;
            this.araLbl.Text = "Barkod No\'ya Göre Ara";
            // 
            // depoListe
            // 
            this.depoListe.BackgroundColor = System.Drawing.SystemColors.Control;
            this.depoListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depoListe.Location = new System.Drawing.Point(154, 31);
            this.depoListe.Name = "depoListe";
            this.depoListe.RowTemplate.Height = 25;
            this.depoListe.Size = new System.Drawing.Size(634, 388);
            this.depoListe.TabIndex = 3;
            // 
            // DepoStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.araLbl);
            this.Controls.Add(this.depoListe);
            this.Name = "DepoStok";
            this.Text = "DepoStok";
            this.Load += new System.EventHandler(this.DepoStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depoListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.Label araLbl;
        private System.Windows.Forms.DataGridView depoListe;
    }
}