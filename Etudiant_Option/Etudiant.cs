using System;
using System.Collections.Generic;
using System.Text;

namespace Etudiant_Option
{
    class Etudiant
    {
        string nom;
        float note;
        int choix1;
        int choix2;
        int choix3;
        public Etudiant(string Nom, float Note, int[] Choix)
        {
            nom = Nom;
            note = Note;
            choix1 = Choix[0];
            choix2 = Choix[1];
            choix3 = Choix[2];
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public float Note
        {
            get { return note; }
            set { note = value; }
        }
        public int Choix1
        {
            get { return choix1; }
            set { choix1 = value; }
        }
        public int Choix2
        {
            get { return choix2; }
            set { choix2 = value; }
        }
        public int Choix3
        {
            get { return choix3; }
            set { choix3 = value; }
        }
        
    }
}
