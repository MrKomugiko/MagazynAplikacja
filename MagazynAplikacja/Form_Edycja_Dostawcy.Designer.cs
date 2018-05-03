namespace MagazynAplikacja
{
    partial class Form_Edycja_Dostawcy
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
            this.Btn_Zatwierdz_Edytuj = new System.Windows.Forms.Button();
            this.TextBox_Grupa = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Miejscowosc = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Adres = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_NIP = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Nazwa = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Firma = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_Kod = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Zatwierdz_Edytuj
            // 
            this.Btn_Zatwierdz_Edytuj.Location = new System.Drawing.Point(572, 281);
            this.Btn_Zatwierdz_Edytuj.Name = "Btn_Zatwierdz_Edytuj";
            this.Btn_Zatwierdz_Edytuj.Size = new System.Drawing.Size(187, 33);
            this.Btn_Zatwierdz_Edytuj.TabIndex = 53;
            this.Btn_Zatwierdz_Edytuj.Text = "EDYTUJ / ZAMKNIJ";
            this.Btn_Zatwierdz_Edytuj.UseVisualStyleBackColor = true;
            this.Btn_Zatwierdz_Edytuj.Click += new System.EventHandler(this.Btn_Zatwierdz_Edytuj_Click);
            // 
            // TextBox_Grupa
            // 
            this.TextBox_Grupa.Enabled = false;
            this.TextBox_Grupa.Location = new System.Drawing.Point(122, 265);
            this.TextBox_Grupa.Name = "TextBox_Grupa";
            this.TextBox_Grupa.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Grupa.TabIndex = 52;
            // 
            // TextBox_Miejscowosc
            // 
            this.TextBox_Miejscowosc.Location = new System.Drawing.Point(543, 160);
            this.TextBox_Miejscowosc.Name = "TextBox_Miejscowosc";
            this.TextBox_Miejscowosc.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Miejscowosc.TabIndex = 48;
            // 
            // TextBox_Adres
            // 
            this.TextBox_Adres.Location = new System.Drawing.Point(543, 107);
            this.TextBox_Adres.Name = "TextBox_Adres";
            this.TextBox_Adres.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Adres.TabIndex = 47;
            // 
            // TextBox_NIP
            // 
            this.TextBox_NIP.Location = new System.Drawing.Point(122, 213);
            this.TextBox_NIP.Name = "TextBox_NIP";
            this.TextBox_NIP.Size = new System.Drawing.Size(216, 22);
            this.TextBox_NIP.TabIndex = 46;
            // 
            // TextBox_Nazwa
            // 
            this.TextBox_Nazwa.Location = new System.Drawing.Point(122, 160);
            this.TextBox_Nazwa.Name = "TextBox_Nazwa";
            this.TextBox_Nazwa.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Nazwa.TabIndex = 45;
            // 
            // TextBox_Firma
            // 
            this.TextBox_Firma.Location = new System.Drawing.Point(122, 107);
            this.TextBox_Firma.Name = "TextBox_Firma";
            this.TextBox_Firma.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Firma.TabIndex = 44;
            // 
            // TextBox_Kod
            // 
            this.TextBox_Kod.Location = new System.Drawing.Point(543, 213);
            this.TextBox_Kod.Name = "TextBox_Kod";
            this.TextBox_Kod.Size = new System.Drawing.Size(216, 22);
            this.TextBox_Kod.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 32);
            this.label2.TabIndex = 51;
            this.label2.Text = "Dodawanie nowego dostawcy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Grupa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(418, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 17);
            this.label22.TabIndex = 43;
            this.label22.Text = "Kod pocztowy";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_ID.Location = new System.Drawing.Point(119, 58);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(87, 25);
            this.Label_ID.TabIndex = 42;
            this.Label_ID.Text = "numer id";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(46, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 25);
            this.label20.TabIndex = 41;
            this.label20.Text = "ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(418, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "Miejscowosc";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(418, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Adres";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "Nip";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Nazwa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Firma";
            // 
            // Form_Edycja_Dostawcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 326);
            this.Controls.Add(this.Btn_Zatwierdz_Edytuj);
            this.Controls.Add(this.TextBox_Grupa);
            this.Controls.Add(this.TextBox_Miejscowosc);
            this.Controls.Add(this.TextBox_Adres);
            this.Controls.Add(this.TextBox_NIP);
            this.Controls.Add(this.TextBox_Nazwa);
            this.Controls.Add(this.TextBox_Firma);
            this.Controls.Add(this.TextBox_Kod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.MaximumSize = new System.Drawing.Size(813, 373);
            this.MinimumSize = new System.Drawing.Size(813, 373);
            this.Name = "Form_Edycja_Dostawcy";
            this.Text = "Form_Edycja_Dostawcy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Zatwierdz_Edytuj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label Label_ID;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Firma;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Grupa;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Miejscowosc;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Adres;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_NIP;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Nazwa;
        protected internal System.Windows.Forms.MaskedTextBox TextBox_Kod;
    }
}