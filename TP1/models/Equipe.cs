using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    internal class Equipe
    {

        private List<Joueur> joueurs;

        public Equipe()
        {
            this.joueurs = new List<Joueur>();
        }

        public void Ajouter(Joueur jNouveau)
        {
            if (this[jNouveau.Dossard] != null)
            {
                throw new DossardDupliquéException(jNouveau.Dossard);
            }
            if (jNouveau is Capitaine && this.PossèdeUnCapitaine)
            {
                throw new CapitaineDupliquéException();
            }
            this.joueurs.Add(jNouveau);
            this.joueurs.Sort();

        }

        public bool PossèdeUnCapitaine
        {
            get
            {
                foreach (Joueur j in this.joueurs)
                {
                    if (j is Capitaine)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public decimal TotalSalaireRéels
        {
            get
            {
                decimal total = 0m;
                foreach (Joueur j in this.joueurs)
                {
                    total += j.SalaireRéel;
                }
                return total;
            }
        }

        public decimal MoyenneSalairesRéels
        {
            get
            {
                return this.TotalSalaireRéels / this.joueurs.Count;
            }
        }

        public override string ToString()
        {
            string retVal = "Equipe : \n";
            foreach (Joueur j in this.joueurs)
            {
                retVal += j.ToString() + "\n";
            }
            return retVal;
        }


        // Indexeur
        public Joueur this[short dossard]
        {
            get
            {
                foreach (Joueur j in this.joueurs)
                {
                    if (j.Dossard == dossard)
                    {
                        return j;
                    }
                }
                return null;
            }
        }

        public IEnumerator<Joueur> GetEnumerator()
        {
            return this.joueurs.GetEnumerator();
        }

    }
}
