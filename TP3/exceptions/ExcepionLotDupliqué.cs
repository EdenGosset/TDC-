using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.exceptions
{
    class ExceptionLotDupliqué : ApplicationException
    {
        public ExceptionLotDupliqué(String nomImmeuble, String numéro): base("Ce lot existe déjà dans l'immeuble")
        {
            this.Numéro = numéro;
            this.NomImmeuble = nomImmeuble;
        }

        public String NomImmeuble
        {
            get; set;
        }

        public String Numéro
        {
            get; set;
        }

    }
}
