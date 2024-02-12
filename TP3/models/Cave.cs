using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.models
{
    internal class Cave : Lot, INonHabitable
    {

        public Cave(String numéro, String propriétaire, int surface) :base(numéro, propriétaire, surface)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "De type cave.";
        }

        public override int Tantième
        {
            get
            {
                return 14 * this.Surface;
            }
        }

        public override String TypeLot
        {
            get
            {
                return "cave";
            }
        }

        public Boolean EstEspaceFermé
        {
            get
            {
                return true;
            }
        }
    }
}
