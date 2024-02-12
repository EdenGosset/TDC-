using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.models
{
    internal class Lettre
    {
        public Lettre(String nomImmeuble, Lot leLot, double charges)
        {
            this.Texte = "Madame/Monsieur "
            + leLot.Propriétaire
            + "\n\nLe montant des charges de votre "
            + leLot.TypeLot
            + " situé "
            + nomImmeuble
            + " s'élève à "
            + charges
            + " Euros\n\nVeuillez croire en "
            + "l'expression de mes meilleurs "
            + "sentiments\n\n";

        }

        public override string ToString()
        {
            return this.Texte;
        }

        private String Texte { get; set; }
    }
}
