using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.exceptions;

namespace TP3.models
{
    internal class Immeuble
    {

        private String nomImmeuble;
        private SortedList<String, Lot> lesLots;
        private int totauxTantièmes;

        public Immeuble(String nomImmeuble)
        {
            this.nomImmeuble = nomImmeuble;
            this.lesLots = new SortedList<string, Lot>();
        }

        public void AjouterLot(Lot leLot)
        {
            if (this.lesLots.ContainsKey(leLot.Numéro))
                throw new ExceptionLotDupliqué(this.nomImmeuble, leLot.Numéro);

            this.lesLots.Add(leLot.Numéro, leLot);
            this.totauxTantièmes += leLot.Tantième;

        }

        public Boolean SupprimerLot(String numéro)
        {
            Boolean retVal = this.lesLots.ContainsKey(numéro);
            if (retVal == true)
            {
                this.totauxTantièmes -= this.lesLots[numéro].Tantième;
                this.lesLots.Remove(numéro);
            }
            return retVal;
        }

        public Lot this[string numéro]
        {
            get
            {
                return this.lesLots[numéro];
            }
        }

        public IEnumerator<Lot> GetEnumerator()
        {
            return this.lesLots.Values.ToList<Lot>().GetEnumerator();
        }

        public List<Lettre> EnvoyerLettres(double chargesDuMois)
        {
            List<Lettre> retVal = new List<Lettre>();

            foreach (Lot l in this.lesLots.Values)
                retVal.Add(new Lettre(this.nomImmeuble, l, chargesDuMois * l.Tantième / this.totauxTantièmes));

            return retVal;
        }

        public int TotauxTantièmes
        {
            get
            {
                return this.totauxTantièmes;
            }
        }

        public double PourcentageHabitable
        {
            get
            {
                int compteurNonHabitables = 0;

                foreach (Lot l in this.lesLots.Values)
                {
                    if (l is INonHabitable)
                        compteurNonHabitables++;
                }                    

                return (this.lesLots.Count - compteurNonHabitables) / this.lesLots.Count * 100;
            }
        }
    }
}
