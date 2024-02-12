using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.models
{
    internal class Capitaine : Joueur
    {
        short nbSaisons;

        public Capitaine(short dossard, short nbButs, string nom, decimal salaireBase, short nbSaisons) : base(dossard, nbButs, nom, salaireBase)
        {
            this.NbSaisons = nbSaisons;
        }

        public short NbSaisons
        {
            get
            {
                return this.nbSaisons;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Le nombre de saisons doit être positif");
                }
                else
                {
                    this.nbSaisons = value;
                }
            }
        }
        public override decimal SalaireRéel
        {
            get
            {
                decimal retVal = base.SalaireBase * 1.5m;
                return retVal + (1 + 0.2m * this.NbSaisons);
            }
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.NbSaisons;
        }

    }
}
