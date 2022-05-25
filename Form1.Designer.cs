
namespace NDP_Proje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StokIslem = new System.Windows.Forms.Button();
            this.MüsteriIslem = new System.Windows.Forms.Button();
            this.TedarikciIslem = new System.Windows.Forms.Button();
            this.GelirGiderIslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StokIslem
            // 
            this.StokIslem.BackColor = System.Drawing.Color.Yellow;
            this.StokIslem.Location = new System.Drawing.Point(61, 73);
            this.StokIslem.Name = "StokIslem";
            this.StokIslem.Size = new System.Drawing.Size(306, 117);
            this.StokIslem.TabIndex = 0;
            this.StokIslem.Text = "Stok İşlemleri";
            this.StokIslem.UseVisualStyleBackColor = false;
            this.StokIslem.Click += new System.EventHandler(this.StokIslem_Click);
            // 
            // MüsteriIslem
            // 
            this.MüsteriIslem.BackColor = System.Drawing.Color.Red;
            this.MüsteriIslem.Location = new System.Drawing.Point(442, 73);
            this.MüsteriIslem.Name = "MüsteriIslem";
            this.MüsteriIslem.Size = new System.Drawing.Size(306, 117);
            this.MüsteriIslem.TabIndex = 1;
            this.MüsteriIslem.Text = "Müşteri İşlemleri";
            this.MüsteriIslem.UseVisualStyleBackColor = false;
            this.MüsteriIslem.Click += new System.EventHandler(this.MüsteriIslem_Click);
            // 
            // TedarikciIslem
            // 
            this.TedarikciIslem.BackColor = System.Drawing.Color.Fuchsia;
            this.TedarikciIslem.Location = new System.Drawing.Point(61, 257);
            this.TedarikciIslem.Name = "TedarikciIslem";
            this.TedarikciIslem.Size = new System.Drawing.Size(306, 117);
            this.TedarikciIslem.TabIndex = 2;
            this.TedarikciIslem.Text = "Tedarikçi İşlemleri";
            this.TedarikciIslem.UseVisualStyleBackColor = false;
            this.TedarikciIslem.Click += new System.EventHandler(this.TedarikciIslem_Click);
            // 
            // GelirGiderIslem
            // 
            this.GelirGiderIslem.BackColor = System.Drawing.Color.Silver;
            this.GelirGiderIslem.Location = new System.Drawing.Point(442, 257);
            this.GelirGiderIslem.Name = "GelirGiderIslem";
            this.GelirGiderIslem.Size = new System.Drawing.Size(306, 117);
            this.GelirGiderIslem.TabIndex = 3;
            this.GelirGiderIslem.Text = "Gelir-Gider İşlemleri";
            this.GelirGiderIslem.UseVisualStyleBackColor = false;
            this.GelirGiderIslem.Click += new System.EventHandler(this.GelirGiderIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GelirGiderIslem);
            this.Controls.Add(this.TedarikciIslem);
            this.Controls.Add(this.MüsteriIslem);
            this.Controls.Add(this.StokIslem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StokIslem;
        private System.Windows.Forms.Button MüsteriIslem;
        private System.Windows.Forms.Button TedarikciIslem;
        private System.Windows.Forms.Button GelirGiderIslem;
    }
}

