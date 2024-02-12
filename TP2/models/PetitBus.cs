using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.models
{
    internal class PetitBus : Vehicule
    {

        public PetitBus(string immatriculation) : base(immatriculation, 4.000)   {     }


        public override double VitesseMaximale
        {
            get
            {
                return 150;
            }
        }

        public override double GetConsommation(double vitesseRéelle)
        {
            return (vitesseRéelle / 5) + this.PoidsAVide;
        }

        public override string ToString()
        {
            return $"Petit Bus {base.ToString()}";
        }
    }
}
