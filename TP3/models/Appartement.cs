using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.models
{
    internal class Appartement : Lot
    {
        private int étage;
        private int surfaceBacons;

        public Appartement(String numéro, String propriétaire, int surface, int étage, int surfaceBacons) :
        base(numéro, propriétaire, surface)
        {
            this.surfaceBacons = surfaceBacons;
            this.étage = étage
        }

        public int Etage
        {
            get
            {
                return this.étage;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("La surface ne peut pas être négative");
                this.étage = value;
            }
        }

        public int SurfaceBalcon
        {
            get
            {
                return this.surfaceBacons;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("La surface des balcons ne peut pas être négative");
                this.surfaceBacons = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
            "De type appartement, étage " + this.étage +
            ", bacon de surface " + this.surfaceBacons;
        }

        public override int Tantième
        {
            get
            {
                return (10 + this.étage) *
                (3 * this.Surface + this.surfaceBacons);
            }
        }

        public override String TypeLot
        {
            get
            {
                return "appartement";
            }
        }
    }
}
