using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.exceptions
{
    internal class CapitaineDupliquéException : ApplicationException
    {

        public CapitaineDupliquéException() : base("Le capitaine est déjà défini")
        {
        }


    }
}
