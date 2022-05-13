﻿using System;
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
            int i = cBox.SelectedIndex;

            if (i != -1)
            {
                Adherent ad = (Adherent)lstAd[i];

                lstIns = monManager.chargemenInBD(ad);

                if (lstIns.Count != 0) { rafraichirListBox(0); }

                else { rafraichirListBox_Comptes_Vides(); }

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
            // lBox.DataSource = lstcpt.Values.ToList();
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

        }
    }
}
