namespace exercice2
{
    internal class Vehicule:Service
    {
        private Service Service;
        private string Plaque;
        public string GetPlaque()
        {
            return this.Plaque;
        }

        public void SetPlaque(string value)
        {
            this.Plaque=value;
        }
        public Vehicule()
        {
            this.Plaque="Patrice 1st";
        }
        public Vehicule(Service service, string plaque)
        {
            this.Service = service;
            this.Plaque=plaque;
        }
        public Vehicule(string plaque, string nom, string adresse) : base(nom, adresse)
        {
            this.Service.SetNom(nom);
            this.Service.SetAdresse(adresse);
            this.Plaque=plaque;
        }

        public Vehicule(string plaque)
        {
            this.Plaque = plaque;
        }

        public Vehicule(Service service)
        {
            this.Service = service;
        }
    }
}