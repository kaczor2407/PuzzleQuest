namespace PuzzleQuest
{
    partial class Mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_zapisz_gre = new System.Windows.Forms.Button();
            this.label1_zalogowany = new System.Windows.Forms.Label();
            this.label_pokaz_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(198, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 361);
            this.panel1.TabIndex = 1;
            // 
            // button_zapisz_gre
            // 
            this.button_zapisz_gre.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_zapisz_gre.Location = new System.Drawing.Point(42, 63);
            this.button_zapisz_gre.Name = "button_zapisz_gre";
            this.button_zapisz_gre.Size = new System.Drawing.Size(109, 47);
            this.button_zapisz_gre.TabIndex = 2;
            this.button_zapisz_gre.Text = "Zapisz grę";
            this.button_zapisz_gre.UseVisualStyleBackColor = false;
            this.button_zapisz_gre.Click += new System.EventHandler(this.button_zapisz_gre_Click);
            // 
            // label1_zalogowany
            // 
            this.label1_zalogowany.AutoSize = true;
            this.label1_zalogowany.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_zalogowany.Location = new System.Drawing.Point(42, 135);
            this.label1_zalogowany.Name = "label1_zalogowany";
            this.label1_zalogowany.Size = new System.Drawing.Size(141, 21);
            this.label1_zalogowany.TabIndex = 3;
            this.label1_zalogowany.Text = "Zalogowany jako:";
            // 
            // label_pokaz_login
            // 
            this.label_pokaz_login.AutoSize = true;
            this.label_pokaz_login.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pokaz_login.Location = new System.Drawing.Point(42, 168);
            this.label_pokaz_login.Name = "label_pokaz_login";
            this.label_pokaz_login.Size = new System.Drawing.Size(48, 19);
            this.label_pokaz_login.TabIndex = 4;
            this.label_pokaz_login.Text = "label1";
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_pokaz_login);
            this.Controls.Add(this.label1_zalogowany);
            this.Controls.Add(this.button_zapisz_gre);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle Quest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.zamknij_mapa);
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_pressed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_zapisz_gre;
        private System.Windows.Forms.Label label1_zalogowany;
        public System.Windows.Forms.Label label_pokaz_login;
    }
}