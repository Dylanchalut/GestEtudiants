using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GestEtudiants.Classe
{
     public class Personne
    {
        //Attribut
        private string nom;
        private string prenom;
        private DateTime date_naissance;

        public Personne(string nom = "", string prenom = "", DateTime date_naissance = default(DateTime))
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naissance = date_naissance;
        }

        public DateTime DateNaissance
        {
            get { return this.date_naissance; }
            set{ this.date_naissance = value;}
        }

        public string Prenom
        {
            get { return this.nom; }
            set {
                Regex R = new Regex("^[A-Z]{1}[a-z]{1,25}$");
                if (R.IsMatch(value)) this.nom = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set {
                Regex R = new Regex("^[A-Z]{1}[a-z]{1,25}$");
                if (R.IsMatch(value)) this.nom = value; }
        }

        public int Age()
        {
            //calculer l'âge
            int age = DateTime.Now.Year - date_naissance.Year;
            //Diminuer l'age de un si la date d'anniversaire n'est pas encore arrivée
            if (DateTime.Now.Month < date_naissance.Month ||
                (DateTime.Now.Month == date_naissance.Month && DateTime.Now.Day < date_naissance.Day))
                age--;
            return age;
        }

        public int somme(int a,int b)
        {
            return a + b;
        }
    }
}
