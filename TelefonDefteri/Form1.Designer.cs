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
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrupCikar = new System.Windows.Forms.Button();
            this.btnEpostaCikar = new System.Windows.Forms.Button();
            this.btnEpostaEkle = new System.Windows.Forms.Button();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.btnTelefonCikar = new System.Windows.Forms.Button();
            this.btnTelefonEkle = new System.Windows.Forms.Button();
            this.cmbGrup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lvEpostalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvTelefonlar = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.pbProfil = new System.Windows.Forms.PictureBox();
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
            this.groupBox1.Size = new System.Drawing.Size(395, 806);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişiler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 723);
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
            this.dgvListe.Size = new System.Drawing.Size(389, 723);
            this.dgvListe.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Yellow;
            this.btnAra.Location = new System.Drawing.Point(259, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(122, 29);
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
            this.btnSil.Location = new System.Drawing.Point(18, 742);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkleGuncelle.Location = new System.Drawing.Point(348, 742);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(111, 40);
            this.btnEkleGuncelle.TabIndex = 0;
            this.btnEkleGuncelle.Text = "Ekle / Güncelle";
            this.btnEkleGuncelle.UseVisualStyleBackColor = false;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrupCikar);
            this.groupBox2.Controls.Add(this.btnEpostaCikar);
            this.groupBox2.Controls.Add(this.btnEpostaEkle);
            this.groupBox2.Controls.Add(this.btnGrupEkle);
            this.groupBox2.Controls.Add(this.btnTelefonCikar);
            this.groupBox2.Controls.Add(this.btnTelefonEkle);
            this.groupBox2.Controls.Add(this.cmbGrup);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.lvEpostalar);
            this.groupBox2.Controls.Add(this.lvTelefonlar);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.pbProfil);
            this.groupBox2.Controls.Add(this.btnEkleGuncelle);
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
            this.groupBox2.Size = new System.Drawing.Size(471, 806);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Detayları";
            // 
            // btnGrupCikar
            // 
            this.btnGrupCikar.BackColor = System.Drawing.Color.Silver;
            this.btnGrupCikar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrupCikar.Location = new System.Drawing.Point(405, 210);
            this.btnGrupCikar.Name = "btnGrupCikar";
            this.btnGrupCikar.Size = new System.Drawing.Size(55, 25);
            this.btnGrupCikar.TabIndex = 26;
            this.btnGrupCikar.Text = "-";
            this.btnGrupCikar.UseVisualStyleBackColor = false;
            // 
            // btnEpostaCikar
            // 
            this.btnEpostaCikar.BackColor = System.Drawing.Color.Silver;
            this.btnEpostaCikar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEpostaCikar.Location = new System.Drawing.Point(408, 462);
            this.btnEpostaCikar.Name = "btnEpostaCikar";
            this.btnEpostaCikar.Size = new System.Drawing.Size(55, 40);
            this.btnEpostaCikar.TabIndex = 23;
            this.btnEpostaCikar.Text = "-";
            this.btnEpostaCikar.UseVisualStyleBackColor = false;
            // 
            // btnEpostaEkle
            // 
            this.btnEpostaEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEpostaEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEpostaEkle.Location = new System.Drawing.Point(408, 405);
            this.btnEpostaEkle.Name = "btnEpostaEkle";
            this.btnEpostaEkle.Size = new System.Drawing.Size(55, 40);
            this.btnEpostaEkle.TabIndex = 22;
            this.btnEpostaEkle.Text = "+";
            this.btnEpostaEkle.UseVisualStyleBackColor = false;
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.BackColor = System.Drawing.Color.Silver;
            this.btnGrupEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGrupEkle.Location = new System.Drawing.Point(348, 210);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(55, 25);
            this.btnGrupEkle.TabIndex = 25;
            this.btnGrupEkle.Text = "+";
            this.btnGrupEkle.UseVisualStyleBackColor = false;
            // 
            // btnTelefonCikar
            // 
            this.btnTelefonCikar.BackColor = System.Drawing.Color.Silver;
            this.btnTelefonCikar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTelefonCikar.Location = new System.Drawing.Point(408, 326);
            this.btnTelefonCikar.Name = "btnTelefonCikar";
            this.btnTelefonCikar.Size = new System.Drawing.Size(55, 40);
            this.btnTelefonCikar.TabIndex = 21;
            this.btnTelefonCikar.Text = "-";
            this.btnTelefonCikar.UseVisualStyleBackColor = false;
            // 
            // btnTelefonEkle
            // 
            this.btnTelefonEkle.BackColor = System.Drawing.Color.Silver;
            this.btnTelefonEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTelefonEkle.Location = new System.Drawing.Point(408, 269);
            this.btnTelefonEkle.Name = "btnTelefonEkle";
            this.btnTelefonEkle.Size = new System.Drawing.Size(55, 40);
            this.btnTelefonEkle.TabIndex = 20;
            this.btnTelefonEkle.Text = "+";
            this.btnTelefonEkle.UseVisualStyleBackColor = false;
            // 
            // cmbGrup
            // 
            this.cmbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrup.FormattingEnabled = true;
            this.cmbGrup.Location = new System.Drawing.Point(21, 211);
            this.cmbGrup.Name = "cmbGrup";
            this.cmbGrup.Size = new System.Drawing.Size(321, 23);
            this.cmbGrup.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grup";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Yellow;
            this.btnTemizle.Location = new System.Drawing.Point(183, 742);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(111, 40);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lvEpostalar
            // 
            this.lvEpostalar.CheckBoxes = true;
            this.lvEpostalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvEpostalar.Location = new System.Drawing.Point(18, 405);
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
            this.lvTelefonlar.CheckBoxes = true;
            this.lvTelefonlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvTelefonlar.Location = new System.Drawing.Point(18, 269);
            this.lvTelefonlar.Name = "lvTelefonlar";
            this.lvTelefonlar.Size = new System.Drawing.Size(384, 97);
            this.lvTelefonlar.TabIndex = 17;
            this.lvTelefonlar.UseCompatibleStateImageBehavior = false;
            this.lvTelefonlar.View = System.Windows.Forms.View.Details;
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
            // pbProfil
            // 
            this.pbProfil.Location = new System.Drawing.Point(358, 19);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(101, 109);
            this.pbProfil.TabIndex = 16;
            this.pbProfil.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Epostalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefonlar";
            // 
            // txtIsyeri
            // 
            this.txtIsyeri.Location = new System.Drawing.Point(18, 703);
            this.txtIsyeri.Name = "txtIsyeri";
            this.txtIsyeri.Size = new System.Drawing.Size(442, 23);
            this.txtIsyeri.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(18, 598);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(442, 66);
            this.txtAdres.TabIndex = 7;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(18, 540);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(442, 23);
            this.txtUnvan.TabIndex = 6;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdiSoyadi.Location = new System.Drawing.Point(21, 144);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(438, 29);
            this.txtAdiSoyadi.TabIndex = 5;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnvan.Location = new System.Drawing.Point(18, 516);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(55, 21);
            this.lblUnvan.TabIndex = 4;
            this.lblUnvan.Text = "Ünvan";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.Location = new System.Drawing.Point(18, 574);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 21);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres";
            // 
            // lblIsyeri
            // 
            this.lblIsyeri.AutoSize = true;
            this.lblIsyeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIsyeri.Location = new System.Drawing.Point(18, 679);
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
            this.lblAdiSoyadi.Location = new System.Drawing.Point(21, 117);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(84, 21);
            this.lblAdiSoyadi.TabIndex = 0;
            this.lblAdiSoyadi.Text = "Adı Soyadı";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 806);
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
        private Button btnEkleGuncelle;
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
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIsyeri;
        private TextBox txtAdres;
        private TextBox txtUnvan;
        private TextBox txtAdiSoyadi;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnTelefonEkle;
        private Button btnTemizle;
        private Button btnGrupCikar;
        private Button btnGrupEkle;
        private ComboBox cmbGrup;
        private Button btnEpostaCikar;
        private Button btnEpostaEkle;
        private Button btnTelefonCikar;
    }
}