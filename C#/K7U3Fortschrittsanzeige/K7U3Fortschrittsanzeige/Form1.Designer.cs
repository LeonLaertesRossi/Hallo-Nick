namespace K7U3Fortschrittsanzeige
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProzent = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonZurücksetzen = new System.Windows.Forms.Button();
            this.buttonSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(187, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(349, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 0;
            // 
            // labelProzent
            // 
            this.labelProzent.AutoSize = true;
            this.labelProzent.Location = new System.Drawing.Point(184, 143);
            this.labelProzent.Name = "labelProzent";
            this.labelProzent.Size = new System.Drawing.Size(62, 16);
            this.labelProzent.TabIndex = 1;
            this.labelProzent.Text = "0 Prozent";
            this.labelProzent.Click += new System.EventHandler(this.labelProzent_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(187, 182);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonZurücksetzen
            // 
            this.buttonZurücksetzen.Location = new System.Drawing.Point(313, 182);
            this.buttonZurücksetzen.Name = "buttonZurücksetzen";
            this.buttonZurücksetzen.Size = new System.Drawing.Size(96, 23);
            this.buttonZurücksetzen.TabIndex = 3;
            this.buttonZurücksetzen.Text = "zurücksetzen";
            this.buttonZurücksetzen.UseVisualStyleBackColor = true;
            this.buttonZurücksetzen.Click += new System.EventHandler(this.buttonZurücksetzen_Click);
            // 
            // buttonSchließen
            // 
            this.buttonSchließen.Location = new System.Drawing.Point(461, 181);
            this.buttonSchließen.Name = "buttonSchließen";
            this.buttonSchließen.Size = new System.Drawing.Size(75, 23);
            this.buttonSchließen.TabIndex = 4;
            this.buttonSchließen.Text = "Schließen";
            this.buttonSchließen.UseVisualStyleBackColor = true;
            this.buttonSchließen.Click += new System.EventHandler(this.buttonSchließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSchließen);
            this.Controls.Add(this.buttonZurücksetzen);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelProzent);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Progressbar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProzent;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonZurücksetzen;
        private System.Windows.Forms.Button buttonSchließen;
    }
}

