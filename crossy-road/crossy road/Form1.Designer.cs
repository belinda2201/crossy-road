namespace crossy_road
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bebek = new System.Windows.Forms.PictureBox();
            this.mobil2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skor = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.mobil1 = new System.Windows.Forms.PictureBox();
            this.mobil4 = new System.Windows.Forms.PictureBox();
            this.mobil3 = new System.Windows.Forms.PictureBox();
            this.mobil5 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.nyawa = new System.Windows.Forms.PictureBox();
            this.level = new System.Windows.Forms.Label();
            this.boxgameover = new System.Windows.Forms.PictureBox();
            this.skorAkhir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bebek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxgameover)).BeginInit();
            this.SuspendLayout();
            // 
            // bebek
            // 
            this.bebek.BackColor = System.Drawing.Color.Transparent;
            this.bebek.BackgroundImage = global::crossy_road.Properties.Resources.bebek;
            this.bebek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bebek.Location = new System.Drawing.Point(367, 601);
            this.bebek.Name = "bebek";
            this.bebek.Size = new System.Drawing.Size(97, 97);
            this.bebek.TabIndex = 0;
            this.bebek.TabStop = false;
            // 
            // mobil2
            // 
            this.mobil2.BackColor = System.Drawing.Color.Transparent;
            this.mobil2.BackgroundImage = global::crossy_road.Properties.Resources.mobil_2;
            this.mobil2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobil2.Location = new System.Drawing.Point(757, 220);
            this.mobil2.Name = "mobil2";
            this.mobil2.Size = new System.Drawing.Size(125, 62);
            this.mobil2.TabIndex = 2;
            this.mobil2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.BackColor = System.Drawing.Color.Transparent;
            this.skor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skor.Location = new System.Drawing.Point(12, 39);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(86, 25);
            this.skor.TabIndex = 3;
            this.skor.Text = "SCORE : ";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // mobil1
            // 
            this.mobil1.BackColor = System.Drawing.Color.Transparent;
            this.mobil1.BackgroundImage = global::crossy_road.Properties.Resources.mobil_1;
            this.mobil1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobil1.Location = new System.Drawing.Point(1, 124);
            this.mobil1.Name = "mobil1";
            this.mobil1.Size = new System.Drawing.Size(125, 62);
            this.mobil1.TabIndex = 4;
            this.mobil1.TabStop = false;
            // 
            // mobil4
            // 
            this.mobil4.BackColor = System.Drawing.Color.Transparent;
            this.mobil4.BackgroundImage = global::crossy_road.Properties.Resources.mobil_4;
            this.mobil4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobil4.Location = new System.Drawing.Point(724, 417);
            this.mobil4.Name = "mobil4";
            this.mobil4.Size = new System.Drawing.Size(158, 62);
            this.mobil4.TabIndex = 5;
            this.mobil4.TabStop = false;
            // 
            // mobil3
            // 
            this.mobil3.BackColor = System.Drawing.Color.Transparent;
            this.mobil3.BackgroundImage = global::crossy_road.Properties.Resources.mobil_3;
            this.mobil3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobil3.Location = new System.Drawing.Point(1, 314);
            this.mobil3.Name = "mobil3";
            this.mobil3.Size = new System.Drawing.Size(162, 62);
            this.mobil3.TabIndex = 6;
            this.mobil3.TabStop = false;
            // 
            // mobil5
            // 
            this.mobil5.BackColor = System.Drawing.Color.Transparent;
            this.mobil5.BackgroundImage = global::crossy_road.Properties.Resources.mobil_5;
            this.mobil5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mobil5.Location = new System.Drawing.Point(724, 522);
            this.mobil5.Name = "mobil5";
            this.mobil5.Size = new System.Drawing.Size(158, 62);
            this.mobil5.TabIndex = 7;
            this.mobil5.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // nyawa
            // 
            this.nyawa.BackColor = System.Drawing.Color.Transparent;
            this.nyawa.BackgroundImage = global::crossy_road.Properties.Resources.nyawa;
            this.nyawa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nyawa.Location = new System.Drawing.Point(724, 12);
            this.nyawa.Name = "nyawa";
            this.nyawa.Size = new System.Drawing.Size(147, 76);
            this.nyawa.TabIndex = 8;
            this.nyawa.TabStop = false;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.BackColor = System.Drawing.Color.Transparent;
            this.level.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.level.Location = new System.Drawing.Point(401, 44);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(63, 20);
            this.level.TabIndex = 9;
            this.level.Text = "LEVEL : ";
            // 
            // boxgameover
            // 
            this.boxgameover.BackgroundImage = global::crossy_road.Properties.Resources.game_over;
            this.boxgameover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxgameover.Location = new System.Drawing.Point(285, -264);
            this.boxgameover.Name = "boxgameover";
            this.boxgameover.Size = new System.Drawing.Size(283, 240);
            this.boxgameover.TabIndex = 10;
            this.boxgameover.TabStop = false;
            // 
            // skorAkhir
            // 
            this.skorAkhir.AutoSize = true;
            this.skorAkhir.BackColor = System.Drawing.Color.Transparent;
            this.skorAkhir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skorAkhir.Location = new System.Drawing.Point(474, 417);
            this.skorAkhir.Name = "skorAkhir";
            this.skorAkhir.Size = new System.Drawing.Size(0, 20);
            this.skorAkhir.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crossy_road.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 700);
            this.Controls.Add(this.skorAkhir);
            this.Controls.Add(this.boxgameover);
            this.Controls.Add(this.level);
            this.Controls.Add(this.nyawa);
            this.Controls.Add(this.mobil5);
            this.Controls.Add(this.mobil3);
            this.Controls.Add(this.mobil4);
            this.Controls.Add(this.mobil1);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.mobil2);
            this.Controls.Add(this.bebek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Movement);
            ((System.ComponentModel.ISupportInitialize)(this.bebek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobil5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyawa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxgameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox bebek;
        private PictureBox mobil2;
        private System.Windows.Forms.Timer timer1;
        private Label skor;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private PictureBox mobil1;
        private PictureBox mobil4;
        private PictureBox mobil3;
        private PictureBox mobil5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private PictureBox nyawa;
        private Label level;
        private PictureBox boxgameover;
        private Label skorAkhir;
    }
}