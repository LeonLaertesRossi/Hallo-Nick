namespace K10U3_Autofahren_nick_v1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFahren = new System.Windows.Forms.Button();
            this.buttonLangsamer = new System.Windows.Forms.Button();
            this.buttonSchneller = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.auto1 = new K10U3_Autofahren_nick_v1.Auto();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.auto1);
            this.panel1.Location = new System.Drawing.Point(154, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 60);
            this.panel1.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(81, 256);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFahren
            // 
            this.buttonFahren.Location = new System.Drawing.Point(190, 256);
            this.buttonFahren.Name = "buttonFahren";
            this.buttonFahren.Size = new System.Drawing.Size(75, 23);
            this.buttonFahren.TabIndex = 3;
            this.buttonFahren.Text = "Fahren";
            this.buttonFahren.UseVisualStyleBackColor = true;
            this.buttonFahren.Click += new System.EventHandler(this.buttonFahren_Click);
            // 
            // buttonLangsamer
            // 
            this.buttonLangsamer.Location = new System.Drawing.Point(292, 256);
            this.buttonLangsamer.Name = "buttonLangsamer";
            this.buttonLangsamer.Size = new System.Drawing.Size(86, 23);
            this.buttonLangsamer.TabIndex = 4;
            this.buttonLangsamer.Text = "Langsamer";
            this.buttonLangsamer.UseVisualStyleBackColor = true;
            this.buttonLangsamer.Click += new System.EventHandler(this.buttonLangsamer_Click);
            // 
            // buttonSchneller
            // 
            this.buttonSchneller.Location = new System.Drawing.Point(414, 256);
            this.buttonSchneller.Name = "buttonSchneller";
            this.buttonSchneller.Size = new System.Drawing.Size(75, 23);
            this.buttonSchneller.TabIndex = 5;
            this.buttonSchneller.Text = "Schneller";
            this.buttonSchneller.UseVisualStyleBackColor = true;
            this.buttonSchneller.Click += new System.EventHandler(this.buttonSchneller_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(540, 256);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 6;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Geschwindigkeit: 0 km/h";
            // 
            // auto1
            // 
            this.auto1.Geschwindigkeit = 0;
            this.auto1.Location = new System.Drawing.Point(0, 37);
            this.auto1.Name = "auto1";
            this.auto1.Size = new System.Drawing.Size(75, 23);
            this.auto1.TabIndex = 0;
            this.auto1.Text = "auto1";
            this.auto1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonSchneller);
            this.Controls.Add(this.buttonLangsamer);
            this.Controls.Add(this.buttonFahren);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFahren;
        private System.Windows.Forms.Button buttonLangsamer;
        private System.Windows.Forms.Button buttonSchneller;
        private System.Windows.Forms.Button buttonBeenden;
        private Auto auto1;
        private System.Windows.Forms.Label label1;
    }
}

