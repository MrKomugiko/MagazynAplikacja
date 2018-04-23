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
            this.btn_loadXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_loadXML
            // 
            this.btn_loadXML.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_loadXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_loadXML.Location = new System.Drawing.Point(88, 56);
            this.btn_loadXML.Name = "btn_loadXML";
            this.btn_loadXML.Size = new System.Drawing.Size(100, 50);
            this.btn_loadXML.TabIndex = 0;
            this.btn_loadXML.Text = "Load XML";
            this.btn_loadXML.UseVisualStyleBackColor = true;
            this.btn_loadXML.Click += new System.EventHandler(this.btn_loadXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_loadXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadXML;
    }
}

