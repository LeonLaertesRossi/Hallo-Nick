namespace K8U4_IntergerCalcOOP_Nick
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
            this.labelZahl1 = new System.Windows.Forms.Label();
            this.labelZahl2 = new System.Windows.Forms.Label();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubtraktion = new System.Windows.Forms.Button();
            this.buttonMultiplikation = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonModulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelZahl1
            // 
            this.labelZahl1.AutoSize = true;
            this.labelZahl1.Location = new System.Drawing.Point(164, 86);
            this.labelZahl1.Name = "labelZahl1";
            this.labelZahl1.Size = new System.Drawing.Size(46, 16);
            this.labelZahl1.TabIndex = 0;
            this.labelZahl1.Text = "Zahl 1:";
            // 
            // labelZahl2
            // 
            this.labelZahl2.AutoSize = true;
            this.labelZahl2.Location = new System.Drawing.Point(164, 125);
            this.labelZahl2.Name = "labelZahl2";
            this.labelZahl2.Size = new System.Drawing.Size(40, 16);
            this.labelZahl2.TabIndex = 2;
            this.labelZahl2.Text = "Zahl2";
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(164, 178);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(64, 16);
            this.labelErgebnis.TabIndex = 4;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(277, 86);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl1.TabIndex = 5;
            this.textBoxZahl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContentTestZahl1);
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(277, 125);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl2.TabIndex = 7;
            this.textBoxZahl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContentTestZahl2);
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Enabled = false;
            this.textBoxErgebnis.Location = new System.Drawing.Point(277, 178);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(100, 22);
            this.textBoxErgebnis.TabIndex = 9;
            // 
            // buttonAddition
            // 
            this.buttonAddition.Location = new System.Drawing.Point(437, 86);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(75, 23);
            this.buttonAddition.TabIndex = 10;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.button_click_Addition);
            // 
            // buttonSubtraktion
            // 
            this.buttonSubtraktion.Location = new System.Drawing.Point(542, 86);
            this.buttonSubtraktion.Name = "buttonSubtraktion";
            this.buttonSubtraktion.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtraktion.TabIndex = 11;
            this.buttonSubtraktion.Text = "-";
            this.buttonSubtraktion.UseVisualStyleBackColor = true;
            this.buttonSubtraktion.Click += new System.EventHandler(this.button_click_Subtraktion);
            // 
            // buttonMultiplikation
            // 
            this.buttonMultiplikation.Location = new System.Drawing.Point(437, 125);
            this.buttonMultiplikation.Name = "buttonMultiplikation";
            this.buttonMultiplikation.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplikation.TabIndex = 12;
            this.buttonMultiplikation.Text = "*";
            this.buttonMultiplikation.UseVisualStyleBackColor = true;
            this.buttonMultiplikation.Click += new System.EventHandler(this.button_click_Multiplikation);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(437, 175);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 13;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.button_click_Division);
            // 
            // buttonModulo
            // 
            this.buttonModulo.Location = new System.Drawing.Point(542, 178);
            this.buttonModulo.Name = "buttonModulo";
            this.buttonModulo.Size = new System.Drawing.Size(75, 23);
            this.buttonModulo.TabIndex = 14;
            this.buttonModulo.Text = "%";
            this.buttonModulo.UseVisualStyleBackColor = true;
            this.buttonModulo.Click += new System.EventHandler(this.button_click_Modulo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModulo);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplikation);
            this.Controls.Add(this.buttonSubtraktion);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.labelZahl2);
            this.Controls.Add(this.labelZahl1);
            this.Name = "Form1";
            this.Text = "Ganzzahl-Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZahl1;
        private System.Windows.Forms.Label labelZahl2;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubtraktion;
        private System.Windows.Forms.Button buttonMultiplikation;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonModulo;
    }
}

//K8U4_IntergerCalcOOP_Nick