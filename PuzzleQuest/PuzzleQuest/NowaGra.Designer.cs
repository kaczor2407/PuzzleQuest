namespace PuzzleQuest
{
    partial class Nowa_Gra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nowa_Gra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zaznaczanie_Timer = new System.Windows.Forms.Timer(this.components);
            this.pasek_zycia_Postaci = new System.Windows.Forms.ProgressBar();
            this.ilosc_czerwonych = new System.Windows.Forms.Label();
            this.ilosc_niebieskich = new System.Windows.Forms.Label();
            this.ilosc_zoltych = new System.Windows.Forms.Label();
            this.ilosc_zielonych = new System.Windows.Forms.Label();
            this.monety = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.zielony_klocek = new System.Windows.Forms.PictureBox();
            this.niebieski_klocek = new System.Windows.Forms.PictureBox();
            this.pieniadze = new System.Windows.Forms.PictureBox();
            this.zolty_klocek = new System.Windows.Forms.PictureBox();
            this.czerwony_klocek = new System.Windows.Forms.PictureBox();
            this.atak_picture_box = new System.Windows.Forms.PictureBox();
            this.atak_label = new System.Windows.Forms.Label();
            this.doswiadczenie_label = new System.Windows.Forms.Label();
            this.doswiadczenie_picture_box = new System.Windows.Forms.PictureBox();
            this.panel_Postaci = new System.Windows.Forms.Panel();
            this.zycie_postaci_Label = new System.Windows.Forms.Label();
            this.Ulecz = new System.Windows.Forms.Button();
            this.Czas = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zielony_klocek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieski_klocek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieniadze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolty_klocek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czerwony_klocek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atak_picture_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doswiadczenie_picture_box)).BeginInit();
            this.panel_Postaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.Value = 1000;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // zaznaczanie_Timer
            // 
            this.zaznaczanie_Timer.Interval = 1000;
            this.zaznaczanie_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pasek_zycia_Postaci
            // 
            this.pasek_zycia_Postaci.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.pasek_zycia_Postaci, "pasek_zycia_Postaci");
            this.pasek_zycia_Postaci.Maximum = 1000;
            this.pasek_zycia_Postaci.Name = "pasek_zycia_Postaci";
            this.pasek_zycia_Postaci.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pasek_zycia_Postaci.Value = 1000;
            // 
            // ilosc_czerwonych
            // 
            resources.ApplyResources(this.ilosc_czerwonych, "ilosc_czerwonych");
            this.ilosc_czerwonych.Name = "ilosc_czerwonych";
            // 
            // ilosc_niebieskich
            // 
            resources.ApplyResources(this.ilosc_niebieskich, "ilosc_niebieskich");
            this.ilosc_niebieskich.Name = "ilosc_niebieskich";
            // 
            // ilosc_zoltych
            // 
            resources.ApplyResources(this.ilosc_zoltych, "ilosc_zoltych");
            this.ilosc_zoltych.Name = "ilosc_zoltych";
            // 
            // ilosc_zielonych
            // 
            resources.ApplyResources(this.ilosc_zielonych, "ilosc_zielonych");
            this.ilosc_zielonych.Name = "ilosc_zielonych";
            // 
            // monety
            // 
            resources.ApplyResources(this.monety, "monety");
            this.monety.Name = "monety";
            // 
            // zielony_klocek
            // 
            this.zielony_klocek.Image = global::PuzzleQuest.Properties.Resources.klocek_zielony;
            resources.ApplyResources(this.zielony_klocek, "zielony_klocek");
            this.zielony_klocek.Name = "zielony_klocek";
            this.zielony_klocek.TabStop = false;
            // 
            // niebieski_klocek
            // 
            this.niebieski_klocek.Image = global::PuzzleQuest.Properties.Resources.klocek_niebieski;
            resources.ApplyResources(this.niebieski_klocek, "niebieski_klocek");
            this.niebieski_klocek.Name = "niebieski_klocek";
            this.niebieski_klocek.TabStop = false;
            // 
            // pieniadze
            // 
            this.pieniadze.Image = global::PuzzleQuest.Properties.Resources.monety;
            resources.ApplyResources(this.pieniadze, "pieniadze");
            this.pieniadze.Name = "pieniadze";
            this.pieniadze.TabStop = false;
            // 
            // zolty_klocek
            // 
            this.zolty_klocek.Image = global::PuzzleQuest.Properties.Resources.klocek_zolty;
            resources.ApplyResources(this.zolty_klocek, "zolty_klocek");
            this.zolty_klocek.Name = "zolty_klocek";
            this.zolty_klocek.TabStop = false;
            // 
            // czerwony_klocek
            // 
            this.czerwony_klocek.Image = global::PuzzleQuest.Properties.Resources.klocek_czerwony;
            resources.ApplyResources(this.czerwony_klocek, "czerwony_klocek");
            this.czerwony_klocek.Name = "czerwony_klocek";
            this.czerwony_klocek.TabStop = false;
            // 
            // atak_picture_box
            // 
            this.atak_picture_box.Image = global::PuzzleQuest.Properties.Resources.atak;
            resources.ApplyResources(this.atak_picture_box, "atak_picture_box");
            this.atak_picture_box.Name = "atak_picture_box";
            this.atak_picture_box.TabStop = false;
            // 
            // atak_label
            // 
            resources.ApplyResources(this.atak_label, "atak_label");
            this.atak_label.Name = "atak_label";
            // 
            // doswiadczenie_label
            // 
            resources.ApplyResources(this.doswiadczenie_label, "doswiadczenie_label");
            this.doswiadczenie_label.Name = "doswiadczenie_label";
            // 
            // doswiadczenie_picture_box
            // 
            this.doswiadczenie_picture_box.BackgroundImage = global::PuzzleQuest.Properties.Resources.doswiadczenie;
            resources.ApplyResources(this.doswiadczenie_picture_box, "doswiadczenie_picture_box");
            this.doswiadczenie_picture_box.Cursor = System.Windows.Forms.Cursors.No;
            this.doswiadczenie_picture_box.Name = "doswiadczenie_picture_box";
            this.doswiadczenie_picture_box.TabStop = false;
            // 
            // panel_Postaci
            // 
            resources.ApplyResources(this.panel_Postaci, "panel_Postaci");
            this.panel_Postaci.Controls.Add(this.zolty_klocek);
            this.panel_Postaci.Controls.Add(this.zycie_postaci_Label);
            this.panel_Postaci.Controls.Add(this.zielony_klocek);
            this.panel_Postaci.Controls.Add(this.doswiadczenie_picture_box);
            this.panel_Postaci.Controls.Add(this.ilosc_czerwonych);
            this.panel_Postaci.Controls.Add(this.niebieski_klocek);
            this.panel_Postaci.Controls.Add(this.atak_label);
            this.panel_Postaci.Controls.Add(this.czerwony_klocek);
            this.panel_Postaci.Controls.Add(this.monety);
            this.panel_Postaci.Controls.Add(this.ilosc_zielonych);
            this.panel_Postaci.Controls.Add(this.ilosc_zoltych);
            this.panel_Postaci.Controls.Add(this.atak_picture_box);
            this.panel_Postaci.Controls.Add(this.pieniadze);
            this.panel_Postaci.Controls.Add(this.doswiadczenie_label);
            this.panel_Postaci.Controls.Add(this.ilosc_niebieskich);
            this.panel_Postaci.Name = "panel_Postaci";
            // 
            // zycie_postaci_Label
            // 
            resources.ApplyResources(this.zycie_postaci_Label, "zycie_postaci_Label");
            this.zycie_postaci_Label.BackColor = System.Drawing.Color.Transparent;
            this.zycie_postaci_Label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.zycie_postaci_Label.Name = "zycie_postaci_Label";
            // 
            // Ulecz
            // 
            this.Ulecz.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.Ulecz, "Ulecz");
            this.Ulecz.Name = "Ulecz";
            this.Ulecz.UseVisualStyleBackColor = false;
            this.Ulecz.Click += new System.EventHandler(this.Ulecz_Click);
            // 
            // Czas
            // 
            resources.ApplyResources(this.Czas, "Czas");
            this.Czas.Name = "Czas";
            // 
            // Nowa_Gra
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.Ulecz);
            this.Controls.Add(this.panel_Postaci);
            this.Controls.Add(this.pasek_zycia_Postaci);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Nowa_Gra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Nowa_Gra_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zielony_klocek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niebieski_klocek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieniadze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolty_klocek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czerwony_klocek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atak_picture_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doswiadczenie_picture_box)).EndInit();
            this.panel_Postaci.ResumeLayout(false);
            this.panel_Postaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ProgressBar pasek_zycia_Postaci;
        private System.Windows.Forms.PictureBox czerwony_klocek;
        private System.Windows.Forms.PictureBox zolty_klocek;
        private System.Windows.Forms.PictureBox pieniadze;
        private System.Windows.Forms.PictureBox niebieski_klocek;
        private System.Windows.Forms.PictureBox zielony_klocek;
        private System.Windows.Forms.Label ilosc_czerwonych;
        private System.Windows.Forms.Label ilosc_niebieskich;
        private System.Windows.Forms.Label ilosc_zoltych;
        private System.Windows.Forms.Label ilosc_zielonych;
        private System.Windows.Forms.Label monety;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.Timer zaznaczanie_Timer;
        private System.Windows.Forms.PictureBox atak_picture_box;
        private System.Windows.Forms.Label atak_label;
        private System.Windows.Forms.Label doswiadczenie_label;
        private System.Windows.Forms.PictureBox doswiadczenie_picture_box;
        public System.Windows.Forms.Panel panel_Postaci;
        private System.Windows.Forms.Label zycie_postaci_Label;
        private System.Windows.Forms.Button Ulecz;
        private System.Windows.Forms.Label Czas;
    }
}