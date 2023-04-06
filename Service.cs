namespace exercice2
{
    internal class Service
    {
        private string Nom;
        private string Adresse;
        public string GetNom()
        {
            return this.Nom;
        }
        public void SetNom(string value)
        {
            this.Nom=value;
        }
        public string GetAdresse()
        {
            return this.Adresse;
        }
        public void SetAdresse(string value)
        {
            this.Adresse=value;
        }
        public Service()
        {
        }
       public Service(string nom, string adresse)
        {
            this.SetNom(nom);
            this.SetAdresse(adresse);
        }
    }
}