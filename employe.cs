using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Employe
    {
        private Service Service;
        private int NoEmploye;
        private string Nom;
        private string Adresse;
        private double Salaire;

        public double GetSalaire()
        {
            return this.Salaire;
        }

        public void SetSalaire(double value)
        {
            this.Salaire = value;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string value)
        {
            this.Nom = value;
        }

        public string GetAdresse()
        {
            return this.Adresse;
        }

        public void SetAdresse1(string value)
        {
            this.Adresse = value;
        }

        public int GetNoEmploye()
        {
            return this.NoEmploye;
        }

        public void SetNoEmploye(int value)
        {
            this.NoEmploye=value;
        }

        public Service GetService()
        {
            return this.GetService();
        }

        public void SetService(Service value)
        {
            this.Service=value;
        }

        public Employe() { }
        public Employe( int NoEmploye) {
            this.NoEmploye=NoEmploye;
        }

        public Employe(int noEmploye, Service service) : this(noEmploye)
        {
            this.Service=service;
        }

        public Employe(Service service)
        {
            this.Service=service;
        }
        public Employe(int noEmploye,double Salaire, string nom, string adresse) 
        {
            this.Salaire = Salaire;
            this.NoEmploye = noEmploye;
            this.Nom=nom;
            this.Adresse=adresse;
        }

        public Employe(int noEmploye, string nom, string adresse) 
        {
            Service srv = new Service();
            this.NoEmploye=noEmploye;
            srv.SetNom(nom);
            srv.SetAdresse(adresse);
            this.Service=srv;
        }
        public Employe(string nom, string adresse)
        {
            Service srv = new Service();
            srv.SetNom(nom);
            srv.SetAdresse(adresse);
            this.Service=srv;
        }
    }
}
