using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.models
{
    internal class Garage : Lot, INonHabitable
    {

        private Boolean fermé;
        public Garage(String numéro, String propriétaire, int surface, Boolean fermé) : base(numéro, propriétaire, surface)
        {
            this.fermé = fermé;
        }

        public Boolean Fermé
        {
            get
            {
                return this.fermé;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "De type garage " + ((this.fermé == true) ? "ouvert" : "fermé");
        }

        public override int Tantième
        {
            get
            {
                return 14 * ((this.Fermé == true) ? 2 : 1) * this.Surface;
            }
        }

        public override String TypeLot
        {
            get
            {
                return "garage";
            }
        }
        public Boolean EstEspaceFermé
        {
            get { return this.fermé; }
        }
    }
}
