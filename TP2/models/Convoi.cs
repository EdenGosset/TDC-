using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.models
{
    internal class Convoi
    {

        private List<Vehicule> leConvoi;

        public Convoi()
        {
            leConvoi = new List<Vehicule>();
        }

        public int NbrVehicules
        {
            get { return leConvoi.Count; }
        }

        public Double VitesseMaximale
        {
            get
            {
                double vitesseMax = 0;
                foreach (Vehicule v in this.leConvoi)
                {
                    if (v.VitesseMaximale > vitesseMax || vitesseMax == 0)
                    {
                        vitesseMax = v.VitesseMaximale;
                    }
                }
                return vitesseMax;
            }
        }
        public double VitesseMaximale2 => this.leConvoi.Min(v => v?.VitesseMaximale) ?? 0;


        public Double GetConsommation(Double vitesseRéelle)
        {
            Double consommation = 0;
            foreach (Vehicule v in this.leConvoi)
            {
                consommation += v.GetConsommation(vitesseRéelle);
            }
            return consommation;
        }


        public Boolean Ajouter(Vehicule v)
        {
            Boolean retVal = (this[v.Immatriculation] == null);

            if (retVal == true)
            {
                this.leConvoi.Add(v);
                retVal = true;
            }

            return retVal;
        }

        public Boolean Supprimer(String immatriculation)
        {
            Boolean retVal = (this[immatriculation] != null);
            if (retVal == true)
            {
                this.leConvoi.Remove(this[immatriculation]);
                retVal = true;
            }
            return retVal;
        }

        public void TrierParPlaques()
        {
            this.leConvoi.Sort();
        }

        public override string ToString()
        {
            String retVal = "";
            this.TrierParPlaques();

            foreach (Vehicule v in this)
                retVal += "- " + v + "\n";

            retVal += "Taille : " + this.NbrVehicules;
            retVal += "\nVitesse maximale : " + this.VitesseMaximale;
            retVal += "\nConsommation totale à :";
            for (int vitesse = 0; vitesse <= this.VitesseMaximale; vitesse += 10)
                retVal += "\n- " + vitesse + " km/h : "
                + this.GetConsommation(vitesse) + " litres.";

            return retVal;
        }


        // Indexer
        public IEnumerator GetEnumerator()
        {
            return leConvoi.GetEnumerator();
        }

        public Vehicule this[String immatriculation]
        {
            get
            {
                Vehicule retVal = null;
                foreach (Vehicule v in this.leConvoi)
                    if (v.Immatriculation == immatriculation)
                    {
                        retVal = v;
                        break;
                    }
                return retVal;
            }
        }
    }
}
