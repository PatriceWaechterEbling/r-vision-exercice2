using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    internal class Colis
    {
        private string Adresse;
        private string Nom;
        private int numero;
        private bool ClientAbscent = false;

        public bool GetClientAbscent()
        {
            return this.ClientAbscent;
        }

        public void SetClientAbscent(bool value)
        {
            this.SetClientAbscent(value);
        }

        public string GetAdresse()
        {
            return this.Adresse;
        }

        public void SetAdresse(string value)
        {
            this.Adresse=value;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string value)
        {
            this.Nom=value;
        }
        public int GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(int value)
        {
            this.numero = value;
        }

        public Colis(bool clientAbscent)
        {
            this.ClientAbscent = clientAbscent;
            if (clientAbscent = true)
            {
                isClientAbscent();
            }
        }

        public Colis(string adresse, string nom, bool clientAbscent)
        {
            this.Adresse = adresse;
            this.Nom = nom;
            this.ClientAbscent = clientAbscent;
        }
        public Colis(string nom, bool clientAbscent)
        {
            this.Nom = nom;
            this.ClientAbscent = clientAbscent;
        }

        public Colis()
        {
            this.SetNumero(0);
        }

        public void isClientAbscent()
        {
            Service srv = new Service();
            this.Adresse = srv.GetAdresse();
        } 
    }
}
