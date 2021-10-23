using System;
using System.Collections.Generic;
using System.Text;

namespace Etudiant_Option
{
    class Inscription
    {
        string nom;
        string filiere;

        public Inscription(string Nom, string Filiere)
        {
            nom = Nom;
            filiere = Filiere;

        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Filiere
        {
            get { return filiere; }
            set
            {
                if (value == "GL" || value == "ASR" || value == "ABD")
                {
                    filiere = value;
                }
            }
        }
    }
}
