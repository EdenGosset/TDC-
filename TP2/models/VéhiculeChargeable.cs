using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.models
{
    internal abstract class VéhiculeChargeable : Vehicule
    {

        double charge;

        public VéhiculeChargeable(string immatriculation, double poidsAVide, double charge, double chargeMaximale) : base(immatriculation, poidsAVide)
        {
            this.ChargeMaximale = chargeMaximale;
            this.Charge = charge;
        }

        public double ChargeMaximale { get; set; }

        public double Charge
        {
            get { return this.charge; }
            set
            {
                if (value <= this.ChargeMaximale && value >= 0)
                {
                    charge = value;
                }
                else
                {
                    throw new Exception($"La charge ne peut pas dépasser la charge maximale : {this.ChargeMaximale}  ou être négative.");
                }
            }
        }

        public override Double GetConsommation(Double vitesseRéelle)

        {
            return (vitesseRéelle / 5) + (this.PoidsAVide + this.Charge);
        }


        public override string ToString()
        {
            return $"{base.ToString()}, charge {this.Charge} T, charge max. {this.ChargeMaximale}";
        }


        // Operator overloading

        static public Boolean operator <(VéhiculeChargeable v1, VéhiculeChargeable v2)
        {
            Double toTransfer;

            toTransfer = Math.Min(v1.ChargeMaximale - v1.Charge, v2.Charge);
            v1.Charge += toTransfer;
            v2.Charge -= toTransfer;
            return (v2.Charge != 0);
        }
        static public Boolean operator >(VéhiculeChargeable v1, VéhiculeChargeable v2)
        {
            return v2 < v1;
        }

    }
}
