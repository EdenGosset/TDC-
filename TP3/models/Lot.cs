using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.models
{
    abstract class Lot

    {
        private string numéro;
        private String propriétaire;
        private int surface;

        public Lot(String numéro, String propriétaire, int surface)
        {
            this.Numéro = numéro;
            this.propriétaire = propriétaire;
            this.Surface = surface;
        }

        public String Propriétaire
        {
            get
            {
                return this.propriétaire;
            }
        }

        public String Numéro
        {
            get
            {
                return this.numéro;
            }
            private set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Le numéro ne peut être vide");
                this.numéro = value;
            }
        }

        public int Surface
        {
            get
            {
                return this.surface;
            }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("La surface ne peut pas être négative");
                this.surface = value;
            }
        }

        public abstract int Tantième { get; }

        public abstract String TypeLot { get; }

        public override string ToString()
        {
            return "Lot numéro : " + this.numéro + "\n" +
            "Propriétaire : " + this.propriétaire + "\n" +
            "Surface : " + this.surface + "\n";
        }
    }
}
