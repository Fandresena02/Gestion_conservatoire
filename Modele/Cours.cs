using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
    class Cours
    {
        private int id;
        private string jourHeure;
        private int nbPlace;
        private Professeur unProfesseur;
        private Instrument unInstrument;

        public Cours(int id, string jourHeure, int nbPlace, Professeur unProfesseur, Instrument unInstrument)
        {
            this.id = id;
            this.jourHeure = jourHeure;
            this.nbPlace = nbPlace;
            this.unProfesseur = unProfesseur;
            this.unInstrument = unInstrument;
        }

        public string Date { get => jourHeure; }
        public int NbPlace { get => nbPlace; }
        public Professeur UnProf { get => unProfesseur; }
        public Instrument UnIntrument { get => unInstrument; }
        public int Id { get => id; }

        public string Description
        {

            get => "Date: " + this.jourHeure + ", NbPlace: " + this.nbPlace + ", Prof: " + this.unProfesseur.Description + ", Instrument: " + this.unInstrument.Description;
        }
    }
}
