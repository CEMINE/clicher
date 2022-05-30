
namespace clicher
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
            this.components = new System.ComponentModel.Container();
            this.lblBani = new System.Windows.Forms.Label();
            this.lblAfisareBani = new System.Windows.Forms.Label();
            this.btnUpgradeClickDMG = new System.Windows.Forms.Button();
            this.lblUpgradeDMG = new System.Windows.Forms.Label();
            this.lblUpgradePrice = new System.Windows.Forms.Label();
            this.lblCurrentDMG = new System.Windows.Forms.Label();
            this.lblAfisajCurrentDMG = new System.Windows.Forms.Label();
            this.lblDMGperClick = new System.Windows.Forms.Label();
            this.lblAfisareDMGperclick = new System.Windows.Forms.Label();
            this.btnDPS = new System.Windows.Forms.Button();
            this.lblDPS = new System.Windows.Forms.Label();
            this.lblPriceDPS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDPS = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAfisareDPS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSalvare = new System.Windows.Forms.CheckBox();
            this.timerautosave = new System.Windows.Forms.Timer(this.components);
            this.lblUltimaSalvare = new System.Windows.Forms.Label();
            this.lblApasari = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNrnivel = new System.Windows.Forms.Label();
            this.lblExperienta = new System.Windows.Forms.Label();
            this.lblExpnec = new System.Windows.Forms.Label();
            this.lblrandom = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBani
            // 
            this.lblBani.AutoSize = true;
            this.lblBani.BackColor = System.Drawing.Color.Transparent;
            this.lblBani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBani.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBani.ForeColor = System.Drawing.Color.Black;
            this.lblBani.Location = new System.Drawing.Point(10, 392);
            this.lblBani.Margin = new System.Windows.Forms.Padding(0);
            this.lblBani.Name = "lblBani";
            this.lblBani.Size = new System.Drawing.Size(80, 37);
            this.lblBani.TabIndex = 0;
            this.lblBani.Text = "Bani:";
            // 
            // lblAfisareBani
            // 
            this.lblAfisareBani.AutoSize = true;
            this.lblAfisareBani.BackColor = System.Drawing.Color.Transparent;
            this.lblAfisareBani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAfisareBani.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisareBani.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAfisareBani.Location = new System.Drawing.Point(83, 393);
            this.lblAfisareBani.Margin = new System.Windows.Forms.Padding(0);
            this.lblAfisareBani.Name = "lblAfisareBani";
            this.lblAfisareBani.Size = new System.Drawing.Size(33, 37);
            this.lblAfisareBani.TabIndex = 1;
            this.lblAfisareBani.Text = "0";
            // 
            // btnUpgradeClickDMG
            // 
            this.btnUpgradeClickDMG.Location = new System.Drawing.Point(92, 294);
            this.btnUpgradeClickDMG.Name = "btnUpgradeClickDMG";
            this.btnUpgradeClickDMG.Size = new System.Drawing.Size(75, 23);
            this.btnUpgradeClickDMG.TabIndex = 3;
            this.btnUpgradeClickDMG.Text = "Upgrade !";
            this.btnUpgradeClickDMG.UseVisualStyleBackColor = true;
            this.btnUpgradeClickDMG.Click += new System.EventHandler(this.btnUpgradeClickDMG_Click_1);
            // 
            // lblUpgradeDMG
            // 
            this.lblUpgradeDMG.AutoSize = true;
            this.lblUpgradeDMG.Location = new System.Drawing.Point(12, 258);
            this.lblUpgradeDMG.Name = "lblUpgradeDMG";
            this.lblUpgradeDMG.Size = new System.Drawing.Size(285, 13);
            this.lblUpgradeDMG.TabIndex = 4;
            this.lblUpgradeDMG.Text = "Apasa pe butonul de jos pentru a imbunatati DMG/apasare";
            // 
            // lblUpgradePrice
            // 
            this.lblUpgradePrice.AutoSize = true;
            this.lblUpgradePrice.Location = new System.Drawing.Point(-1, 299);
            this.lblUpgradePrice.Name = "lblUpgradePrice";
            this.lblUpgradePrice.Size = new System.Drawing.Size(26, 13);
            this.lblUpgradePrice.TabIndex = 5;
            this.lblUpgradePrice.Text = "Pret";
            // 
            // lblCurrentDMG
            // 
            this.lblCurrentDMG.AutoSize = true;
            this.lblCurrentDMG.Location = new System.Drawing.Point(-1, 320);
            this.lblCurrentDMG.Name = "lblCurrentDMG";
            this.lblCurrentDMG.Size = new System.Drawing.Size(111, 13);
            this.lblCurrentDMG.TabIndex = 6;
            this.lblCurrentDMG.Text = "Bonus damage/click :";
            // 
            // lblAfisajCurrentDMG
            // 
            this.lblAfisajCurrentDMG.AutoSize = true;
            this.lblAfisajCurrentDMG.ForeColor = System.Drawing.Color.Red;
            this.lblAfisajCurrentDMG.Location = new System.Drawing.Point(137, 321);
            this.lblAfisajCurrentDMG.Name = "lblAfisajCurrentDMG";
            this.lblAfisajCurrentDMG.Size = new System.Drawing.Size(13, 13);
            this.lblAfisajCurrentDMG.TabIndex = 7;
            this.lblAfisajCurrentDMG.Text = "0";
            // 
            // lblDMGperClick
            // 
            this.lblDMGperClick.AutoSize = true;
            this.lblDMGperClick.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMGperClick.Location = new System.Drawing.Point(8, 35);
            this.lblDMGperClick.Name = "lblDMGperClick";
            this.lblDMGperClick.Size = new System.Drawing.Size(201, 37);
            this.lblDMGperClick.TabIndex = 8;
            this.lblDMGperClick.Text = "Damage/click:";
            // 
            // lblAfisareDMGperclick
            // 
            this.lblAfisareDMGperclick.AutoSize = true;
            this.lblAfisareDMGperclick.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisareDMGperclick.ForeColor = System.Drawing.Color.Red;
            this.lblAfisareDMGperclick.Location = new System.Drawing.Point(215, 36);
            this.lblAfisareDMGperclick.Name = "lblAfisareDMGperclick";
            this.lblAfisareDMGperclick.Size = new System.Drawing.Size(33, 37);
            this.lblAfisareDMGperclick.TabIndex = 9;
            this.lblAfisareDMGperclick.Text = "1";
            // 
            // btnDPS
            // 
            this.btnDPS.Location = new System.Drawing.Point(639, 291);
            this.btnDPS.Name = "btnDPS";
            this.btnDPS.Size = new System.Drawing.Size(75, 23);
            this.btnDPS.TabIndex = 10;
            this.btnDPS.Text = "Upgrade !";
            this.btnDPS.UseVisualStyleBackColor = true;
            this.btnDPS.Click += new System.EventHandler(this.btnDPS_Click);
            // 
            // lblDPS
            // 
            this.lblDPS.AutoSize = true;
            this.lblDPS.Location = new System.Drawing.Point(503, 258);
            this.lblDPS.Name = "lblDPS";
            this.lblDPS.Size = new System.Drawing.Size(288, 13);
            this.lblDPS.TabIndex = 11;
            this.lblDPS.Text = "Apasa pe butonul de jos pentru a imbunatati DMG/secunda";
            // 
            // lblPriceDPS
            // 
            this.lblPriceDPS.AutoSize = true;
            this.lblPriceDPS.Location = new System.Drawing.Point(545, 296);
            this.lblPriceDPS.Name = "lblPriceDPS";
            this.lblPriceDPS.Size = new System.Drawing.Size(26, 13);
            this.lblPriceDPS.TabIndex = 13;
            this.lblPriceDPS.Text = "Pret";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDPS
            // 
            this.timerDPS.Enabled = true;
            this.timerDPS.Interval = 1000;
            this.timerDPS.Tick += new System.EventHandler(this.timerDPS_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Fisier";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::clicher.Properties.Resources.ng3;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newGameToolStripMenuItem.Text = "Joc nou";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Image = global::clicher.Properties.Resources.save;
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveGameToolStripMenuItem.Text = "Salveaza progresul";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Image = global::clicher.Properties.Resources.reload;
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.loadGameToolStripMenuItem.Text = "Incarca progresul";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::clicher.Properties.Resources.x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Iesire";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.aboutToolStripMenuItem.Text = "Despre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // lblAfisareDPS
            // 
            this.lblAfisareDPS.AutoSize = true;
            this.lblAfisareDPS.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfisareDPS.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAfisareDPS.Location = new System.Drawing.Point(720, 36);
            this.lblAfisareDPS.Name = "lblAfisareDPS";
            this.lblAfisareDPS.Size = new System.Drawing.Size(33, 37);
            this.lblAfisareDPS.TabIndex = 16;
            this.lblAfisareDPS.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Damage/secunda:";
            // 
            // cboxSalvare
            // 
            this.cboxSalvare.AutoSize = true;
            this.cboxSalvare.Location = new System.Drawing.Point(670, 407);
            this.cboxSalvare.Name = "cboxSalvare";
            this.cboxSalvare.Size = new System.Drawing.Size(121, 17);
            this.cboxSalvare.TabIndex = 17;
            this.cboxSalvare.Text = "Autosalvarea jocului";
            this.cboxSalvare.UseVisualStyleBackColor = true;
            // 
            // timerautosave
            // 
            this.timerautosave.Enabled = true;
            this.timerautosave.Interval = 10000;
            this.timerautosave.Tick += new System.EventHandler(this.timerautosave_Tick);
            // 
            // lblUltimaSalvare
            // 
            this.lblUltimaSalvare.AutoSize = true;
            this.lblUltimaSalvare.Location = new System.Drawing.Point(325, 411);
            this.lblUltimaSalvare.Name = "lblUltimaSalvare";
            this.lblUltimaSalvare.Size = new System.Drawing.Size(76, 13);
            this.lblUltimaSalvare.TabIndex = 18;
            this.lblUltimaSalvare.Text = "Ultima salvare:";
            // 
            // lblApasari
            // 
            this.lblApasari.AutoSize = true;
            this.lblApasari.Location = new System.Drawing.Point(362, 214);
            this.lblApasari.Name = "lblApasari";
            this.lblApasari.Size = new System.Drawing.Size(64, 13);
            this.lblApasari.TabIndex = 19;
            this.lblApasari.Text = "Nr. apasari: ";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(13, 85);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(69, 13);
            this.lblNivel.TabIndex = 20;
            this.lblNivel.Text = "Nivel actual: ";
            // 
            // lblNrnivel
            // 
            this.lblNrnivel.AutoSize = true;
            this.lblNrnivel.Location = new System.Drawing.Point(77, 85);
            this.lblNrnivel.Name = "lblNrnivel";
            this.lblNrnivel.Size = new System.Drawing.Size(13, 13);
            this.lblNrnivel.TabIndex = 21;
            this.lblNrnivel.Text = "1";
            this.lblNrnivel.Click += new System.EventHandler(this.lblNrnivel_Click);
            // 
            // lblExperienta
            // 
            this.lblExperienta.AutoSize = true;
            this.lblExperienta.Location = new System.Drawing.Point(13, 98);
            this.lblExperienta.Name = "lblExperienta";
            this.lblExperienta.Size = new System.Drawing.Size(60, 13);
            this.lblExperienta.TabIndex = 22;
            this.lblExperienta.Text = "Experienta:";
            // 
            // lblExpnec
            // 
            this.lblExpnec.AutoSize = true;
            this.lblExpnec.Location = new System.Drawing.Point(13, 111);
            this.lblExpnec.Name = "lblExpnec";
            this.lblExpnec.Size = new System.Drawing.Size(66, 13);
            this.lblExpnec.TabIndex = 22;
            this.lblExpnec.Text = "Ai nevoie de";
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.Location = new System.Drawing.Point(13, 124);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(158, 13);
            this.lblrandom.TabIndex = 22;
            this.lblrandom.Text = "pentru a trece la urmatorul nivel.";
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Transparent;
            this.btnClick.BackgroundImage = global::clicher.Properties.Resources.sabie2;
            this.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.ForeColor = System.Drawing.Color.White;
            this.btnClick.Location = new System.Drawing.Point(326, 124);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(137, 87);
            this.btnClick.TabIndex = 2;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBani);
            this.Controls.Add(this.lblrandom);
            this.Controls.Add(this.lblExpnec);
            this.Controls.Add(this.lblExperienta);
            this.Controls.Add(this.lblNrnivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblApasari);
            this.Controls.Add(this.lblUltimaSalvare);
            this.Controls.Add(this.cboxSalvare);
            this.Controls.Add(this.lblAfisareDPS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPriceDPS);
            this.Controls.Add(this.lblDPS);
            this.Controls.Add(this.btnDPS);
            this.Controls.Add(this.lblAfisareDMGperclick);
            this.Controls.Add(this.lblDMGperClick);
            this.Controls.Add(this.lblAfisajCurrentDMG);
            this.Controls.Add(this.lblCurrentDMG);
            this.Controls.Add(this.lblUpgradePrice);
            this.Controls.Add(this.lblUpgradeDMG);
            this.Controls.Add(this.btnUpgradeClickDMG);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblAfisareBani);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker, jocul";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBani;
        private System.Windows.Forms.Label lblAfisareBani;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnUpgradeClickDMG;
        private System.Windows.Forms.Label lblUpgradeDMG;
        private System.Windows.Forms.Label lblUpgradePrice;
        private System.Windows.Forms.Label lblCurrentDMG;
        private System.Windows.Forms.Label lblAfisajCurrentDMG;
        private System.Windows.Forms.Label lblDMGperClick;
        private System.Windows.Forms.Label lblAfisareDMGperclick;
        private System.Windows.Forms.Button btnDPS;
        private System.Windows.Forms.Label lblDPS;
        private System.Windows.Forms.Label lblPriceDPS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDPS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblAfisareDPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboxSalvare;
        private System.Windows.Forms.Timer timerautosave;
        private System.Windows.Forms.Label lblUltimaSalvare;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblApasari;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNrnivel;
        private System.Windows.Forms.Label lblExperienta;
        private System.Windows.Forms.Label lblExpnec;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
    }
}

