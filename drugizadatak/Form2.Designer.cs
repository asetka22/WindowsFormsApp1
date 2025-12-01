namespace drugizadatak
{
    partial class Form2
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblRazred = new System.Windows.Forms.Label();
            this.lblUspjeh = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.cbUspjeh = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(16, 27);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(16, 63);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblRazred
            // 
            this.lblRazred.AutoSize = true;
            this.lblRazred.Location = new System.Drawing.Point(15, 96);
            this.lblRazred.Name = "lblRazred";
            this.lblRazred.Size = new System.Drawing.Size(44, 13);
            this.lblRazred.TabIndex = 2;
            this.lblRazred.Text = "Razred:";
            // 
            // lblUspjeh
            // 
            this.lblUspjeh.AutoSize = true;
            this.lblUspjeh.Location = new System.Drawing.Point(16, 129);
            this.lblUspjeh.Name = "lblUspjeh";
            this.lblUspjeh.Size = new System.Drawing.Size(43, 13);
            this.lblUspjeh.TabIndex = 3;
            this.lblUspjeh.Text = "Uspjeh:";
            this.lblUspjeh.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(69, 60);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(69, 24);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // cbRazred
            // 
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cbRazred.Location = new System.Drawing.Point(69, 93);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(121, 21);
            this.cbRazred.TabIndex = 6;
            // 
            // cbUspjeh
            // 
            this.cbUspjeh.FormattingEnabled = true;
            this.cbUspjeh.Items.AddRange(new object[] {
            "Nedovoljan",
            "Dovoljan",
            "Dobar",
            "Vrlo dobar",
            "Odličan"});
            this.cbUspjeh.Location = new System.Drawing.Point(69, 129);
            this.cbUspjeh.Name = "cbUspjeh";
            this.cbUspjeh.Size = new System.Drawing.Size(121, 21);
            this.cbUspjeh.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(39, 180);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(191, 180);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbUspjeh);
            this.Controls.Add(this.cbRazred);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblUspjeh);
            this.Controls.Add(this.lblRazred);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblRazred;
        private System.Windows.Forms.Label lblUspjeh;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.ComboBox cbUspjeh;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnZatvori;
    }
}