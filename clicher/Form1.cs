using System;
using System.Windows.Forms;



namespace clicher
{
    public partial class Form1 : Form
    {
        double bani = 100;
        double upgrade_price = 10;
        bool pornit = false;
        double damage_multiplier = 0;
        double dmg_total = 1;
        double upgrade_price_dps = 100;
        double dps = 0;
        double dpc = 1;
        double count_apasari = 0;
        double exp_act = 0;
        double exp_nec = 5;
        int level = 1;


        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }

        public Form1()
        {

            InitializeComponent();
            lblPriceDPS.Text = "Pret: 100";
            btnUpgradeClickDMG.Enabled = false;
            btnDPS.Enabled = false;
            lblUpgradePrice.Text = "Pret: 10";


        }



        private void btnClick_Click(object sender, EventArgs e)
        {
            bani += 1;
            lblAfisareBani.Text = Convert.ToString(bani);
        }



        private void btnUpgradeClickDMG_Click_1(object sender, EventArgs e)
        {

            exp_act += 0.5;
            RoundUp(exp_act, 2);

            upgrade_price = Math.Round(upgrade_price);
            bani -= upgrade_price;
            upgrade_price = upgrade_price + (0.25 * upgrade_price);
            upgrade_price = Math.Round(upgrade_price);
            damage_multiplier += 0.5;
            dpc += 0.5;
            lblUpgradePrice.Text = "Pret: " + upgrade_price;
            lblAfisareBani.Text = Convert.ToString(bani);
            lblAfisajCurrentDMG.Text = Convert.ToString(damage_multiplier);

        }


        private void btnClick_Click_1(object sender, EventArgs e)
        {

            exp_act += 0.1;



            if (damage_multiplier != 0)
            {
                bani += damage_multiplier;
            }
            bani += 1;
            lblAfisareBani.Text = Convert.ToString(bani);


            if (bani < upgrade_price)
            {
                btnUpgradeClickDMG.Enabled = false;
            }
            else if (bani >= upgrade_price)
            {
                btnUpgradeClickDMG.Enabled = true;
            }


            if (bani < upgrade_price_dps)
            {
                btnDPS.Enabled = false;
            }
            else if (bani >= upgrade_price_dps)
            {
                btnDPS.Enabled = true;
            }
            count_apasari += 1;

        }

        private void btnDPS_Click(object sender, EventArgs e)
        {

            dps += 0.5;
            bani -= upgrade_price_dps;
            exp_act += 1;
            RoundUp(exp_act, 2);

            if (dps >= 0.5)
            {
                pornit = true;
            }
            else if (dps == 0)
                pornit = false;

            upgrade_price_dps = upgrade_price_dps + (0.5 * upgrade_price_dps);
            lblPriceDPS.Text = "Pret: " + upgrade_price_dps;


            if (bani < upgrade_price_dps)
            {
                btnDPS.Enabled = false;
            }
            else if (bani >= upgrade_price_dps)
            {
                btnDPS.Enabled = true;
            }

        }



        public void save_game()
        {

            Save.Default.bani = bani;
            Save.Default.upgrade_price = upgrade_price;
            Save.Default.upgrade_price_dps = upgrade_price_dps;
            Save.Default.dmg_multiplier = damage_multiplier;
            Save.Default.dmg_total = dmg_total;
            Save.Default.dps = dps;
            Save.Default.dpc = dpc;
            Save.Default.timer1 = timer1.Enabled;
            Save.Default.timerdps = timerDPS.Enabled;
            Save.Default.pornit = pornit;
            Save.Default.count_apasari = count_apasari;
            Save.Default.exp_act = exp_act;
            Save.Default.exp_nec = exp_nec;
            Save.Default.level = level;
            Save.Default.Save();
            string data_salvare = DateTime.Now.ToString("dd'/'MM'/'yyyy 'Ora: 'HH':'mm");
            lblUltimaSalvare.Text = "Ultima salvare: " + data_salvare;
            MessageBox.Show(this, "Datele au fost salvate!", "Salvare", MessageBoxButtons.OK);

        }

        public void autosave()
        {

            Save.Default.bani = bani;
            Save.Default.upgrade_price = upgrade_price;
            Save.Default.upgrade_price_dps = upgrade_price_dps;
            Save.Default.dmg_multiplier = damage_multiplier;
            Save.Default.dmg_total = dmg_total;
            Save.Default.dps = dps;
            Save.Default.dpc = dpc;
            Save.Default.timer1 = timer1.Enabled;
            Save.Default.timerdps = timerDPS.Enabled;
            Save.Default.pornit = pornit;
            Save.Default.lblAfisajCurrentDMG = lblAfisajCurrentDMG.Text;
            Save.Default.lblAfisareDMGperclick = lblAfisareDMGperclick.Text;
            Save.Default.lblAfisareDPS = lblAfisareDPS.Text;
            Save.Default.lblPriceDPS = lblPriceDPS.Text;
            Save.Default.lblUpgradePrice = lblUpgradePrice.Text;
            Save.Default.count_apasari = count_apasari;
            Save.Default.exp_act = exp_act;
            Save.Default.exp_nec = exp_nec;
            Save.Default.level = level;
            Save.Default.Save();

        }

