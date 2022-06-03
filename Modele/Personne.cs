﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_conservatoire.Modele
{
    public abstract class Personne
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected string adresse;
        protected string mail;
        protected string tel;

        public Personne(int id, string nom, string prenom, string mail, string tel, string ad)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.tel = tel;
            this.adresse = ad;
        }

        public Personne()
        {

        }

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Mail { get => mail; }
        public string Tel { get => tel; set => tel = value; }

        public string Adresse { get => adresse; set => adresse = value; }
        public int Id { get => id; }

        public virtual string Description
        {

            get => this.nom + " " + this.prenom + ", " + this.mail + ", " + this.tel + ", " + this.adresse;
        }



    }
}
