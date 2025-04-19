namespace Esercizio_22._11
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCalcolaDifferenza = new System.Windows.Forms.Button();
            this.lblRisultatoDifferenza = new System.Windows.Forms.Label();
            this.dateTimePickerSomma = new System.Windows.Forms.DateTimePicker();
            this.txtGiorni = new System.Windows.Forms.TextBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.lblRisultatoSomma = new System.Windows.Forms.Label();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(66, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnCalcolaDifferenza
            // 
            this.btnCalcolaDifferenza.Location = new System.Drawing.Point(301, 90);
            this.btnCalcolaDifferenza.Name = "btnCalcolaDifferenza";
            this.btnCalcolaDifferenza.Size = new System.Drawing.Size(123, 23);
            this.btnCalcolaDifferenza.TabIndex = 2;
            this.btnCalcolaDifferenza.Text = "Calcola Differenza";
            this.btnCalcolaDifferenza.UseVisualStyleBackColor = true;
            this.btnCalcolaDifferenza.Click += new System.EventHandler(this.btnCalcolaDifferenza_Click);
            // 
            // lblRisultatoDifferenza
            // 
            this.lblRisultatoDifferenza.AutoSize = true;
            this.lblRisultatoDifferenza.Location = new System.Drawing.Point(442, 100);
            this.lblRisultatoDifferenza.Name = "lblRisultatoDifferenza";
            this.lblRisultatoDifferenza.Size = new System.Drawing.Size(48, 13);
            this.lblRisultatoDifferenza.TabIndex = 3;
            this.lblRisultatoDifferenza.Text = "Risultato";
            // 
            // dateTimePickerSomma
            // 
            this.dateTimePickerSomma.Location = new System.Drawing.Point(45, 219);
            this.dateTimePickerSomma.Name = "dateTimePickerSomma";
            this.dateTimePickerSomma.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSomma.TabIndex = 4;
            // 
            // txtGiorni
            // 
            this.txtGiorni.Location = new System.Drawing.Point(290, 219);
            this.txtGiorni.Name = "txtGiorni";
            this.txtGiorni.Size = new System.Drawing.Size(100, 20);
            this.txtGiorni.TabIndex = 5;
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(445, 217);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 23);
            this.btnSomma.TabIndex = 6;
            this.btnSomma.Text = "Somma";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // lblRisultatoSomma
            // 
            this.lblRisultatoSomma.AutoSize = true;
            this.lblRisultatoSomma.Location = new System.Drawing.Point(553, 240);
            this.lblRisultatoSomma.Name = "lblRisultatoSomma";
            this.lblRisultatoSomma.Size = new System.Drawing.Size(43, 13);
            this.lblRisultatoSomma.TabIndex = 7;
            this.lblRisultatoSomma.Text = "risultato";
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Location = new System.Drawing.Point(445, 254);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(75, 23);
            this.btnSottrazione.TabIndex = 8;
            this.btnSottrazione.Text = "Sottrai";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.btnSottrazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.lblRisultatoSomma);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.txtGiorni);
            this.Controls.Add(this.dateTimePickerSomma);
            this.Controls.Add(this.lblRisultatoDifferenza);
            this.Controls.Add(this.btnCalcolaDifferenza);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnCalcolaDifferenza;
        private System.Windows.Forms.Label lblRisultatoDifferenza;
        private System.Windows.Forms.DateTimePicker dateTimePickerSomma;
        private System.Windows.Forms.TextBox txtGiorni;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Label lblRisultatoSomma;
        private System.Windows.Forms.Button btnSottrazione;
    }
}

