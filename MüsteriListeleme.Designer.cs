
namespace NDP_Proje
{
    partial class MüsteriListeleme
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
            this.tcLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.soyadLbl = new System.Windows.Forms.Label();
            this.telLbl = new System.Windows.Forms.Label();
            this.adresLbl = new System.Windows.Forms.Label();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tcAraTextBox = new System.Windows.Forms.TextBox();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tcLbl
            // 
            this.tcLbl.AutoSize = true;
            this.tcLbl.ForeColor = System.Drawing.Color.White;
            this.tcLbl.Location = new System.Drawing.Point(27, 104);
            this.tcLbl.Name = "tcLbl";
            this.tcLbl.Size = new System.Drawing.Size(26, 15);
            this.tcLbl.TabIndex = 1;
            this.tcLbl.Text = "TC :";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.ForeColor = System.Drawing.Color.White;
            this.adLbl.Location = new System.Drawing.Point(27, 146);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(28, 15);
            this.adLbl.TabIndex = 2;
            this.adLbl.Text = "Ad :";
            // 
            // soyadLbl
            // 
            this.soyadLbl.AutoSize = true;
            this.soyadLbl.ForeColor = System.Drawing.Color.White;
            this.soyadLbl.Location = new System.Drawing.Point(27, 184);
            this.soyadLbl.Name = "soyadLbl";
            this.soyadLbl.Size = new System.Drawing.Size(45, 15);
            this.soyadLbl.TabIndex = 3;
            this.soyadLbl.Text = "Soyad :";
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.ForeColor = System.Drawing.Color.White;
            this.telLbl.Location = new System.Drawing.Point(27, 224);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(54, 15);
            this.telLbl.TabIndex = 4;
            this.telLbl.Text = "Telefon : ";
            // 
            // adresLbl
            // 
            this.adresLbl.AutoSize = true;
            this.adresLbl.ForeColor = System.Drawing.Color.White;
            this.adresLbl.Location = new System.Drawing.Point(27, 267);
            this.adresLbl.Name = "adresLbl";
            this.adresLbl.Size = new System.Drawing.Size(43, 15);
            this.adresLbl.TabIndex = 5;
            this.adresLbl.Text = "Adres :";
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(82, 101);
            this.tcTextBox.Name = "tcTextBox";
            this.tcTextBox.ReadOnly = true;
            this.tcTextBox.Size = new System.Drawing.Size(100, 23);
            this.tcTextBox.TabIndex = 6;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(82, 143);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 23);
            this.adTextBox.TabIndex = 7;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(82, 181);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 23);
            this.soyadTextBox.TabIndex = 8;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(82, 264);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(100, 50);
            this.adresTextBox.TabIndex = 10;
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(82, 221);
            this.telTextBox.Mask = "(999) 000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 23);
            this.telTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Müşteri TC Ara : ";
            // 
            // tcAraTextBox
            // 
            this.tcAraTextBox.Location = new System.Drawing.Point(483, 33);
            this.tcAraTextBox.Name = "tcAraTextBox";
            this.tcAraTextBox.Size = new System.Drawing.Size(121, 23);
            this.tcAraTextBox.TabIndex = 14;
            this.tcAraTextBox.TextChanged += new System.EventHandler(this.tcAraTextBox_TextChanged);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.Lime;
            this.güncelleBtn.Location = new System.Drawing.Point(27, 342);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(155, 53);
            this.güncelleBtn.TabIndex = 16;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.silBtn.Location = new System.Drawing.Point(204, 33);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(107, 23);
            this.silBtn.TabIndex = 17;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // MüsteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.tcAraTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.adresLbl);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.soyadLbl);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.tcLbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MüsteriListeleme";
            this.Text = "MüsteriListeleme";
            this.Load += new System.EventHandler(this.MüsteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tcLbl;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Label soyadLbl;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label adresLbl;
        private System.Windows.Forms.TextBox tcTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcAraTextBox;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Button silBtn;
    }
}