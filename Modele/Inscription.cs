using System;
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
        private const int montant = 500;

        public Inscription(Adherent unAdherent, Cours unCours, int solde)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.solde = solde;
        }
       
        public Adherent UnAdherent { get => unAdherent; }
        public Cours UnCours { get => unCours; }
        public int Solde { get => solde; set => solde = value; }

        public string Description
        {
            get => this.unCours.Description + " " + this.solde +"/" + montant;
        }
        public void crediter(int mont)
        {
            if (solde + mont > montant)
            {
                throw new Exception("Montant dépassé");
            }
            else
            {
                solde = solde + mont;

            }
        }
        public Boolean check(int mont)
        {
            if (mont < montant)
            {
                return false;
            }
            else return true;
        }
    }
}
