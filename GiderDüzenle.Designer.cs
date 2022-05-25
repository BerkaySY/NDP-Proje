
namespace NDP_Proje
{
    partial class GiderDüzenle
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
            this.giderTablosu = new System.Windows.Forms.DataGridView();
            this.giderIsimLbl = new System.Windows.Forms.Label();
            this.giderIsimEkleTxtBox = new System.Windows.Forms.TextBox();
            this.tutarEkleTxtBox = new System.Windows.Forms.TextBox();
            this.tutarLbl = new System.Windows.Forms.Label();
            this.giderEklemeGrup = new System.Windows.Forms.GroupBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giderTablosu)).BeginInit();
            this.giderEklemeGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // giderTablosu
            // 
            this.giderTablosu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.giderTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giderTablosu.Location = new System.Drawing.Point(238, 12);
            this.giderTablosu.Name = "giderTablosu";
            this.giderTablosu.RowTemplate.Height = 25;
            this.giderTablosu.Size = new System.Drawing.Size(550, 426);
            this.giderTablosu.TabIndex = 0;
            // 
            // giderIsimLbl
            // 
            this.giderIsimLbl.AutoSize = true;
            this.giderIsimLbl.Location = new System.Drawing.Point(6, 30);
            this.giderIsimLbl.Name = "giderIsimLbl";
            this.giderIsimLbl.Size = new System.Drawing.Size(66, 15);
            this.giderIsimLbl.TabIndex = 1;
            this.giderIsimLbl.Text = "Gider İsmi :";
            // 
            // giderIsimEkleTxtBox
            // 
            this.giderIsimEkleTxtBox.Location = new System.Drawing.Point(83, 27);
            this.giderIsimEkleTxtBox.Name = "giderIsimEkleTxtBox";
            this.giderIsimEkleTxtBox.Size = new System.Drawing.Size(131, 23);
            this.giderIsimEkleTxtBox.TabIndex = 2;
            // 
            // tutarEkleTxtBox
            // 
            this.tutarEkleTxtBox.Location = new System.Drawing.Point(83, 71);
            this.tutarEkleTxtBox.Name = "tutarEkleTxtBox";
            this.tutarEkleTxtBox.Size = new System.Drawing.Size(131, 23);
            this.tutarEkleTxtBox.TabIndex = 4;
            // 
            // tutarLbl
            // 
            this.tutarLbl.AutoSize = true;
            this.tutarLbl.Location = new System.Drawing.Point(32, 74);
            this.tutarLbl.Name = "tutarLbl";
            this.tutarLbl.Size = new System.Drawing.Size(40, 15);
            this.tutarLbl.TabIndex = 3;
            this.tutarLbl.Text = "Tutar :";
            // 
            // giderEklemeGrup
            // 
            this.giderEklemeGrup.Controls.Add(this.ekleBtn);
            this.giderEklemeGrup.Controls.Add(this.tutarEkleTxtBox);
            this.giderEklemeGrup.Controls.Add(this.giderIsimLbl);
            this.giderEklemeGrup.Controls.Add(this.tutarLbl);
            this.giderEklemeGrup.Controls.Add(this.giderIsimEkleTxtBox);
            this.giderEklemeGrup.Location = new System.Drawing.Point(12, 142);
            this.giderEklemeGrup.Name = "giderEklemeGrup";
            this.giderEklemeGrup.Size = new System.Drawing.Size(220, 146);
            this.giderEklemeGrup.TabIndex = 5;
            this.giderEklemeGrup.TabStop = false;
            this.giderEklemeGrup.Text = "Gider Ekleme";
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.Red;
            this.ekleBtn.Location = new System.Drawing.Point(32, 114);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(153, 26);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // GiderDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giderEklemeGrup);
            this.Controls.Add(this.giderTablosu);
            this.Name = "GiderDüzenle";
            this.Text = "GiderDüzenle";
            this.Load += new System.EventHandler(this.GiderDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giderTablosu)).EndInit();
            this.giderEklemeGrup.ResumeLayout(false);
            this.giderEklemeGrup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView giderTablosu;
        private System.Windows.Forms.Label giderIsimLbl;
        private System.Windows.Forms.TextBox giderIsimEkleTxtBox;
        private System.Windows.Forms.TextBox tutarEkleTxtBox;
        private System.Windows.Forms.Label tutarLbl;
        private System.Windows.Forms.GroupBox giderEklemeGrup;
        private System.Windows.Forms.Button ekleBtn;
    }
}