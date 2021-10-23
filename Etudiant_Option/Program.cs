using System;

namespace Etudiant_Option
{
    class Program
    {
        static void TriTabEtudiant(Etudiant [] et)
        {
            Etudiant tmp;
            for (int i = 0; i < et.Length; i++)
            {
                for (int j = i+1; j < et.Length; j++)
                {
                    if (et[i].Note < et[j].Note)
                    {
                        tmp = et[i];
                        et[i] = et[j];
                        et[j] = tmp;
                    }
                }
            }
        }
        static void AfficherInscri(Inscription[] ins,string op)
        {
            Console.WriteLine("les etudiants inscrits dans l'option " + op + ": ");
            foreach(Inscription e in ins)
            {
                if(e.Filiere == op)
                {
                    Console.Write(e.Nom + "\t");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Option[] filiere = new Option[3];
            filiere[0] = new Option(1, "GL", 2);
            filiere[1] = new Option(2, "ABD", 2);
            filiere[2] = new Option(3, "ASR", 1);
            Etudiant[] Te = new Etudiant[5];
            Inscription[] Tins = new Inscription[5];
            string nom;
            float note;
            int[] choix = new int[3];

            for (int i = 0; i < Te.Length; i++)
            {
                Console.Write("Etrer le nom: ");
                nom = Console.ReadLine();
                Console.Write("Entrer la note: ");
                note = float.Parse(Console.ReadLine());
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Entrer le choix " + (j + 1) + ": ");
                    choix[j] = int.Parse(Console.ReadLine());
                }

                Te[i] = new Etudiant(nom, note, choix);
            }

            TriTabEtudiant(Te);
            
            for(int i = 0; i < Te.Length; i++)
            {
                if (filiere[(Te[i].Choix1)-1].Capacite > 0)
                {
                    Tins[i] = new Inscription(Te[i].Nom, filiere[(Te[i].Choix1)-1].Nom);
                    filiere[(Te[i].Choix1) - 1].EtudiantInscrit();
                }
                else if (filiere[(Te[i].Choix2)-1].Capacite > 0)
                {
                    Tins[i] = new Inscription(Te[i].Nom, filiere[(Te[i].Choix2)-1].Nom);
                    filiere[(Te[i].Choix2) - 1].EtudiantInscrit();
                }
                else 
                {
                    Tins[i] = new Inscription(Te[i].Nom, filiere[(Te[i].Choix3)-1].Nom);
                    filiere[(Te[i].Choix3) - 1].EtudiantInscrit();
                }
            }

            AfficherInscri(Tins,"GL");
            AfficherInscri(Tins, "ABD");
            AfficherInscri(Tins, "ASR");
        }
    }
}
