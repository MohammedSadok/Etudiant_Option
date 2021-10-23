using System;
using System.Collections.Generic;
using System.Text;

namespace Etudiant_Option
{
    class Option
    {
        int id;
        string nomOption;
        int capacite;
        public Option(int Id, string Nom, int Capacite)
        {
            nomOption = Nom;
            id = Id;
            capacite = Capacite;
        }
        public int Capacite
        {
            get { return capacite; }
            set { capacite = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nomOption; }
            set 
            {
                if (value == "GL" || value == "ASR" || value == "ABD")
                {
                    nomOption = value;
                }
            }
        }
        public void EtudiantInscrit()
        {
            capacite--;
        }
    }
}
