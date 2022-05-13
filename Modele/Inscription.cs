﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
    class Inscription
    {
        private Adherent unAdherent;
        private Cours unCours;
        private int solde;
        private string nomAd, prenomAd, dateCours, nomProf, prenomProf, nomInstrument;
        private int payer, nombrePlace;

        public Inscription(Adherent unAdherent, Cours unCours, int solde)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.solde = solde;
        }
        public Inscription(string nomAd, string prenomAd,string  dateCours,string nomProf,string prenomProf,int nombrePlace,string nomInstrument, int payer)
        {
            this.nomAd = nomAd;
            this.prenomAd = prenomAd;
            this.dateCours = dateCours;
            this.nomProf = nomProf;
            this.prenomProf = prenomProf;
            this.nombrePlace = nombrePlace;
            this.nomInstrument = nomInstrument;
            this.payer = payer;
        }
        public Inscription()
        {

        }

        public Adherent UnAdherent { get => unAdherent; }
        public Cours UnCours { get => unCours; }
        public int Solde { get => solde; }

        public string Description
        {
            get => this.unAdherent + " " + this.unCours + " " + this.solde;
        }
    }
}
