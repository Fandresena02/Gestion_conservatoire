using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque.Modele
{
    class Adherent : Personne
    {
        int niveau;
        public Adherent(int id, string nom, string prenom, string ad, string mail, string tel, int niveau) : base(id, nom, prenom, ad, mail, tel)
        {
            this.niveau = niveau;
        }

        public int Niveau { get => niveau; }

        public override string Description
        {
            get => base.Description + " Niveau: " + this.niveau;
        }

    }
}
