using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.exceptions
{
    internal class DossardDupliquéException : ApplicationException
    {
        public DossardDupliquéException(short dossard) : base("Le dossard " + dossard + "déjà utilisé")
        {
        }
        public short Dossart
        {
            get;
            set;
        }
    }
}
