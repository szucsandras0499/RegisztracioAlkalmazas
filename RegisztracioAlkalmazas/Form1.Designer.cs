namespace RegisztracioAlkalmazas
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
            this.textBoxnev = new System.Windows.Forms.TextBox();
            this.textBoxujhobbi = new System.Windows.Forms.TextBox();
            this.listBoxkedvenchobbi = new System.Windows.Forms.ListBox();
            this.nev = new System.Windows.Forms.Label();
            this.szuldatum = new System.Windows.Forms.Label();
            this.ujhobbi = new System.Windows.Forms.Label();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.nem = new System.Windows.Forms.Label();
            this.hozzaad = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.dateTimePickerszuldatum = new System.Windows.Forms.DateTimePicker();
            this.kedvenchobbi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxnev
            // 
            this.textBoxnev.Location = new System.Drawing.Point(213, 12);
            this.textBoxnev.Name = "textBoxnev";
            this.textBoxnev.Size = new System.Drawing.Size(100, 20);
            this.textBoxnev.TabIndex = 0;
            // 
            // textBoxujhobbi
            // 
            this.textBoxujhobbi.Location = new System.Drawing.Point(495, 158);
            this.textBoxujhobbi.Name = "textBoxujhobbi";
            this.textBoxujhobbi.Size = new System.Drawing.Size(100, 20);
            this.textBoxujhobbi.TabIndex = 2;
            // 
            // listBoxkedvenchobbi
            // 
            this.listBoxkedvenchobbi.FormattingEnabled = true;
            this.listBoxkedvenchobbi.Location = new System.Drawing.Point(489, 48);
            this.listBoxkedvenchobbi.Name = "listBoxkedvenchobbi";
            this.listBoxkedvenchobbi.Size = new System.Drawing.Size(106, 82);
            this.listBoxkedvenchobbi.TabIndex = 3;
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(124, 19);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 4;
            this.nev.Text = "Név:";
            // 
            // szuldatum
            // 
            this.szuldatum.AutoSize = true;
            this.szuldatum.Location = new System.Drawing.Point(124, 54);
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(65, 13);
            this.szuldatum.TabIndex = 5;
            this.szuldatum.Text = "Szül. dátum:";
            // 
            // ujhobbi
            // 
            this.ujhobbi.AutoSize = true;
            this.ujhobbi.Location = new System.Drawing.Point(404, 161);
            this.ujhobbi.Name = "ujhobbi";
            this.ujhobbi.Size = new System.Drawing.Size(49, 13);
            this.ujhobbi.TabIndex = 6;
            this.ujhobbi.Text = "Új hobbi:";
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(213, 96);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(31, 17);
            this.ferfi.TabIndex = 7;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "F";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(304, 96);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(33, 17);
            this.no.TabIndex = 8;
            this.no.TabStop = true;
            this.no.Text = "N";
            this.no.UseVisualStyleBackColor = true;
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(124, 98);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(32, 13);
            this.nem.TabIndex = 9;
            this.nem.Text = "Nem:";
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(526, 240);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 10;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(526, 303);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 25);
            this.betoltes.TabIndex = 11;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(407, 303);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 12;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerszuldatum
            // 
            this.dateTimePickerszuldatum.Location = new System.Drawing.Point(213, 48);
            this.dateTimePickerszuldatum.Name = "dateTimePickerszuldatum";
            this.dateTimePickerszuldatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerszuldatum.TabIndex = 13;
            // 
            // kedvenchobbi
            // 
            this.kedvenchobbi.AutoSize = true;
            this.kedvenchobbi.Location = new System.Drawing.Point(492, 15);
            this.kedvenchobbi.Name = "kedvenchobbi";
            this.kedvenchobbi.Size = new System.Drawing.Size(82, 13);
            this.kedvenchobbi.TabIndex = 14;
            this.kedvenchobbi.Text = "Kedvenc hobbi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 376);
            this.Controls.Add(this.kedvenchobbi);
            this.Controls.Add(this.dateTimePickerszuldatum);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.no);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.ujhobbi);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.listBoxkedvenchobbi);
            this.Controls.Add(this.textBoxujhobbi);
            this.Controls.Add(this.textBoxnev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnev;
        private System.Windows.Forms.TextBox textBoxujhobbi;
        private System.Windows.Forms.ListBox listBoxkedvenchobbi;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szuldatum;
        private System.Windows.Forms.Label ujhobbi;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.DateTimePicker dateTimePickerszuldatum;
        private System.Windows.Forms.Label kedvenchobbi;
    }
}

