
namespace NDP_Proje
{
    partial class GelirGiderRaporu
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
            this.gelirTablosu = new System.Windows.Forms.DataGridView();
            this.giderSiparişTablosu = new System.Windows.Forms.DataGridView();
            this.gelirLbl = new System.Windows.Forms.Label();
            this.giderLbl = new System.Windows.Forms.Label();
            this.giderRutinTablo = new System.Windows.Forms.DataGridView();
            this.ciroLbl = new System.Windows.Forms.Label();
            this.ciroTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gelirTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderSiparişTablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderRutinTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // gelirTablosu
            // 
            this.gelirTablosu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gelirTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gelirTablosu.Location = new System.Drawing.Point(12, 39);
            this.gelirTablosu.Name = "gelirTablosu";
            this.gelirTablosu.RowTemplate.Height = 25;
            this.gelirTablosu.Size = new System.Drawing.Size(542, 547);
            this.gelirTablosu.TabIndex = 0;
            // 
            // giderSiparişTablosu
            // 
            this.giderSiparişTablosu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.giderSiparişTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giderSiparişTablosu.Location = new System.Drawing.Point(560, 39);
            this.giderSiparişTablosu.Name = "giderSiparişTablosu";
            this.giderSiparişTablosu.RowTemplate.Height = 25;
            this.giderSiparişTablosu.Size = new System.Drawing.Size(542, 391);
            this.giderSiparişTablosu.TabIndex = 1;
            // 
            // gelirLbl
            // 
            this.gelirLbl.AutoSize = true;
            this.gelirLbl.Location = new System.Drawing.Point(234, 13);
            this.gelirLbl.Name = "gelirLbl";
            this.gelirLbl.Size = new System.Drawing.Size(31, 15);
            this.gelirLbl.TabIndex = 2;
            this.gelirLbl.Text = "Gelir";
            // 
            // giderLbl
            // 
            this.giderLbl.AutoSize = true;
            this.giderLbl.Location = new System.Drawing.Point(828, 13);
            this.giderLbl.Name = "giderLbl";
            this.giderLbl.Size = new System.Drawing.Size(35, 15);
            this.giderLbl.TabIndex = 3;
            this.giderLbl.Text = "Gider";
            // 
            // giderRutinTablo
            // 
            this.giderRutinTablo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.giderRutinTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giderRutinTablo.Location = new System.Drawing.Point(560, 436);
            this.giderRutinTablo.Name = "giderRutinTablo";
            this.giderRutinTablo.RowTemplate.Height = 25;
            this.giderRutinTablo.Size = new System.Drawing.Size(542, 150);
            this.giderRutinTablo.TabIndex = 4;
            // 
            // ciroLbl
            // 
            this.ciroLbl.AutoSize = true;
            this.ciroLbl.Location = new System.Drawing.Point(478, 611);
            this.ciroLbl.Name = "ciroLbl";
            this.ciroLbl.Size = new System.Drawing.Size(76, 15);
            this.ciroLbl.TabIndex = 5;
            this.ciroLbl.Text = "Günlük Ciro :";
            // 
            // ciroTxtBox
            // 
            this.ciroTxtBox.Location = new System.Drawing.Point(560, 608);
            this.ciroTxtBox.Name = "ciroTxtBox";
            this.ciroTxtBox.ReadOnly = true;
            this.ciroTxtBox.Size = new System.Drawing.Size(100, 23);
            this.ciroTxtBox.TabIndex = 6;
            // 
            // GelirGiderRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1108, 648);
            this.Controls.Add(this.ciroTxtBox);
            this.Controls.Add(this.ciroLbl);
            this.Controls.Add(this.giderRutinTablo);
            this.Controls.Add(this.giderLbl);
            this.Controls.Add(this.gelirLbl);
            this.Controls.Add(this.giderSiparişTablosu);
            this.Controls.Add(this.gelirTablosu);
            this.Name = "GelirGiderRaporu";
            this.Text = "GelirGiderRaporu";
            this.Load += new System.EventHandler(this.GelirGiderRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gelirTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderSiparişTablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderRutinTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gelirTablosu;
        private System.Windows.Forms.DataGridView giderSiparişTablosu;
        private System.Windows.Forms.Label gelirLbl;
        private System.Windows.Forms.Label giderLbl;
        private System.Windows.Forms.DataGridView giderRutinTablo;
        private System.Windows.Forms.Label ciroLbl;
        private System.Windows.Forms.TextBox ciroTxtBox;
    }
}