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
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dgvListe = new DataGridView();
            panel1 = new Panel();
            btnAra = new Button();
            txtAra = new TextBox();
            btnSil = new Button();
            btnEkleGuncelle = new Button();
            groupBox2 = new GroupBox();
            txtAciklama = new TextBox();
            label4 = new Label();
            btnGrupCikar = new Button();
            btnEpostaCikar = new Button();
            btnEpostaEkle = new Button();
            btnGrupEkle = new Button();
            btnTelefonCikar = new Button();
            btnTelefonEkle = new Button();
            cmbGrup = new ComboBox();
            label3 = new Label();
            btnTemizle = new Button();
            lvEpostalar = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lvTelefonlar = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pbProfil = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtIsyeri = new TextBox();
            txtAdres = new TextBox();
            txtUnvan = new TextBox();
            txtAdiSoyadi = new TextBox();
            lblUnvan = new Label();
            lblAdres = new Label();
            lblIsyeri = new Label();
            lblid = new Label();
            lblAdiSoyadi = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(451, 948);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişiler";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvListe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 105);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 839);
            panel2.TabIndex = 2;
            // 
            // dgvListe
            // 
            dgvListe.AllowUserToAddRows = false;
            dgvListe.AllowUserToDeleteRows = false;
            dgvListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListe.BackgroundColor = Color.White;
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Dock = DockStyle.Fill;
            dgvListe.Location = new Point(0, 0);
            dgvListe.Margin = new Padding(3, 4, 3, 4);
            dgvListe.MultiSelect = false;
            dgvListe.Name = "dgvListe";
            dgvListe.ReadOnly = true;
            dgvListe.RowHeadersWidth = 51;
            dgvListe.RowTemplate.Height = 25;
            dgvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListe.Size = new Size(445, 839);
            dgvListe.TabIndex = 0;
            dgvListe.CellClick += dgvListe_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(txtAra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 81);
            panel1.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.Yellow;
            btnAra.Location = new Point(296, 16);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(139, 39);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(13, 24);
            txtAra.Margin = new Padding(3, 4, 3, 4);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(274, 27);
            txtAra.TabIndex = 3;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(21, 883);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(127, 53);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.BackColor = Color.FromArgb(128, 255, 128);
            btnEkleGuncelle.Location = new Point(398, 883);
            btnEkleGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(127, 53);
            btnEkleGuncelle.TabIndex = 0;
            btnEkleGuncelle.Text = "Ekle / Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = false;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAciklama);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnGrupCikar);
            groupBox2.Controls.Add(btnEpostaCikar);
            groupBox2.Controls.Add(btnEpostaEkle);
            groupBox2.Controls.Add(btnGrupEkle);
            groupBox2.Controls.Add(btnTelefonCikar);
            groupBox2.Controls.Add(btnTelefonEkle);
            groupBox2.Controls.Add(cmbGrup);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(lvEpostalar);
            groupBox2.Controls.Add(lvTelefonlar);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(pbProfil);
            groupBox2.Controls.Add(btnEkleGuncelle);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtIsyeri);
            groupBox2.Controls.Add(txtAdres);
            groupBox2.Controls.Add(txtUnvan);
            groupBox2.Controls.Add(txtAdiSoyadi);
            groupBox2.Controls.Add(lblUnvan);
            groupBox2.Controls.Add(lblAdres);
            groupBox2.Controls.Add(lblIsyeri);
            groupBox2.Controls.Add(lblid);
            groupBox2.Controls.Add(lblAdiSoyadi);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(451, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(550, 948);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kişi Detayları";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(24, 831);
            txtAciklama.Margin = new Padding(3, 4, 3, 4);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(517, 27);
            txtAciklama.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 799);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 27;
            label4.Text = "Açıklama";
            // 
            // btnGrupCikar
            // 
            btnGrupCikar.BackColor = Color.Silver;
            btnGrupCikar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrupCikar.Location = new Point(463, 204);
            btnGrupCikar.Margin = new Padding(3, 4, 3, 4);
            btnGrupCikar.Name = "btnGrupCikar";
            btnGrupCikar.Size = new Size(63, 33);
            btnGrupCikar.TabIndex = 26;
            btnGrupCikar.Text = "-";
            btnGrupCikar.UseVisualStyleBackColor = false;
            btnGrupCikar.Click += btnGrupCikar_Click;
            // 
            // btnEpostaCikar
            // 
            btnEpostaCikar.BackColor = Color.Silver;
            btnEpostaCikar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEpostaCikar.Location = new Point(466, 519);
            btnEpostaCikar.Margin = new Padding(3, 4, 3, 4);
            btnEpostaCikar.Name = "btnEpostaCikar";
            btnEpostaCikar.Size = new Size(63, 53);
            btnEpostaCikar.TabIndex = 23;
            btnEpostaCikar.Text = "-";
            btnEpostaCikar.UseVisualStyleBackColor = false;
            // 
            // btnEpostaEkle
            // 
            btnEpostaEkle.BackColor = Color.Silver;
            btnEpostaEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEpostaEkle.Location = new Point(466, 443);
            btnEpostaEkle.Margin = new Padding(3, 4, 3, 4);
            btnEpostaEkle.Name = "btnEpostaEkle";
            btnEpostaEkle.Size = new Size(63, 53);
            btnEpostaEkle.TabIndex = 22;
            btnEpostaEkle.Text = "+";
            btnEpostaEkle.UseVisualStyleBackColor = false;
            btnEpostaEkle.Click += btnEpostaEkle_Click;
            // 
            // btnGrupEkle
            // 
            btnGrupEkle.BackColor = Color.Silver;
            btnGrupEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrupEkle.Location = new Point(398, 204);
            btnGrupEkle.Margin = new Padding(3, 4, 3, 4);
            btnGrupEkle.Name = "btnGrupEkle";
            btnGrupEkle.Size = new Size(63, 33);
            btnGrupEkle.TabIndex = 25;
            btnGrupEkle.Text = "+";
            btnGrupEkle.UseVisualStyleBackColor = false;
            btnGrupEkle.Click += btnGrupEkle_Click;
            // 
            // btnTelefonCikar
            // 
            btnTelefonCikar.BackColor = Color.Silver;
            btnTelefonCikar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTelefonCikar.Location = new Point(466, 348);
            btnTelefonCikar.Margin = new Padding(3, 4, 3, 4);
            btnTelefonCikar.Name = "btnTelefonCikar";
            btnTelefonCikar.Size = new Size(63, 53);
            btnTelefonCikar.TabIndex = 21;
            btnTelefonCikar.Text = "-";
            btnTelefonCikar.UseVisualStyleBackColor = false;
            // 
            // btnTelefonEkle
            // 
            btnTelefonEkle.BackColor = Color.Silver;
            btnTelefonEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTelefonEkle.Location = new Point(466, 272);
            btnTelefonEkle.Margin = new Padding(3, 4, 3, 4);
            btnTelefonEkle.Name = "btnTelefonEkle";
            btnTelefonEkle.Size = new Size(63, 53);
            btnTelefonEkle.TabIndex = 20;
            btnTelefonEkle.Text = "+";
            btnTelefonEkle.UseVisualStyleBackColor = false;
            btnTelefonEkle.Click += btnTelefonEkle_Click;
            // 
            // cmbGrup
            // 
            cmbGrup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrup.FormattingEnabled = true;
            cmbGrup.Location = new Point(24, 205);
            cmbGrup.Margin = new Padding(3, 4, 3, 4);
            cmbGrup.Name = "cmbGrup";
            cmbGrup.Size = new Size(366, 28);
            cmbGrup.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 169);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 14;
            label3.Text = "Grup";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.Yellow;
            btnTemizle.Location = new Point(209, 883);
            btnTemizle.Margin = new Padding(3, 4, 3, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(127, 53);
            btnTemizle.TabIndex = 19;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lvEpostalar
            // 
            lvEpostalar.CheckBoxes = true;
            lvEpostalar.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2 });
            lvEpostalar.Location = new Point(21, 443);
            lvEpostalar.Margin = new Padding(3, 4, 3, 4);
            lvEpostalar.Name = "lvEpostalar";
            lvEpostalar.Size = new Size(438, 128);
            lvEpostalar.TabIndex = 18;
            lvEpostalar.UseCompatibleStateImageBehavior = false;
            lvEpostalar.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Seç";
            columnHeader6.Width = 20;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tür";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Eposta";
            columnHeader2.Width = 400;
            // 
            // lvTelefonlar
            // 
            lvTelefonlar.CheckBoxes = true;
            lvTelefonlar.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader3, columnHeader4 });
            lvTelefonlar.Location = new Point(21, 272);
            lvTelefonlar.Margin = new Padding(3, 4, 3, 4);
            lvTelefonlar.Name = "lvTelefonlar";
            lvTelefonlar.Size = new Size(438, 128);
            lvTelefonlar.TabIndex = 17;
            lvTelefonlar.UseCompatibleStateImageBehavior = false;
            lvTelefonlar.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Seç";
            columnHeader5.Width = 20;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tür";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            columnHeader4.Width = 400;
            // 
            // pbProfil
            // 
            pbProfil.BackColor = Color.White;
            pbProfil.Location = new Point(409, 25);
            pbProfil.Margin = new Padding(3, 4, 3, 4);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(115, 145);
            pbProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfil.TabIndex = 16;
            pbProfil.TabStop = false;
            pbProfil.Click += pbProfil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 411);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 11;
            label2.Text = "Epostalar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 240);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 9;
            label1.Text = "Telefonlar";
            // 
            // txtIsyeri
            // 
            txtIsyeri.Location = new Point(285, 614);
            txtIsyeri.Margin = new Padding(3, 4, 3, 4);
            txtIsyeri.Name = "txtIsyeri";
            txtIsyeri.Size = new Size(257, 27);
            txtIsyeri.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(21, 691);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(505, 87);
            txtAdres.TabIndex = 7;
            // 
            // txtUnvan
            // 
            txtUnvan.Location = new Point(21, 614);
            txtUnvan.Margin = new Padding(3, 4, 3, 4);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(257, 27);
            txtUnvan.TabIndex = 6;
            // 
            // txtAdiSoyadi
            // 
            txtAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdiSoyadi.Location = new Point(24, 132);
            txtAdiSoyadi.Margin = new Padding(3, 4, 3, 4);
            txtAdiSoyadi.Name = "txtAdiSoyadi";
            txtAdiSoyadi.Size = new Size(366, 34);
            txtAdiSoyadi.TabIndex = 5;
            // 
            // lblUnvan
            // 
            lblUnvan.AutoSize = true;
            lblUnvan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnvan.Location = new Point(21, 582);
            lblUnvan.Name = "lblUnvan";
            lblUnvan.Size = new Size(68, 28);
            lblUnvan.TabIndex = 4;
            lblUnvan.Text = "Ünvan";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdres.Location = new Point(21, 659);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(62, 28);
            lblAdres.TabIndex = 3;
            lblAdres.Text = "Adres";
            // 
            // lblIsyeri
            // 
            lblIsyeri.AutoSize = true;
            lblIsyeri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsyeri.Location = new Point(285, 582);
            lblIsyeri.Name = "lblIsyeri";
            lblIsyeri.Size = new Size(57, 28);
            lblIsyeri.TabIndex = 2;
            lblIsyeri.Text = "İşyeri";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(21, 41);
            lblid.Name = "lblid";
            lblid.Size = new Size(39, 20);
            lblid.TabIndex = 1;
            lblid.Text = "lblid";
            // 
            // lblAdiSoyadi
            // 
            lblAdiSoyadi.AutoSize = true;
            lblAdiSoyadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdiSoyadi.Location = new Point(24, 96);
            lblAdiSoyadi.Name = "lblAdiSoyadi";
            lblAdiSoyadi.Size = new Size(107, 28);
            lblAdiSoyadi.TabIndex = 0;
            lblAdiSoyadi.Text = "Adı Soyadı";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 948);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Telefon Defterim";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            ResumeLayout(false);
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
        private TextBox txtAciklama;
        private Label label4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader5;
        private OpenFileDialog openFileDialog1;
    }
}