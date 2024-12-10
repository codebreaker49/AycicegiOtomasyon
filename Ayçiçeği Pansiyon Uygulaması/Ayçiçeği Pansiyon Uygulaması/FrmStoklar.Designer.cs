namespace Ayçiçeği_Pansiyon_Uygulaması
{
    partial class FrmStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAtistirmaliklar = new System.Windows.Forms.TextBox();
            this.txtİcecekler = new System.Windows.Forms.TextBox();
            this.txtGidalar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblSu = new System.Windows.Forms.Label();
            this.lblElektrik = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 307);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(497, 142);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 168;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtAtistirmaliklar);
            this.groupBox1.Controls.Add(this.txtİcecekler);
            this.groupBox1.Controls.Add(this.txtGidalar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak Stokları";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(191, 191);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(184, 43);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // txtAtistirmaliklar
            // 
            this.txtAtistirmaliklar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAtistirmaliklar.Location = new System.Drawing.Point(160, 138);
            this.txtAtistirmaliklar.Name = "txtAtistirmaliklar";
            this.txtAtistirmaliklar.Size = new System.Drawing.Size(275, 31);
            this.txtAtistirmaliklar.TabIndex = 27;
            // 
            // txtİcecekler
            // 
            this.txtİcecekler.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİcecekler.Location = new System.Drawing.Point(160, 100);
            this.txtİcecekler.Name = "txtİcecekler";
            this.txtİcecekler.Size = new System.Drawing.Size(275, 31);
            this.txtİcecekler.TabIndex = 26;
            // 
            // txtGidalar
            // 
            this.txtGidalar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGidalar.Location = new System.Drawing.Point(160, 57);
            this.txtGidalar.Name = "txtGidalar";
            this.txtGidalar.Size = new System.Drawing.Size(275, 31);
            this.txtGidalar.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Atıştırmalıklar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "İçecekler:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gıda:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaydet2);
            this.groupBox2.Controls.Add(this.txtInternet);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.lblInternet);
            this.groupBox2.Controls.Add(this.lblSu);
            this.groupBox2.Controls.Add(this.lblElektrik);
            this.groupBox2.Location = new System.Drawing.Point(524, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 289);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKaydet2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet2.Location = new System.Drawing.Point(155, 191);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(184, 43);
            this.btnKaydet2.TabIndex = 28;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = false;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtInternet
            // 
            this.txtInternet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInternet.Location = new System.Drawing.Point(116, 141);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(275, 31);
            this.txtInternet.TabIndex = 27;
            // 
            // txtSu
            // 
            this.txtSu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu.Location = new System.Drawing.Point(116, 103);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(275, 31);
            this.txtSu.TabIndex = 26;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElektrik.Location = new System.Drawing.Point(116, 60);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(275, 31);
            this.txtElektrik.TabIndex = 25;
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInternet.Location = new System.Drawing.Point(24, 147);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(86, 25);
            this.lblInternet.TabIndex = 24;
            this.lblInternet.Text = "İnternet:";
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu.Location = new System.Drawing.Point(72, 106);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(38, 25);
            this.lblSu.TabIndex = 23;
            this.lblSu.Text = "Su:";
            // 
            // lblElektrik
            // 
            this.lblElektrik.AutoSize = true;
            this.lblElektrik.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElektrik.Location = new System.Drawing.Point(30, 66);
            this.lblElektrik.Name = "lblElektrik";
            this.lblElektrik.Size = new System.Drawing.Size(82, 25);
            this.lblElektrik.TabIndex = 22;
            this.lblElektrik.Text = "Elektrik:";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(515, 307);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(452, 142);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 128;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Faturalar Ve Giderler";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAtistirmaliklar;
        private System.Windows.Forms.TextBox txtİcecekler;
        private System.Windows.Forms.TextBox txtGidalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblElektrik;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}