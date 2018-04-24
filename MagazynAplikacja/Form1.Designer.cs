namespace MagazynAplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_loadXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nazwa = new System.Windows.Forms.TextBox();
            this.textBox_Netto = new System.Windows.Forms.TextBox();
            this.textBox_VAT = new System.Windows.Forms.TextBox();
            this.textBox_Brutto = new System.Windows.Forms.TextBox();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Edytuj = new System.Windows.Forms.Button();
            this.button_Usun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartosc_calk_netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2_Miasto = new System.Windows.Forms.TextBox();
            this.textBox2_Kod = new System.Windows.Forms.TextBox();
            this.textBox2_Adres = new System.Windows.Forms.TextBox();
            this.textBox2_NIP = new System.Windows.Forms.TextBox();
            this.textBox2_Nazwa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_ZapiszXML = new System.Windows.Forms.Button();
            this.button_Zaladuj = new System.Windows.Forms.Button();
            this.textBox_ilosc = new System.Windows.Forms.TextBox();
            this.label_ilosc = new System.Windows.Forms.Label();
            this.Btn_Zamowienia = new System.Windows.Forms.Button();
            this.Btn_Magazyn = new System.Windows.Forms.Button();
            this.panel_Magazyn = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Zamowienia = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_Dostawa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Magazyn.SuspendLayout();
            this.panel_Zamowienia.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_loadXML
            // 
            this.Btn_loadXML.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_loadXML.Enabled = false;
            this.Btn_loadXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_loadXML.Location = new System.Drawing.Point(12, 273);
            this.Btn_loadXML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_loadXML.Name = "Btn_loadXML";
            this.Btn_loadXML.Size = new System.Drawing.Size(147, 50);
            this.Btn_loadXML.TabIndex = 0;
            this.Btn_loadXML.Text = "Załaduj Dostawców z XML";
            this.Btn_loadXML.UseVisualStyleBackColor = true;
            this.Btn_loadXML.Click += new System.EventHandler(this.Btn_loadXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(900, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produkty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cena brutto";
            // 
            // textBox_Nazwa
            // 
            this.textBox_Nazwa.Location = new System.Drawing.Point(959, 80);
            this.textBox_Nazwa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nazwa.Name = "textBox_Nazwa";
            this.textBox_Nazwa.Size = new System.Drawing.Size(179, 22);
            this.textBox_Nazwa.TabIndex = 9;
            // 
            // textBox_Netto
            // 
            this.textBox_Netto.Location = new System.Drawing.Point(959, 118);
            this.textBox_Netto.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Netto.Name = "textBox_Netto";
            this.textBox_Netto.Size = new System.Drawing.Size(179, 22);
            this.textBox_Netto.TabIndex = 10;
            // 
            // textBox_VAT
            // 
            this.textBox_VAT.Location = new System.Drawing.Point(959, 159);
            this.textBox_VAT.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_VAT.Name = "textBox_VAT";
            this.textBox_VAT.Size = new System.Drawing.Size(179, 22);
            this.textBox_VAT.TabIndex = 11;
            // 
            // textBox_Brutto
            // 
            this.textBox_Brutto.Location = new System.Drawing.Point(959, 197);
            this.textBox_Brutto.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Brutto.Name = "textBox_Brutto";
            this.textBox_Brutto.Size = new System.Drawing.Size(179, 22);
            this.textBox_Brutto.TabIndex = 12;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(615, 273);
            this.button_Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(147, 50);
            this.button_Dodaj.TabIndex = 14;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Edytuj
            // 
            this.button_Edytuj.Location = new System.Drawing.Point(785, 273);
            this.button_Edytuj.Margin = new System.Windows.Forms.Padding(4);
            this.button_Edytuj.Name = "button_Edytuj";
            this.button_Edytuj.Size = new System.Drawing.Size(147, 50);
            this.button_Edytuj.TabIndex = 15;
            this.button_Edytuj.Text = "Edytuj";
            this.button_Edytuj.UseVisualStyleBackColor = true;
            this.button_Edytuj.Click += new System.EventHandler(this.button_Edytuj_Click);
            // 
            // button_Usun
            // 
            this.button_Usun.Location = new System.Drawing.Point(959, 273);
            this.button_Usun.Margin = new System.Windows.Forms.Padding(4);
            this.button_Usun.Name = "button_Usun";
            this.button_Usun.Size = new System.Drawing.Size(147, 50);
            this.button_Usun.TabIndex = 16;
            this.button_Usun.Text = "Usuń";
            this.button_Usun.UseVisualStyleBackColor = true;
            this.button_Usun.Click += new System.EventHandler(this.button_Usun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Miasto,
            this.Adres,
            this.BRUTTO,
            this.Ilosc,
            this.Wartosc_calk_netto});
            this.dataGridView1.Location = new System.Drawing.Point(177, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 337);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            // 
            // Miasto
            // 
            this.Miasto.HeaderText = "NETTO";
            this.Miasto.Name = "Miasto";
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Podatek";
            this.Adres.Name = "Adres";
            // 
            // BRUTTO
            // 
            this.BRUTTO.HeaderText = "BRUTTO";
            this.BRUTTO.Name = "BRUTTO";
            // 
            // Ilosc
            // 
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.ReadOnly = true;
            // 
            // Wartosc_calk_netto
            // 
            this.Wartosc_calk_netto.HeaderText = "Wartosc calk netto";
            this.Wartosc_calk_netto.Name = "Wartosc_calk_netto";
            this.Wartosc_calk_netto.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(616, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dostawca";
            // 
            // textBox2_Miasto
            // 
            this.textBox2_Miasto.Location = new System.Drawing.Point(668, 235);
            this.textBox2_Miasto.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Miasto.Name = "textBox2_Miasto";
            this.textBox2_Miasto.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Miasto.TabIndex = 28;
            // 
            // textBox2_Kod
            // 
            this.textBox2_Kod.Location = new System.Drawing.Point(668, 197);
            this.textBox2_Kod.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Kod.Name = "textBox2_Kod";
            this.textBox2_Kod.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Kod.TabIndex = 27;
            // 
            // textBox2_Adres
            // 
            this.textBox2_Adres.Location = new System.Drawing.Point(668, 159);
            this.textBox2_Adres.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Adres.Name = "textBox2_Adres";
            this.textBox2_Adres.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Adres.TabIndex = 26;
            // 
            // textBox2_NIP
            // 
            this.textBox2_NIP.Location = new System.Drawing.Point(668, 118);
            this.textBox2_NIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_NIP.Name = "textBox2_NIP";
            this.textBox2_NIP.Size = new System.Drawing.Size(179, 22);
            this.textBox2_NIP.TabIndex = 25;
            // 
            // textBox2_Nazwa
            // 
            this.textBox2_Nazwa.Location = new System.Drawing.Point(668, 80);
            this.textBox2_Nazwa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Nazwa.Name = "textBox2_Nazwa";
            this.textBox2_Nazwa.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Nazwa.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Miasto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(564, 167);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(564, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "NIP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nazwa";
            // 
            // button_ZapiszXML
            // 
            this.button_ZapiszXML.Location = new System.Drawing.Point(568, 331);
            this.button_ZapiszXML.Margin = new System.Windows.Forms.Padding(4);
            this.button_ZapiszXML.Name = "button_ZapiszXML";
            this.button_ZapiszXML.Size = new System.Drawing.Size(280, 39);
            this.button_ZapiszXML.TabIndex = 29;
            this.button_ZapiszXML.Text = "Zapisz jako XML";
            this.button_ZapiszXML.UseVisualStyleBackColor = true;
            this.button_ZapiszXML.Click += new System.EventHandler(this.button_ZapiszXML_Click);
            // 
            // button_Zaladuj
            // 
            this.button_Zaladuj.Location = new System.Drawing.Point(859, 331);
            this.button_Zaladuj.Margin = new System.Windows.Forms.Padding(4);
            this.button_Zaladuj.Name = "button_Zaladuj";
            this.button_Zaladuj.Size = new System.Drawing.Size(280, 39);
            this.button_Zaladuj.TabIndex = 30;
            this.button_Zaladuj.Text = "Załaduj XML";
            this.button_Zaladuj.UseVisualStyleBackColor = true;
            this.button_Zaladuj.Click += new System.EventHandler(this.button_Zaladuj_Click);
            // 
            // textBox_ilosc
            // 
            this.textBox_ilosc.Location = new System.Drawing.Point(960, 235);
            this.textBox_ilosc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ilosc.Name = "textBox_ilosc";
            this.textBox_ilosc.Size = new System.Drawing.Size(179, 22);
            this.textBox_ilosc.TabIndex = 13;
            // 
            // label_ilosc
            // 
            this.label_ilosc.AutoSize = true;
            this.label_ilosc.Location = new System.Drawing.Point(856, 244);
            this.label_ilosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ilosc.Name = "label_ilosc";
            this.label_ilosc.Size = new System.Drawing.Size(36, 17);
            this.label_ilosc.TabIndex = 31;
            this.label_ilosc.Text = "ilosc";
            // 
            // Btn_Zamowienia
            // 
            this.Btn_Zamowienia.Location = new System.Drawing.Point(12, 218);
            this.Btn_Zamowienia.Name = "Btn_Zamowienia";
            this.Btn_Zamowienia.Size = new System.Drawing.Size(147, 50);
            this.Btn_Zamowienia.TabIndex = 33;
            this.Btn_Zamowienia.Text = "Zamówienia";
            this.Btn_Zamowienia.UseVisualStyleBackColor = true;
            this.Btn_Zamowienia.Click += new System.EventHandler(this.Btn_Zamowienia_Click);
            // 
            // Btn_Magazyn
            // 
            this.Btn_Magazyn.Location = new System.Drawing.Point(12, 164);
            this.Btn_Magazyn.Name = "Btn_Magazyn";
            this.Btn_Magazyn.Size = new System.Drawing.Size(147, 50);
            this.Btn_Magazyn.TabIndex = 34;
            this.Btn_Magazyn.Text = "Magazyn";
            this.Btn_Magazyn.UseVisualStyleBackColor = true;
            this.Btn_Magazyn.Click += new System.EventHandler(this.Btn_Magazyn_Click);
            // 
            // panel_Magazyn
            // 
            this.panel_Magazyn.Controls.Add(this.label6);
            this.panel_Magazyn.Location = new System.Drawing.Point(173, 12);
            this.panel_Magazyn.Name = "panel_Magazyn";
            this.panel_Magazyn.Size = new System.Drawing.Size(1024, 707);
            this.panel_Magazyn.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "MAGAZYN";
            // 
            // panel_Zamowienia
            // 
            this.panel_Zamowienia.Controls.Add(this.label13);
            this.panel_Zamowienia.Location = new System.Drawing.Point(173, 12);
            this.panel_Zamowienia.Name = "panel_Zamowienia";
            this.panel_Zamowienia.Size = new System.Drawing.Size(1024, 707);
            this.panel_Zamowienia.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "ZAMOWIENIA";
            // 
            // Btn_Dostawa
            // 
            this.Btn_Dostawa.Location = new System.Drawing.Point(12, 112);
            this.Btn_Dostawa.Name = "Btn_Dostawa";
            this.Btn_Dostawa.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawa.TabIndex = 37;
            this.Btn_Dostawa.Text = "Dostawa";
            this.Btn_Dostawa.UseVisualStyleBackColor = true;
            this.Btn_Dostawa.Click += new System.EventHandler(this.Btn_Dostawa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 39;
            this.button1.Text = "EMPTY 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 50);
            this.button2.TabIndex = 38;
            this.button2.Text = "EMPTY 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Dostawa);
            this.Controls.Add(this.Btn_Magazyn);
            this.Controls.Add(this.Btn_Zamowienia);
            this.Controls.Add(this.textBox_ilosc);
            this.Controls.Add(this.label_ilosc);
            this.Controls.Add(this.button_Zaladuj);
            this.Controls.Add(this.button_ZapiszXML);
            this.Controls.Add(this.textBox2_Miasto);
            this.Controls.Add(this.textBox2_Kod);
            this.Controls.Add(this.textBox2_Adres);
            this.Controls.Add(this.textBox2_NIP);
            this.Controls.Add(this.textBox2_Nazwa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Usun);
            this.Controls.Add(this.button_Edytuj);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.textBox_Brutto);
            this.Controls.Add(this.textBox_VAT);
            this.Controls.Add(this.textBox_Netto);
            this.Controls.Add(this.textBox_Nazwa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_loadXML);
            this.Controls.Add(this.panel_Zamowienia);
            this.Controls.Add(this.panel_Magazyn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Magazyn.ResumeLayout(false);
            this.panel_Magazyn.PerformLayout();
            this.panel_Zamowienia.ResumeLayout(false);
            this.panel_Zamowienia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_loadXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nazwa;
        private System.Windows.Forms.TextBox textBox_Netto;
        private System.Windows.Forms.TextBox textBox_VAT;
        private System.Windows.Forms.TextBox textBox_Brutto;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.Button button_Edytuj;
        private System.Windows.Forms.Button button_Usun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2_Miasto;
        private System.Windows.Forms.TextBox textBox2_Kod;
        private System.Windows.Forms.TextBox textBox2_Adres;
        private System.Windows.Forms.TextBox textBox2_NIP;
        private System.Windows.Forms.TextBox textBox2_Nazwa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_ZapiszXML;
        private System.Windows.Forms.Button button_Zaladuj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartosc_calk_netto;
        private System.Windows.Forms.TextBox textBox_ilosc;
        private System.Windows.Forms.Label label_ilosc;
        private System.Windows.Forms.Button Btn_Zamowienia;
        private System.Windows.Forms.Button Btn_Magazyn;
        private System.Windows.Forms.Panel panel_Magazyn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Zamowienia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_Dostawa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

