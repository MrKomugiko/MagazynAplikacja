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
            this.components = new System.ComponentModel.Container();
            this.Btn_loadXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Nazwa = new System.Windows.Forms.TextBox();
            this.textBox_Netto = new System.Windows.Forms.TextBox();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Edytuj = new System.Windows.Forms.Button();
            this.button_Usun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRUTTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartosc_calk_brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2_Miasto = new System.Windows.Forms.TextBox();
            this.textBox2_Kod = new System.Windows.Forms.TextBox();
            this.textBox2_Adres = new System.Windows.Forms.TextBox();
            this.textBox2_NIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_ZapiszXML = new System.Windows.Forms.Button();
            this.button_Zaladuj = new System.Windows.Forms.Button();
            this.Btn_Zamowienia = new System.Windows.Forms.Button();
            this.Btn_Magazyn = new System.Windows.Forms.Button();
            this.panel_Magazyn = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Zamowienia = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_Dostawa = new System.Windows.Forms.Button();
            this.Btn_Dostawa2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Dostawa_Main = new System.Windows.Forms.Panel();
            this.Btn_Dostawca_Export = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Btn_Dostawca_Import = new System.Windows.Forms.Button();
            this.Btn_Dostawca_Edit = new System.Windows.Forms.Button();
            this.Btn_Dostawca_New = new System.Windows.Forms.Button();
            this.Btn_Dostawca_Select = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox_ilosc = new System.Windows.Forms.TextBox();
            this.textBox_VAT = new System.Windows.Forms.TextBox();
            this.textBox2_Nazwa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontrahentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaskroconaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miejscowoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Magazyn.SuspendLayout();
            this.panel_Zamowienia.SuspendLayout();
            this.panel_Dostawa_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).BeginInit();
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
            this.Wartosc_calk_brutto});
            this.dataGridView1.Location = new System.Drawing.Point(180, 378);
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
            // Wartosc_calk_brutto
            // 
            this.Wartosc_calk_brutto.HeaderText = "Wartosc calk netto";
            this.Wartosc_calk_brutto.Name = "Wartosc_calk_brutto";
            this.Wartosc_calk_brutto.ReadOnly = true;
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
            // Btn_Zamowienia
            // 
            this.Btn_Zamowienia.Location = new System.Drawing.Point(12, 218);
            this.Btn_Zamowienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Btn_Magazyn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel_Magazyn.Location = new System.Drawing.Point(177, 9);
            this.panel_Magazyn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Magazyn.Name = "panel_Magazyn";
            this.panel_Magazyn.Size = new System.Drawing.Size(1017, 706);
            this.panel_Magazyn.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "MAGAZYN";
            // 
            // panel_Zamowienia
            // 
            this.panel_Zamowienia.Controls.Add(this.label13);
            this.panel_Zamowienia.Location = new System.Drawing.Point(177, 9);
            this.panel_Zamowienia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Zamowienia.Name = "panel_Zamowienia";
            this.panel_Zamowienia.Size = new System.Drawing.Size(1017, 706);
            this.panel_Zamowienia.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "ZAMOWIENIA";
            // 
            // Btn_Dostawa
            // 
            this.Btn_Dostawa.Location = new System.Drawing.Point(12, 112);
            this.Btn_Dostawa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawa.Name = "Btn_Dostawa";
            this.Btn_Dostawa.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawa.TabIndex = 37;
            this.Btn_Dostawa.Text = "Dostawa";
            this.Btn_Dostawa.UseVisualStyleBackColor = true;
            this.Btn_Dostawa.Click += new System.EventHandler(this.Btn_Dostawa_Click);
            // 
            // Btn_Dostawa2
            // 
            this.Btn_Dostawa2.Location = new System.Drawing.Point(12, 9);
            this.Btn_Dostawa2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawa2.Name = "Btn_Dostawa2";
            this.Btn_Dostawa2.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawa2.TabIndex = 39;
            this.Btn_Dostawa2.Text = "Dostawa NEW";
            this.Btn_Dostawa2.UseVisualStyleBackColor = true;
            this.Btn_Dostawa2.Click += new System.EventHandler(this.Btn_Dostawa2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 50);
            this.button2.TabIndex = 38;
            this.button2.Text = "EMPTY 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel_Dostawa_Main
            // 
            this.panel_Dostawa_Main.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Dostawa_Main.Controls.Add(this.Btn_Dostawca_Export);
            this.panel_Dostawa_Main.Controls.Add(this.button8);
            this.panel_Dostawa_Main.Controls.Add(this.button7);
            this.panel_Dostawa_Main.Controls.Add(this.Btn_Dostawca_Import);
            this.panel_Dostawa_Main.Controls.Add(this.Btn_Dostawca_Edit);
            this.panel_Dostawa_Main.Controls.Add(this.Btn_Dostawca_New);
            this.panel_Dostawa_Main.Controls.Add(this.Btn_Dostawca_Select);
            this.panel_Dostawa_Main.Controls.Add(this.label14);
            this.panel_Dostawa_Main.Controls.Add(this.dataGridView2);
            this.panel_Dostawa_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel_Dostawa_Main.Location = new System.Drawing.Point(180, 11);
            this.panel_Dostawa_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Dostawa_Main.Name = "panel_Dostawa_Main";
            this.panel_Dostawa_Main.Size = new System.Drawing.Size(1017, 704);
            this.panel_Dostawa_Main.TabIndex = 1;
            // 
            // Btn_Dostawca_Export
            // 
            this.Btn_Dostawca_Export.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dostawca_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Dostawca_Export.Location = new System.Drawing.Point(805, 17);
            this.Btn_Dostawca_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawca_Export.Name = "Btn_Dostawca_Export";
            this.Btn_Dostawca_Export.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawca_Export.TabIndex = 47;
            this.Btn_Dostawca_Export.Text = "EXPORT";
            this.Btn_Dostawca_Export.UseVisualStyleBackColor = false;
            this.Btn_Dostawca_Export.Click += new System.EventHandler(this.Btn_Dostawca_Export_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(859, 642);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 50);
            this.button8.TabIndex = 45;
            this.button8.Text = "NEXT";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(13, 642);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 50);
            this.button7.TabIndex = 44;
            this.button7.Text = "BACK";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Btn_Dostawca_Import
            // 
            this.Btn_Dostawca_Import.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dostawca_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Dostawca_Import.Location = new System.Drawing.Point(73, 17);
            this.Btn_Dostawca_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawca_Import.Name = "Btn_Dostawca_Import";
            this.Btn_Dostawca_Import.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawca_Import.TabIndex = 40;
            this.Btn_Dostawca_Import.Text = "IMPORT";
            this.Btn_Dostawca_Import.UseVisualStyleBackColor = false;
            this.Btn_Dostawca_Import.Click += new System.EventHandler(this.Btn_Dostawca_Import_Click);
            // 
            // Btn_Dostawca_Edit
            // 
            this.Btn_Dostawca_Edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dostawca_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Dostawca_Edit.Location = new System.Drawing.Point(439, 17);
            this.Btn_Dostawca_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawca_Edit.Name = "Btn_Dostawca_Edit";
            this.Btn_Dostawca_Edit.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawca_Edit.TabIndex = 42;
            this.Btn_Dostawca_Edit.Text = "EDIT";
            this.Btn_Dostawca_Edit.UseVisualStyleBackColor = false;
            // 
            // Btn_Dostawca_New
            // 
            this.Btn_Dostawca_New.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dostawca_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Dostawca_New.Location = new System.Drawing.Point(621, 17);
            this.Btn_Dostawca_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawca_New.Name = "Btn_Dostawca_New";
            this.Btn_Dostawca_New.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawca_New.TabIndex = 43;
            this.Btn_Dostawca_New.Text = "NEW";
            this.Btn_Dostawca_New.UseVisualStyleBackColor = false;
            this.Btn_Dostawca_New.Click += new System.EventHandler(this.Btn_Dostawca_New_Click);
            // 
            // Btn_Dostawca_Select
            // 
            this.Btn_Dostawca_Select.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Dostawca_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn_Dostawca_Select.Location = new System.Drawing.Point(256, 17);
            this.Btn_Dostawca_Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Dostawca_Select.Name = "Btn_Dostawca_Select";
            this.Btn_Dostawca_Select.Size = new System.Drawing.Size(147, 50);
            this.Btn_Dostawca_Select.TabIndex = 41;
            this.Btn_Dostawca_Select.Text = "SELECT";
            this.Btn_Dostawca_Select.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(901, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 29);
            this.label14.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kontrahentDataGridViewTextBoxColumn,
            this.nazwaskroconaDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.miejscowoscDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.grupaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dostawcyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 78);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(993, 560);
            this.dataGridView2.TabIndex = 46;
            // 
            // textBox_ilosc
            // 
            this.textBox_ilosc.Location = new System.Drawing.Point(959, 195);
            this.textBox_ilosc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ilosc.Name = "textBox_ilosc";
            this.textBox_ilosc.Size = new System.Drawing.Size(179, 22);
            this.textBox_ilosc.TabIndex = 41;
            // 
            // textBox_VAT
            // 
            this.textBox_VAT.Location = new System.Drawing.Point(959, 159);
            this.textBox_VAT.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_VAT.Name = "textBox_VAT";
            this.textBox_VAT.Size = new System.Drawing.Size(179, 22);
            this.textBox_VAT.TabIndex = 40;
            // 
            // textBox2_Nazwa
            // 
            this.textBox2_Nazwa.Location = new System.Drawing.Point(669, 80);
            this.textBox2_Nazwa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Nazwa.Name = "textBox2_Nazwa";
            this.textBox2_Nazwa.Size = new System.Drawing.Size(179, 22);
            this.textBox2_Nazwa.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(855, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ilosc";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 64;
            // 
            // kontrahentDataGridViewTextBoxColumn
            // 
            this.kontrahentDataGridViewTextBoxColumn.DataPropertyName = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.HeaderText = "Kontrahent";
            this.kontrahentDataGridViewTextBoxColumn.Name = "kontrahentDataGridViewTextBoxColumn";
            this.kontrahentDataGridViewTextBoxColumn.Width = 175;
            // 
            // nazwaskroconaDataGridViewTextBoxColumn
            // 
            this.nazwaskroconaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_skrocona";
            this.nazwaskroconaDataGridViewTextBoxColumn.HeaderText = "Nazwa_skrocona";
            this.nazwaskroconaDataGridViewTextBoxColumn.Name = "nazwaskroconaDataGridViewTextBoxColumn";
            this.nazwaskroconaDataGridViewTextBoxColumn.Width = 250;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.Width = 86;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 127;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            this.miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            this.miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            this.miejscowoscDataGridViewTextBoxColumn.Width = 198;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.Width = 90;
            // 
            // grupaDataGridViewTextBoxColumn
            // 
            this.grupaDataGridViewTextBoxColumn.DataPropertyName = "Grupa";
            this.grupaDataGridViewTextBoxColumn.HeaderText = "Grupa";
            this.grupaDataGridViewTextBoxColumn.Name = "grupaDataGridViewTextBoxColumn";
            this.grupaDataGridViewTextBoxColumn.Width = 116;
            // 
            // dostawcyBindingSource
            // 
            this.dostawcyBindingSource.DataSource = typeof(MagazynAplikacja.Dostawcy);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 732);
            this.Controls.Add(this.panel_Zamowienia);
            this.Controls.Add(this.textBox_VAT);
            this.Controls.Add(this.Btn_Dostawa2);
            this.Controls.Add(this.textBox2_Nazwa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Magazyn);
            this.Controls.Add(this.Btn_Zamowienia);
            this.Controls.Add(this.button_Zaladuj);
            this.Controls.Add(this.button_ZapiszXML);
            this.Controls.Add(this.textBox2_Miasto);
            this.Controls.Add(this.textBox2_Kod);
            this.Controls.Add(this.textBox2_Adres);
            this.Controls.Add(this.textBox2_NIP);
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
            this.Controls.Add(this.textBox_Netto);
            this.Controls.Add(this.textBox_Nazwa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_loadXML);
            this.Controls.Add(this.Btn_Dostawa);
            this.Controls.Add(this.textBox_ilosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_Magazyn);
            this.Controls.Add(this.panel_Dostawa_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Magazyn.ResumeLayout(false);
            this.panel_Magazyn.PerformLayout();
            this.panel_Zamowienia.ResumeLayout(false);
            this.panel_Zamowienia.PerformLayout();
            this.panel_Dostawa_Main.ResumeLayout(false);
            this.panel_Dostawa_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_loadXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Nazwa;
        private System.Windows.Forms.TextBox textBox_Netto;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.Button button_Edytuj;
        private System.Windows.Forms.Button button_Usun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2_Miasto;
        private System.Windows.Forms.TextBox textBox2_Kod;
        private System.Windows.Forms.TextBox textBox2_Adres;
        private System.Windows.Forms.TextBox textBox2_NIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_ZapiszXML;
        private System.Windows.Forms.Button button_Zaladuj;
        private System.Windows.Forms.Button Btn_Zamowienia;
        private System.Windows.Forms.Button Btn_Magazyn;
        private System.Windows.Forms.Panel panel_Magazyn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Zamowienia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_Dostawa;
        private System.Windows.Forms.Button Btn_Dostawa2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_Dostawa_Main;
        private System.Windows.Forms.Button Btn_Dostawca_Import;
        private System.Windows.Forms.Button Btn_Dostawca_Edit;
        private System.Windows.Forms.Button Btn_Dostawca_New;
        private System.Windows.Forms.Button Btn_Dostawca_Select;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Btn_Dostawca_Export;
        private System.Windows.Forms.BindingSource dostawcyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaskroconaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRUTTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartosc_calk_brutto;
        private System.Windows.Forms.TextBox textBox_ilosc;
        private System.Windows.Forms.TextBox textBox_VAT;
        private System.Windows.Forms.TextBox textBox2_Nazwa;
        private System.Windows.Forms.Label label5;
    }
}

