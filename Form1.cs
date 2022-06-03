using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using Gestion_conservatoire.Controleur;
using Gestion_conservatoire.Modele;

namespace Gestion_conservatoire
    
{
    [Serializable]
    public partial class Gestion : Form
    {
        Mgr monManager;

        private List<Adherent> lstAd = new List<Adherent>();
        private List<Inscription> lstIns = new List<Inscription>();
        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSupp.Visible = false;
            
            int i = cBox.SelectedIndex;

            if (i != -1)
            {
                Adherent ad = (Adherent)lstAd[i];

                lstIns = monManager.chargemenInBD(ad);

                if (lstIns.Count != 0) { rafraichirListBox(0); }

                else { 
                    rafraichirListBox_Comptes_Vides();
                    crediterMenu.Visible = false;
                    lblEtat.Visible = false;
                    panel1.Visible = false;
                    btnCredit.Visible = false;
                    txtBoxCredit.Visible = false;
                }

            }

        }
        private void rafraichirListBox_Comptes_Vides()
        {
            lBox.DataSource = null;
            lBox.DisplayMember = "Description";
        }
        private void rafraichirComboBox(int index)
        {

            cBox.DataSource = null;
            cBox.DataSource = lstAd;
            cBox.DisplayMember = "Description";
           // cBox.SelectedItem(index, true);

        }
        private void rafraichirListBox(int index)
        {

            lBox.DataSource = null;
            lBox.DataSource = lstIns;
            lBox.DisplayMember = "Description";
            lBox.SetSelected(index, true);

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            lstAd = monManager.chargementAdBD();

            if (lstAd.Count != 0) { rafraichirComboBox(0); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            crediterMenu.Visible = true;
            lblEtat.Visible = true;
            panel1.Visible = true;

            int index = lBox.SelectedIndex;
            if (index != -1)
            { 
                    Inscription uneInscription = (Inscription)lstIns[index];

                if (uneInscription.check(uneInscription.Solde))
                {
                    panel1.BackColor = Color.Green;
                }
                else panel1.BackColor = Color.Red;
            }

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = cBox.SelectedIndex;
            Adherent a = (Adherent)lstAd[i];

            FormAdherent fa = new FormAdherent(a);

            fa.ShowDialog();

            monManager.updateAdherent(a);

            lstAd = monManager.chargementAdBD();

            rafraichirComboBox(i);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSupp.Visible = true;
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            int i = cBox.SelectedIndex;
            Adherent ad = (Adherent)lstAd[i];
            DialogResult user_choix;

            user_choix = MessageBox.Show("Voulez-vous vraiment le supprimer ?", "Suppression adherent",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (user_choix == DialogResult.Yes)
            { 

                try
                {
                    monManager.deleteAdherent(ad);

                    lstAd = monManager.chargementAdBD();

                    rafraichirComboBox(i);

                }catch(Exception emp)
                {
                    MessageBox.Show("Attention, il existe une/des inscription(s) pour cet adhérent");
                }
            }


        }

        private void crediterMenu_Click(object sender, EventArgs e)
        {
            btnCredit.Visible = true;
            txtBoxCredit.Visible = true;
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            int i = lBox.SelectedIndex;

            Inscription uneIns = (Inscription)lstIns[i];
            try
            {
                uneIns.crediter(Convert.ToInt32(txtBoxCredit.Text));

                monManager.updateSolde(uneIns);


                int j = cBox.SelectedIndex;
                Adherent a = (Adherent)lstAd[j];
                lstIns = monManager.chargemenInBD(a);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            int index = lBox.SelectedIndex;

            rafraichirListBox(index);

        }
    }
}
