namespace TelefonDefteri
{
    partial class EklemeFormu
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
            this.txtTur = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.txtEpostaTelefonGrup = new System.Windows.Forms.TextBox();
            this.lblEpostaTelefonGrup = new System.Windows.Forms.Label();
            this.btnEpostaTelefonGrupEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTur.Location = new System.Drawing.Point(11, 39);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(438, 29);
            this.txtTur.TabIndex = 7;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTur.Location = new System.Drawing.Point(11, 12);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(33, 21);
            this.lblTur.TabIndex = 6;
            this.lblTur.Text = "Tür";
            // 
            // txtEpostaTelefonGrup
            // 
            this.txtEpostaTelefonGrup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEpostaTelefonGrup.Location = new System.Drawing.Point(11, 103);
            this.txtEpostaTelefonGrup.Name = "txtEpostaTelefonGrup";
            this.txtEpostaTelefonGrup.Size = new System.Drawing.Size(438, 29);
            this.txtEpostaTelefonGrup.TabIndex = 9;
            // 
            // lblEpostaTelefonGrup
            // 
            this.lblEpostaTelefonGrup.AutoSize = true;
            this.lblEpostaTelefonGrup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEpostaTelefonGrup.Location = new System.Drawing.Point(11, 76);
            this.lblEpostaTelefonGrup.Name = "lblEpostaTelefonGrup";
            this.lblEpostaTelefonGrup.Size = new System.Drawing.Size(157, 21);
            this.lblEpostaTelefonGrup.TabIndex = 8;
            this.lblEpostaTelefonGrup.Text = "lblEpostaTelefonGrup";
            // 
            // btnEpostaTelefonGrupEkle
            // 
            this.btnEpostaTelefonGrupEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEpostaTelefonGrupEkle.Location = new System.Drawing.Point(338, 150);
            this.btnEpostaTelefonGrupEkle.Name = "btnEpostaTelefonGrupEkle";
            this.btnEpostaTelefonGrupEkle.Size = new System.Drawing.Size(111, 40);
            this.btnEpostaTelefonGrupEkle.TabIndex = 20;
            this.btnEpostaTelefonGrupEkle.Text = "Ekle";
            this.btnEpostaTelefonGrupEkle.UseVisualStyleBackColor = false;
            // 
            // EklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.Controls.Add(this.btnEpostaTelefonGrupEkle);
            this.Controls.Add(this.txtEpostaTelefonGrup);
            this.Controls.Add(this.lblEpostaTelefonGrup);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.lblTur);
            this.Name = "EklemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ekleme Formu";
            this.Load += new System.EventHandler(this.EklemeFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTur;
        private Label lblTur;
        private TextBox txtEpostaTelefonGrup;
        private Label lblEpostaTelefonGrup;
        private Button btnEpostaTelefonGrupEkle;
    }
}