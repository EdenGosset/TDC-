using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP2.models
{
    internal abstract class Vehicule : IComparable
    {

        string immatriculation;

        public Vehicule(string immatriculation, double poidsAVide)
        {
            Immatriculation = immatriculation;
            PoidsAVide = poidsAVide;
        }
        public Vehicule(string immatriculation) : this(immatriculation, 1.000) { }

        public string Immatriculation
        {
            get { return immatriculation; }
            protected set
            {
                if (ValidateImmatriculation(value))
                {
                    immatriculation = value;
                }
                else
                {
                    throw new ArgumentException("L'immatriculation ne satisfait pas au format attendu (9AAA999).");
                }

            }
        }
        protected bool ValidateImmatriculation(string immatriculation)
        {
            Regex regex = new Regex(@"^\d{1}[A-Z]{3}\d{3}$");
            return regex.IsMatch(immatriculation);
        }
        public double PoidsAVide { get; set; }

        abstract public double VitesseMaximale { get; }

        abstract public double GetConsommation(double vitesse);


        public override string ToString()
        {
            return $"{Immatriculation}, p.v. {PoidsAVide} T, v.m. {VitesseMaximale} km/h";
        }


        public int CompareTo(object obj)

        {

            if (!(obj is Vehicule))

                throw new Exception("Le paramètre est de type incorrect.");

            return immatriculation.

            CompareTo(((Vehicule)obj).immatriculation);

        }
    }
}
