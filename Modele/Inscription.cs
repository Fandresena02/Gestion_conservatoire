using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class Inscription
    {
        private Adherent unAdherent;
        private Cours unCours;
        private int solde;

        public Inscription(Adherent unAdherent, Cours unCours, int solde)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.solde = solde;
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
