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
            this.SuspendLayout();
            // 
            // Btn_loadXML
            // 
            this.Btn_loadXML.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_loadXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_loadXML.Location = new System.Drawing.Point(36, 191);
            this.Btn_loadXML.Name = "Btn_loadXML";
            this.Btn_loadXML.Size = new System.Drawing.Size(197, 50);
            this.Btn_loadXML.TabIndex = 0;
            this.Btn_loadXML.Text = "Załaduj Dostawców z XML";
            this.Btn_loadXML.UseVisualStyleBackColor = true;
            this.Btn_loadXML.Click += new System.EventHandler(this.Btn_loadXML_Click);
            // 
            // label_Dostawcy
            // 
            this.label_Dostawcy.AutoSize = true;
            this.label_Dostawcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Dostawcy.Location = new System.Drawing.Point(12, 9);
            this.label_Dostawcy.Name = "label_Dostawcy";
            this.label_Dostawcy.Size = new System.Drawing.Size(131, 29);
            this.label_Dostawcy.TabIndex = 1;
            this.label_Dostawcy.Text = "Dostawcy";
            // 
            // label_WynikDostawcy
            // 
            this.label_WynikDostawcy.AutoSize = true;
            this.label_WynikDostawcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_WynikDostawcy.Location = new System.Drawing.Point(15, 38);
            this.label_WynikDostawcy.Name = "label_WynikDostawcy";
            this.label_WynikDostawcy.Size = new System.Drawing.Size(37, 25);
            this.label_WynikDostawcy.TabIndex = 2;
            this.label_WynikDostawcy.Text = ". . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label_WynikDostawcy);
            this.Controls.Add(this.label_Dostawcy);
            this.Controls.Add(this.Btn_loadXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_loadXML;
        private System.Windows.Forms.Label label_Dostawcy;
        private System.Windows.Forms.Label label_WynikDostawcy;
    }
}

