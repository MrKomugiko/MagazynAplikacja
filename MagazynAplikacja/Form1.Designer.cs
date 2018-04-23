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
            this.label_Dostawcy = new System.Windows.Forms.Label();
            this.label_WynikDostawcy = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_loadXML
            // 
            this.Btn_loadXML.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_loadXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_loadXML.Location = new System.Drawing.Point(27, 155);
            this.Btn_loadXML.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_loadXML.Name = "Btn_loadXML";
            this.Btn_loadXML.Size = new System.Drawing.Size(148, 41);
            this.Btn_loadXML.TabIndex = 0;
            this.Btn_loadXML.Text = "Załaduj Dostawców z XML";
            this.Btn_loadXML.UseVisualStyleBackColor = true;
            this.Btn_loadXML.Click += new System.EventHandler(this.Btn_loadXML_Click);
            // 
            // label_Dostawcy
            // 
            this.label_Dostawcy.AutoSize = true;
            this.label_Dostawcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Dostawcy.Location = new System.Drawing.Point(9, 7);
            this.label_Dostawcy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Dostawcy.Name = "label_Dostawcy";
            this.label_Dostawcy.Size = new System.Drawing.Size(105, 25);
            this.label_Dostawcy.TabIndex = 1;
            this.label_Dostawcy.Text = "Dostawcy";
            // 
            // label_WynikDostawcy
            // 
            this.label_WynikDostawcy.AutoSize = true;
            this.label_WynikDostawcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_WynikDostawcy.Location = new System.Drawing.Point(11, 31);
            this.label_WynikDostawcy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WynikDostawcy.Name = "label_WynikDostawcy";
            this.label_WynikDostawcy.Size = new System.Drawing.Size(29, 20);
            this.label_WynikDostawcy.TabIndex = 2;
            this.label_WynikDostawcy.Text = ". . .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(675, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produkty";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cena brutto";
            // 
            // textBox_Nazwa
            // 
            this.textBox_Nazwa.Location = new System.Drawing.Point(719, 65);
            this.textBox_Nazwa.Name = "textBox_Nazwa";
            this.textBox_Nazwa.Size = new System.Drawing.Size(135, 20);
            this.textBox_Nazwa.TabIndex = 9;
            // 
            // textBox_Netto
            // 
            this.textBox_Netto.Location = new System.Drawing.Point(719, 96);
            this.textBox_Netto.Name = "textBox_Netto";
            this.textBox_Netto.Size = new System.Drawing.Size(135, 20);
            this.textBox_Netto.TabIndex = 10;
            // 
            // textBox_VAT
            // 
            this.textBox_VAT.Location = new System.Drawing.Point(719, 129);
            this.textBox_VAT.Name = "textBox_VAT";
            this.textBox_VAT.Size = new System.Drawing.Size(135, 20);
            this.textBox_VAT.TabIndex = 11;
            // 
            // textBox_Brutto
            // 
            this.textBox_Brutto.Location = new System.Drawing.Point(719, 160);
            this.textBox_Brutto.Name = "textBox_Brutto";
            this.textBox_Brutto.Size = new System.Drawing.Size(135, 20);
            this.textBox_Brutto.TabIndex = 12;
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(461, 222);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(110, 41);
            this.button_Dodaj.TabIndex = 14;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Edytuj
            // 
            this.button_Edytuj.Location = new System.Drawing.Point(589, 222);
            this.button_Edytuj.Name = "button_Edytuj";
            this.button_Edytuj.Size = new System.Drawing.Size(110, 41);
            this.button_Edytuj.TabIndex = 15;
            this.button_Edytuj.Text = "Edytuj";
            this.button_Edytuj.UseVisualStyleBackColor = true;
            this.button_Edytuj.Click += new System.EventHandler(this.button_Edytuj_Click);
            // 
            // button_Usun
            // 
            this.button_Usun.Location = new System.Drawing.Point(719, 222);
            this.button_Usun.Name = "button_Usun";
            this.button_Usun.Size = new System.Drawing.Size(110, 41);
            this.button_Usun.TabIndex = 16;
            this.button_Usun.Text = "Usuń";
            this.button_Usun.UseVisualStyleBackColor = true;
            this.button_Usun.Click += new System.EventHandler(this.button_Usun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.Miasto,
            this.Adres,
            this.BRUTTO});
            this.dataGridView1.Location = new System.Drawing.Point(426, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 276);
            this.dataGridView1.TabIndex = 17;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(462, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dostawca";
            // 
            // textBox2_Miasto
            // 
            this.textBox2_Miasto.Location = new System.Drawing.Point(501, 191);
            this.textBox2_Miasto.Name = "textBox2_Miasto";
            this.textBox2_Miasto.Size = new System.Drawing.Size(135, 20);
            this.textBox2_Miasto.TabIndex = 28;
            // 
            // textBox2_Kod
            // 
            this.textBox2_Kod.Location = new System.Drawing.Point(501, 160);
            this.textBox2_Kod.Name = "textBox2_Kod";
            this.textBox2_Kod.Size = new System.Drawing.Size(135, 20);
            this.textBox2_Kod.TabIndex = 27;
            // 
            // textBox2_Adres
            // 
            this.textBox2_Adres.Location = new System.Drawing.Point(501, 129);
            this.textBox2_Adres.Name = "textBox2_Adres";
            this.textBox2_Adres.Size = new System.Drawing.Size(135, 20);
            this.textBox2_Adres.TabIndex = 26;
            // 
            // textBox2_NIP
            // 
            this.textBox2_NIP.Location = new System.Drawing.Point(501, 96);
            this.textBox2_NIP.Name = "textBox2_NIP";
            this.textBox2_NIP.Size = new System.Drawing.Size(135, 20);
            this.textBox2_NIP.TabIndex = 25;
            // 
            // textBox2_Nazwa
            // 
            this.textBox2_Nazwa.Location = new System.Drawing.Point(501, 65);
            this.textBox2_Nazwa.Name = "textBox2_Nazwa";
            this.textBox2_Nazwa.Size = new System.Drawing.Size(135, 20);
            this.textBox2_Nazwa.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Miasto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kod pocztowy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(423, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "NIP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nazwa";
            // 
            // button_ZapiszXML
            // 
            this.button_ZapiszXML.Location = new System.Drawing.Point(426, 269);
            this.button_ZapiszXML.Name = "button_ZapiszXML";
            this.button_ZapiszXML.Size = new System.Drawing.Size(210, 32);
            this.button_ZapiszXML.TabIndex = 29;
            this.button_ZapiszXML.Text = "Zapisz jako XML";
            this.button_ZapiszXML.UseVisualStyleBackColor = true;
            this.button_ZapiszXML.Click += new System.EventHandler(this.button_ZapiszXML_Click);
            // 
            // button_Zaladuj
            // 
            this.button_Zaladuj.Location = new System.Drawing.Point(644, 269);
            this.button_Zaladuj.Name = "button_Zaladuj";
            this.button_Zaladuj.Size = new System.Drawing.Size(210, 32);
            this.button_Zaladuj.TabIndex = 30;
            this.button_Zaladuj.Text = "Załaduj XML";
            this.button_Zaladuj.UseVisualStyleBackColor = true;
            this.button_Zaladuj.Click += new System.EventHandler(this.button_Zaladuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 595);
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
            this.Controls.Add(this.label_WynikDostawcy);
            this.Controls.Add(this.label_Dostawcy);
            this.Controls.Add(this.Btn_loadXML);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_loadXML;
        private System.Windows.Forms.Label label_Dostawcy;
        private System.Windows.Forms.Label label_WynikDostawcy;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRUTTO;
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
    }
}

