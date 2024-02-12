using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.models
{
    internal class CamionBâché : VéhiculeChargeable
    {
        public CamionBâché(string immatriculation, double charge) : base(immatriculation, 4, charge, 20)  {    }

        public override double VitesseMaximale
        {
            get
            {
                double retVal = 0;

                if (this.Charge == 0)
                    retVal = 130;
                else if (this.Charge > 0 && this.Charge <= 3)
                    retVal = 110;
                else if (this.Charge > 3 && this.Charge <= 7)
                    retVal = 90;
                else if (this.Charge > 7)
                    retVal = 80;

                return retVal;
            }
        }

        public override string ToString()
        {
            return $"Camion Bâché {base.ToString()}";
        }
    }
}
