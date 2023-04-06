using System;

namespace exercice2
{
    public class Punch
    {
        private DateTime dateHeureArrivee;
        private DateTime dateHeureDepart;
        private double Salaire = 0;

        public Punch(DateTime dateHeureArrivee)
        {
            this.dateHeureArrivee=dateHeureArrivee;
        }

        public Punch()
        {
            this.dateHeureArrivee = DateTime.Now;
            this.dateHeureDepart=this.GetDateHeureArrivee();
            this.SetSalaire(25.56);
        }
        public Punch(double Salaire)
        {
            this.dateHeureArrivee = DateTime.Now;
            this.dateHeureDepart = this.GetDateHeureArrivee();
            this.Salaire=Salaire;
        }

        public DateTime GetDateHeureArrivee()
        {
            return this.dateHeureArrivee;
        }

        public void SetDateHeureArrivee(DateTime value)
        {
            this.dateHeureArrivee=value;
            return;
        }

        public DateTime GetDateHeurDepart()
        {
            return this.dateHeureDepart;
        }

        public void SetDateHeurDepart(DateTime value)
        {
            this.dateHeureDepart=value;
        }

        public double GetSalaire()
        {
            return this.Salaire;
        }

        public void SetSalaire(double value)
        {
            this.Salaire = value;        
        }
    }
}