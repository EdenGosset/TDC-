using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    internal class Joueur : IComparable
    {

        short dossard;
        short nbButs;
        string nom;
        decimal salaireBase;

        public Joueur(short dossard, short nbButs, string nom, decimal salaireBase)
        {
            this.Dossard = dossard;
            this.NbButs = nbButs;
            this.Nom = nom;
            this.SalaireBase = salaireBase;
        }

        public Joueur(short dossard, string nom, decimal salaireBase)
        {
            this.Dossard = dossard;
            this.NbButs = 0;
            this.Nom = nom;
            this.SalaireBase = salaireBase;
        }

        public short Dossard
        {
            get
            {
                return this.dossard;
            }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Le dossard doit être positif");
                }
                else
                {
                    this.dossard = value;
                }
            }
        }

        public short NbButs
        {
            get
            {
                return this.nbButs;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Le nombre de buts doit être positif et supérieur à 0");
                }
                else
                {
                    this.nbButs = value;
                }
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                value = value.ToUpper().Trim();
                if (value == null || value.Length < 2)
                {
                    throw new Exception("Le nom ne peut pas être null ou inférieur à 2 caractères");
                }
                this.nom = value;

            }
        }

        public decimal SalaireBase
        {
            get
            {
                return this.salaireBase;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Le salaire doit être positif");
                }
                this.salaireBase = value;
            }
        }

        public virtual decimal SalaireRéel
        {
            get
            {
                return this.salaireBase + (this.nbButs * 0.05m);
            }
        }

        public override string ToString()
        {
            return "Joueur : " + this.nom + " - Dossard : " + this.dossard + " - Nombre de buts : " + this.nbButs + " - Salaire : " + this.salaireBase;
        }



        public int CompareTo(object obj)
        {
            int retVal = 0;
            if (!(obj is Joueur))
            {
                throw new ArgumentException("Îl doit s'agir d'un joueur");
            }
            Joueur j = (Joueur)obj;

            retVal = -(this.SalaireRéel.CompareTo(j.SalaireRéel));

            return retVal;
        }
    }
}
