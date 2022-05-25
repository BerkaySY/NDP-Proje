
namespace NDP_Proje
{
    partial class ÜrünListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.araLbl = new System.Windows.Forms.Label();
            this.silBtn = new System.Windows.Forms.Button();
            this.depoTextBox = new System.Windows.Forms.TextBox();
            this.depoLbl = new System.Windows.Forms.Label();
            this.rafTextBox = new System.Windows.Forms.TextBox();
            this.alisTextBox = new System.Windows.Forms.TextBox();
            this.satisTextBox = new System.Windows.Forms.TextBox();
            this.ürünAdTextBox = new System.Windows.Forms.TextBox();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.rafLbl = new System.Windows.Forms.Label();
            this.alisLbl = new System.Windows.Forms.Label();
            this.barkodLbl = new System.Windows.Forms.Label();
            this.satisLbl = new System.Windows.Forms.Label();
            this.ürünLbl = new System.Windows.Forms.Label();
            this.güncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // araTextBox
            // 
            this.araTextBox.Location = new System.Drawing.Point(530, 32);
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(178, 23);
            this.araTextBox.TabIndex = 2;
            this.araTextBox.TextChanged += new System.EventHandler(this.araTextBox_TextChanged);
            // 
            // araLbl
            // 
            this.araLbl.AutoSize = true;
            this.araLbl.Location = new System.Drawing.Point(381, 35);
            this.araLbl.Name = "araLbl";
            this.araLbl.Size = new System.Drawing.Size(127, 15);
            this.araLbl.TabIndex = 3;
            this.araLbl.Text = "Barkod No\'ya Göre Ara";
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.silBtn.Location = new System.Drawing.Point(212, 35);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(122, 23);
            this.silBtn.TabIndex = 4;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // depoTextBox
            // 
            this.depoTextBox.Location = new System.Drawing.Point(93, 192);
            this.depoTextBox.Name = "depoTextBox";
            this.depoTextBox.Size = new System.Drawing.Size(105, 23);
            this.depoTextBox.TabIndex = 38;
            // 
            // depoLbl
            // 
            this.depoLbl.AutoSize = true;
            this.depoLbl.Location = new System.Drawing.Point(6, 195);
            this.depoLbl.Name = "depoLbl";
            this.depoLbl.Size = new System.Drawing.Size(75, 15);
            this.depoLbl.TabIndex = 37;
            this.depoLbl.Text = "Depo Stoğu :";
            // 
            // rafTextBox
            // 
            this.rafTextBox.Location = new System.Drawing.Point(93, 153);
            this.rafTextBox.Name = "rafTextBox";
            this.rafTextBox.Size = new System.Drawing.Size(105, 23);
            this.rafTextBox.TabIndex = 36;
            // 
            // alisTextBox
            // 
            this.alisTextBox.Location = new System.Drawing.Point(92, 308);
            this.alisTextBox.Name = "alisTextBox";
            this.alisTextBox.Size = new System.Drawing.Size(104, 23);
            this.alisTextBox.TabIndex = 35;
            // 
            // satisTextBox
            // 
            this.satisTextBox.Location = new System.Drawing.Point(92, 272);
            this.satisTextBox.Name = "satisTextBox";
            this.satisTextBox.Size = new System.Drawing.Size(104, 23);
            this.satisTextBox.TabIndex = 34;
            // 
            // ürünAdTextBox
            // 
            this.ürünAdTextBox.Location = new System.Drawing.Point(93, 233);
            this.ürünAdTextBox.Name = "ürünAdTextBox";
            this.ürünAdTextBox.Size = new System.Drawing.Size(103, 23);
            this.ürünAdTextBox.TabIndex = 33;
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Location = new System.Drawing.Point(93, 119);
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.ReadOnly = true;
            this.barkodTextBox.Size = new System.Drawing.Size(105, 23);
            this.barkodTextBox.TabIndex = 32;
            // 
            // rafLbl
            // 
            this.rafLbl.AutoSize = true;
            this.rafLbl.Location = new System.Drawing.Point(17, 156);
            this.rafLbl.Name = "rafLbl";
            this.rafLbl.Size = new System.Drawing.Size(64, 15);
            this.rafLbl.TabIndex = 28;
            this.rafLbl.Text = "Raf Stoğu :";
            // 
            // alisLbl
            // 
            this.alisLbl.AutoSize = true;
            this.alisLbl.Location = new System.Drawing.Point(12, 311);
            this.alisLbl.Name = "alisLbl";
            this.alisLbl.Size = new System.Drawing.Size(63, 15);
            this.alisLbl.TabIndex = 31;
            this.alisLbl.Text = "Alış Fiyatı :";
            // 
            // barkodLbl
            // 
            this.barkodLbl.AutoSize = true;
            this.barkodLbl.Location = new System.Drawing.Point(12, 122);
            this.barkodLbl.Name = "barkodLbl";
            this.barkodLbl.Size = new System.Drawing.Size(69, 15);
            this.barkodLbl.TabIndex = 27;
            this.barkodLbl.Text = "Barkod No :";
            // 
            // satisLbl
            // 
            this.satisLbl.AutoSize = true;
            this.satisLbl.Location = new System.Drawing.Point(10, 275);
            this.satisLbl.Name = "satisLbl";
            this.satisLbl.Size = new System.Drawing.Size(71, 15);
            this.satisLbl.TabIndex = 30;
            this.satisLbl.Text = "Satış Fiyatı : ";
            // 
            // ürünLbl
            // 
            this.ürünLbl.AutoSize = true;
            this.ürünLbl.Location = new System.Drawing.Point(21, 236);
            this.ürünLbl.Name = "ürünLbl";
            this.ürünLbl.Size = new System.Drawing.Size(60, 15);
            this.ürünLbl.TabIndex = 29;
            this.ürünLbl.Text = "Ürün Adı :";
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.Lime;
            this.güncelleBtn.Location = new System.Drawing.Point(43, 349);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(155, 53);
            this.güncelleBtn.TabIndex = 39;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // ÜrünListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.depoTextBox);
            this.Controls.Add(this.depoLbl);
            this.Controls.Add(this.rafTextBox);
            this.Controls.Add(this.alisTextBox);
            this.Controls.Add(this.satisTextBox);
            this.Controls.Add(this.ürünAdTextBox);
            this.Controls.Add(this.barkodTextBox);
            this.Controls.Add(this.rafLbl);
            this.Controls.Add(this.alisLbl);
            this.Controls.Add(this.barkodLbl);
            this.Controls.Add(this.satisLbl);
            this.Controls.Add(this.ürünLbl);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.araLbl);
            this.Controls.Add(this.araTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜrünListe";
            this.Text = "ÜrünListe";
            this.Load += new System.EventHandler(this.ÜrünListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.Label araLbl;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.TextBox depoTextBox;
        private System.Windows.Forms.Label depoLbl;
        private System.Windows.Forms.TextBox rafTextBox;
        private System.Windows.Forms.TextBox alisTextBox;
        private System.Windows.Forms.TextBox satisTextBox;
        private System.Windows.Forms.TextBox ürünAdTextBox;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.Label rafLbl;
        private System.Windows.Forms.Label alisLbl;
        private System.Windows.Forms.Label barkodLbl;
        private System.Windows.Forms.Label satisLbl;
        private System.Windows.Forms.Label ürünLbl;
        private System.Windows.Forms.Button güncelleBtn;
    }
}