        public void load_game()
        {
            pornit = Save.Default.pornit;
            bani = Save.Default.bani;
            upgrade_price = Save.Default.upgrade_price;
            upgrade_price_dps = Save.Default.upgrade_price_dps;
            dps = Save.Default.dps;
            damage_multiplier = Save.Default.dmg_multiplier;
            dmg_total = Save.Default.dmg_total;
            timer1.Enabled = Save.Default.timer1;
            timerDPS.Enabled = Save.Default.timerdps;
            timer1.Start();
            timerDPS.Start();
            dpc = Save.Default.dpc;
            lblAfisajCurrentDMG.Text = Save.Default.lblAfisajCurrentDMG;
            lblAfisareDMGperclick.Text = Save.Default.lblAfisareDMGperclick;
            lblAfisareDPS.Text = Save.Default.lblAfisareDPS;
            count_apasari = Save.Default.count_apasari;
            exp_act = Save.Default.exp_act;
            exp_nec = Save.Default.exp_nec;
            level = Save.Default.level;

            lblUpgradePrice.Text = "Pret: " + Convert.ToString(upgrade_price);
            lblPriceDPS.Text = "Pret: " + Convert.ToString(upgrade_price_dps);

            MessageBox.Show(this, "Datele au fost incarcate!", "Succes !", MessageBoxButtons.OK);

        }

        public void new_game()
        {

            bani = 1;
            upgrade_price = 10;
            pornit = false;
            damage_multiplier = 0;
            dmg_total = 1;
            upgrade_price_dps = 100;
            dps = 0;
            dpc = 1;

        }

        public void level_up()
        {
            if (exp_act >= exp_nec)
            {

                level += 1;
                damage_multiplier += 0.5;
                if (pornit != true)
                {
                    dps += 0.5;
                    pornit = true;
                }
                bani += 50;
                dpc += 0.5;
                exp_nec = exp_nec * 2;
                lblNrnivel.Text = Convert.ToString(level);
                lblExperienta.Text = "Experienta: " + Convert.ToString(exp_act);
                lblExpnec.Text = "Ai nevoie de " + exp_nec + " experienta";
                MessageBox.Show(this, "Felicitari, ai avansat in nivel !" + "\n" + "Drept recompensa ai primit urmatoarele:" + "\n" + "   -0.5 DMG/click" + "\n" + "   -0.5D MG/s" + "\n" + "   - 50 bani", "Level Up!", MessageBoxButtons.OK);
                return;

            }


        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            level_up();
            RoundUp(exp_act, 13);
            lblNrnivel.Text = Convert.ToString(level);
            lblExperienta.Text = "Experienta: " + Convert.ToString(exp_act);
            lblExpnec.Text = "Ai nevoie de " + exp_nec + " experienta";
            lblAfisajCurrentDMG.Text = Convert.ToString(damage_multiplier);

            lblAfisareBani.Text = Convert.ToString(bani);
            lblAfisareDMGperclick.Text = Convert.ToString(dpc);
            lblAfisareDPS.Text = Convert.ToString(dps);
            lblApasari.Text = "Nr. apasari: " + Convert.ToString(count_apasari);
            lblNrnivel.Text = Convert.ToString(level);
            if (bani < upgrade_price)
            {
                btnUpgradeClickDMG.Enabled = false;
            }
            else if (bani >= upgrade_price)
            {
                btnUpgradeClickDMG.Enabled = true;
            }

            if (bani < upgrade_price_dps)
            {
                btnDPS.Enabled = false;
            }

            else if (bani >= upgrade_price_dps)
            {
                btnDPS.Enabled = true;
            }

        }

        private void timerDPS_Tick(object sender, EventArgs e)
        {

            if (pornit == true)
            {
                bani += dps;
            }

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_game();
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            load_game();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string mesaj = "Esti sigur ca vrei sa resetezi progresul ?";
            string titlu = "ATENTIE !";

            var result = MessageBox.Show(mesaj, titlu,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                new_game();
                MessageBox.Show(this, "Progresul a fost resetat !", "Info Progres", MessageBoxButtons.OK);

            }




        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Cretu Cosmin");
        }

        private void timerautosave_Tick(object sender, EventArgs e)
        {
            string data_salvare = DateTime.Now.ToString("dd'/'MM'/'yyyy 'Ora: 'HH':'mm");

            if (cboxSalvare.Checked == true)
            {
                autosave();
                lblUltimaSalvare.Text = "Ultima salvare: " + data_salvare;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNrnivel_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string mesaj = "Esti sigur ca vrei sa parasesti jocul ?" + "\n" + "Daca nu ai salvat progresul acesta va fi pierdut.";
            string titlu = "ATENTIE !";

            var result = MessageBox.Show(mesaj, titlu,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        public void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new FrmAjutor();
            f2.Show();

        }
    }
}
