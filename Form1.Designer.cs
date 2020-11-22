namespace WA_Tipotriangolo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_richiesta = new System.Windows.Forms.TextBox();
            this.btn_esegui = new System.Windows.Forms.Button();
            this.txt_primo = new System.Windows.Forms.TextBox();
            this.txt_terzo = new System.Windows.Forms.TextBox();
            this.txt_secondo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_risultato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_richiesta
            // 
            this.txt_richiesta.Location = new System.Drawing.Point(12, 28);
            this.txt_richiesta.Multiline = true;
            this.txt_richiesta.Name = "txt_richiesta";
            this.txt_richiesta.Size = new System.Drawing.Size(280, 51);
            this.txt_richiesta.TabIndex = 0;
            this.txt_richiesta.Text = "Scrivere un programma che, lette le misure dei lati di un triangolo, visualizzi s" +
    "e il triangolo è equilatero, isoscele o scaleno";
            // 
            // btn_esegui
            // 
            this.btn_esegui.Location = new System.Drawing.Point(165, 220);
            this.btn_esegui.Name = "btn_esegui";
            this.btn_esegui.Size = new System.Drawing.Size(75, 23);
            this.btn_esegui.TabIndex = 1;
            this.btn_esegui.Text = "Esegui";
            this.btn_esegui.UseVisualStyleBackColor = true;
            this.btn_esegui.Click += new System.EventHandler(this.btn_esegui_Click);
            // 
            // txt_primo
            // 
            this.txt_primo.Location = new System.Drawing.Point(12, 119);
            this.txt_primo.Name = "txt_primo";
            this.txt_primo.Size = new System.Drawing.Size(100, 20);
            this.txt_primo.TabIndex = 2;
            // 
            // txt_terzo
            // 
            this.txt_terzo.Location = new System.Drawing.Point(12, 171);
            this.txt_terzo.Name = "txt_terzo";
            this.txt_terzo.Size = new System.Drawing.Size(100, 20);
            this.txt_terzo.TabIndex = 3;
            // 
            // txt_secondo
            // 
            this.txt_secondo.Location = new System.Drawing.Point(12, 145);
            this.txt_secondo.Name = "txt_secondo";
            this.txt_secondo.Size = new System.Drawing.Size(100, 20);
            this.txt_secondo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Primo lato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Secondo lato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Terzo lato";
            // 
            // txt_risultato
            // 
            this.txt_risultato.Location = new System.Drawing.Point(12, 277);
            this.txt_risultato.Name = "txt_risultato";
            this.txt_risultato.ReadOnly = true;
            this.txt_risultato.Size = new System.Drawing.Size(100, 20);
            this.txt_risultato.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Risulatato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_risultato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_secondo);
            this.Controls.Add(this.txt_terzo);
            this.Controls.Add(this.txt_primo);
            this.Controls.Add(this.btn_esegui);
            this.Controls.Add(this.txt_richiesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_richiesta;
        private System.Windows.Forms.Button btn_esegui;
        private System.Windows.Forms.TextBox txt_primo;
        private System.Windows.Forms.TextBox txt_terzo;
        private System.Windows.Forms.TextBox txt_secondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_risultato;
        private System.Windows.Forms.Label label4;
    }
}

