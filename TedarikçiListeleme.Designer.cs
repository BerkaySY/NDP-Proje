
namespace NDP_Proje
{
    partial class TedarikçiListeleme
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
            this.silBtn = new System.Windows.Forms.Button();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.telTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firmaAdTextBox = new System.Windows.Forms.TextBox();
            this.firmaNoTextBox = new System.Windows.Forms.TextBox();
            this.adresLbl = new System.Windows.Forms.Label();
            this.telLbl = new System.Windows.Forms.Label();
            this.soyadLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.firmaNoLbl = new System.Windows.Forms.Label();
            this.firmaAraLbl = new System.Windows.Forms.Label();
            this.firmaAraTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 347);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.silBtn.Location = new System.Drawing.Point(208, 16);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(107, 24);
            this.silBtn.TabIndex = 18;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.Lime;
            this.güncelleBtn.Location = new System.Drawing.Point(28, 313);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(155, 53);
            this.güncelleBtn.TabIndex = 19;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(82, 163);
            this.telTextBox.Mask = "(999) 000-0000";
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 23);
            this.telTextBox.TabIndex = 29;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(82, 243);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(100, 45);
            this.adresTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(82, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 23);
            this.emailTextBox.TabIndex = 27;
            // 
            // firmaAdTextBox
            // 
            this.firmaAdTextBox.Location = new System.Drawing.Point(82, 125);
            this.firmaAdTextBox.Name = "firmaAdTextBox";
            this.firmaAdTextBox.Size = new System.Drawing.Size(100, 23);
            this.firmaAdTextBox.TabIndex = 26;
            // 
            // firmaNoTextBox
            // 
            this.firmaNoTextBox.Location = new System.Drawing.Point(82, 83);
            this.firmaNoTextBox.Name = "firmaNoTextBox";
            this.firmaNoTextBox.ReadOnly = true;
            this.firmaNoTextBox.Size = new System.Drawing.Size(100, 23);
            this.firmaNoTextBox.TabIndex = 25;
            // 
            // adresLbl
            // 
            this.adresLbl.AutoSize = true;
            this.adresLbl.ForeColor = System.Drawing.Color.White;
            this.adresLbl.Location = new System.Drawing.Point(27, 246);
            this.adresLbl.Name = "adresLbl";
            this.adresLbl.Size = new System.Drawing.Size(43, 15);
            this.adresLbl.TabIndex = 24;
            this.adresLbl.Text = "Adres :";
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.ForeColor = System.Drawing.Color.White;
            this.telLbl.Location = new System.Drawing.Point(22, 166);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(54, 15);
            this.telLbl.TabIndex = 23;
            this.telLbl.Text = "Telefon : ";
            // 
            // soyadLbl
            // 
            this.soyadLbl.AutoSize = true;
            this.soyadLbl.ForeColor = System.Drawing.Color.White;
            this.soyadLbl.Location = new System.Drawing.Point(28, 204);
            this.soyadLbl.Name = "soyadLbl";
            this.soyadLbl.Size = new System.Drawing.Size(42, 15);
            this.soyadLbl.TabIndex = 22;
            this.soyadLbl.Text = "Email :";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.ForeColor = System.Drawing.Color.White;
            this.adLbl.Location = new System.Drawing.Point(12, 128);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(64, 15);
            this.adLbl.TabIndex = 21;
            this.adLbl.Text = "Firma Adı :";
            // 
            // firmaNoLbl
            // 
            this.firmaNoLbl.AutoSize = true;
            this.firmaNoLbl.ForeColor = System.Drawing.Color.White;
            this.firmaNoLbl.Location = new System.Drawing.Point(14, 86);
            this.firmaNoLbl.Name = "firmaNoLbl";
            this.firmaNoLbl.Size = new System.Drawing.Size(62, 15);
            this.firmaNoLbl.TabIndex = 20;
            this.firmaNoLbl.Text = "Firma No :";
            // 
            // firmaAraLbl
            // 
            this.firmaAraLbl.AutoSize = true;
            this.firmaAraLbl.ForeColor = System.Drawing.Color.White;
            this.firmaAraLbl.Location = new System.Drawing.Point(460, 21);
            this.firmaAraLbl.Name = "firmaAraLbl";
            this.firmaAraLbl.Size = new System.Drawing.Size(58, 15);
            this.firmaAraLbl.TabIndex = 30;
            this.firmaAraLbl.Text = "Firma Ara";
            // 
            // firmaAraTextBox
            // 
            this.firmaAraTextBox.Location = new System.Drawing.Point(524, 18);
            this.firmaAraTextBox.Name = "firmaAraTextBox";
            this.firmaAraTextBox.Size = new System.Drawing.Size(177, 23);
            this.firmaAraTextBox.TabIndex = 31;
            this.firmaAraTextBox.TextChanged += new System.EventHandler(this.firmaAraTextBox_TextChanged);
            // 
            // TedarikçiListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firmaAraTextBox);
            this.Controls.Add(this.firmaAraLbl);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.firmaAdTextBox);
            this.Controls.Add(this.firmaNoTextBox);
            this.Controls.Add(this.adresLbl);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.soyadLbl);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.firmaNoLbl);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TedarikçiListeleme";
            this.Text = "TedarikçiListeleme";
            this.Load += new System.EventHandler(this.TedarikçiListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.MaskedTextBox telTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firmaAdTextBox;
        private System.Windows.Forms.TextBox firmaNoTextBox;
        private System.Windows.Forms.Label adresLbl;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label soyadLbl;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Label firmaNoLbl;
        private System.Windows.Forms.Label firmaAraLbl;
        private System.Windows.Forms.TextBox firmaAraTextBox;
    }
}