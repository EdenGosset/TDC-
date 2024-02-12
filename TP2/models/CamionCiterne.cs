using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.models
{
    internal class CamionCiterne : VéhiculeChargeable
    {
        public CamionCiterne(string immatriculation, double charge) : base(immatriculation, 3, charge, 10)     {     }

        public override double VitesseMaximale
        {
            get
            {
                double retVal = 0;

                if (this.Charge == 0)
                    retVal = 130;
                else if (this.Charge > 0 && this.Charge <= 1)
                    retVal = 110;
                else if (this.Charge > 1 && this.Charge <= 4)
                    retVal = 90;
                else if (this.Charge > 4)
                    retVal = 80;

                return retVal;
            }
        }

        public override string ToString()
        {
            return $"Camion Citerne {base.ToString()}";
        }
    }
}
