namespace TelefonDefteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvEpostalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvTelefonlar = new System.Windows.Forms.ListView();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.txtGrup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsyeri = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIsyeri = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblAdiSoyadi = new System.Windows.Forms.Label();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 730);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 610);
            this.panel2.TabIndex = 2;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.BackgroundColor = System.Drawing.Color.White;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.Location = new System.Drawing.Point(0, 0);
            this.dgvListe.MultiSelect = false;
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.RowTemplate.Height = 25;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(389, 610);
            this.dgvListe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 98);
            this.panel1.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Yellow;
            this.btnAra.Location = new System.Drawing.Point(259, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(122, 80);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(11, 18);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(240, 23);
            this.txtAra.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(140, 59);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkle.Location = new System.Drawing.Point(11, 59);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 33);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle / Güncelle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvEpostalar);
            this.groupBox2.Controls.Add(this.lvTelefonlar);
            this.groupBox2.Controls.Add(this.pbProfil);
            this.groupBox2.Controls.Add(this.txtGrup);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIsyeri);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtUnvan);
            this.groupBox2.Controls.Add(this.txtAdiSoyadi);
            this.groupBox2.Controls.Add(this.lblUnvan);
            this.groupBox2.Controls.Add(this.lblAdres);
            this.groupBox2.Controls.Add(this.lblIsyeri);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.lblAdiSoyadi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(395, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 730);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Detayları";
            // 
            // lvEpostalar
            // 
            this.lvEpostalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEpostalar.Location = new System.Drawing.Point(18, 346);
            this.lvEpostalar.Name = "lvEpostalar";
            this.lvEpostalar.Size = new System.Drawing.Size(384, 97);
            this.lvEpostalar.TabIndex = 18;
            this.lvEpostalar.UseCompatibleStateImageBehavior = false;
            this.lvEpostalar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tür";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Eposta";
            this.columnHeader2.Width = 400;
            // 
            // lvTelefonlar
            // 
            this.lvTelefonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvTelefonlar.Location = new System.Drawing.Point(18, 211);
            this.lvTelefonlar.Name = "lvTelefonlar";
            this.lvTelefonlar.Size = new System.Drawing.Size(384, 97);
            this.lvTelefonlar.TabIndex = 17;
            this.lvTelefonlar.UseCompatibleStateImageBehavior = false;
            this.lvTelefonlar.View = System.Windows.Forms.View.Details;
            // 
            // pbProfil
            // 
            this.pbProfil.Location = new System.Drawing.Point(301, 19);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(101, 109);
            this.pbProfil.TabIndex = 16;
            this.pbProfil.TabStop = false;
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(18, 701);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(384, 23);
            this.txtGrup.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Epostalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefonlar";
            // 
            // txtIsyeri
            // 
            this.txtIsyeri.Location = new System.Drawing.Point(18, 638);
            this.txtIsyeri.Name = "txtIsyeri";
            this.txtIsyeri.Size = new System.Drawing.Size(384, 23);
            this.txtIsyeri.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(18, 533);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(384, 66);
            this.txtAdres.TabIndex = 7;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(18, 483);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(384, 23);
            this.txtUnvan.TabIndex = 6;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(18, 144);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(384, 23);
            this.txtAdiSoyadi.TabIndex = 5;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnvan.Location = new System.Drawing.Point(18, 459);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(55, 21);
            this.lblUnvan.TabIndex = 4;
            this.lblUnvan.Text = "Ünvan";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.Location = new System.Drawing.Point(18, 509);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 21);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres";
            // 
            // lblIsyeri
            // 
            this.lblIsyeri.AutoSize = true;
            this.lblIsyeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsyeri.Location = new System.Drawing.Point(18, 614);
            this.lblIsyeri.Name = "lblIsyeri";
            this.lblIsyeri.Size = new System.Drawing.Size(47, 21);
            this.lblIsyeri.TabIndex = 2;
            this.lblIsyeri.Text = "İşyeri";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(18, 31);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(30, 15);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "lblid";
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.AutoSize = true;
            this.lblAdiSoyadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdiSoyadi.Location = new System.Drawing.Point(18, 117);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(84, 21);
            this.lblAdiSoyadi.TabIndex = 0;
            this.lblAdiSoyadi.Text = "Adı Soyadı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tür";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 400;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Telefon Defterim";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView dgvListe;
        private Panel panel1;
        private Button btnAra;
        private TextBox txtAra;
        private Button btnSil;
        private Button btnEkle;
        private GroupBox groupBox2;
        private Label lblid;
        private Label lblAdiSoyadi;
        private Label lblUnvan;
        private Label lblAdres;
        private Label lblIsyeri;
        private ListView lvEpostalar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView lvTelefonlar;
        private PictureBox pbProfil;
        private TextBox txtGrup;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIsyeri;
        private TextBox txtAdres;
        private TextBox txtUnvan;
        private TextBox txtAdiSoyadi;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}