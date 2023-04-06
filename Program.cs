// See https://aka.ms/new-console-template for more information
using exercice2;
using System.ComponentModel.Design;

internal class Program
{
    static Colis col = new Colis();
    static Employe emp = new Employe();
    static Punch punch = new Punch();
    private static void Main(string[] args)
    {
        Console.Title = "Bienvenue à l'exercice 2 de programmation Web";
        Console.WriteLine("Bienvenue à l'exercice 2 de programmation Web");
        Console.ForegroundColor = ConsoleColor.Green;
        ConstruireEmployes();
        punch.SetDateHeureArrivee(DateTime.Now);
        Console.WriteLine("\nBonjour entrée: " + punch.GetDateHeureArrivee().ToString() + "\nVotre taux horraire est de " + punch.GetSalaire().ToString() + "$/h");
        punch.SetDateHeurDepart(DateTime.Now);
        Vehicule voiture = new Vehicule("Equipe #1"); //oui je pourrais simplifier le code en ecrivant juste new("equipe #1");
        Console.WriteLine("\nAssignation véhicule: " + voiture.GetPlaque() + "\n");
        ConstruireColis();
        TimeSpan varTime = punch.GetDateHeurDepart() - punch.GetDateHeureArrivee();
        double gain = varTime.TotalHours * punch.GetSalaire() * .8; //retenu de 20% sur salaire
        if (varTime.TotalHours < 1) { gain = punch.GetSalaire() * .8; }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nAu revoir départ: " + punch.GetDateHeureArrivee().ToString() + "\nVos gains sont de " +  Math.Round(gain, 2).ToString() + "$");
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void ConstruireColis()
    {
        Service srv = new Service("Abscence", "18 rue de la nuée bleue,Strasbourg,67000");//adresse par défaut en cas d'absence du client
        Colis col1 = new Colis("333 Bd de la Cité-des-Jeunes, Gatineau, QC J8Y 6M4", "Philipe", true);
        Colis col2 = new Colis("625 Av. Sainte-Croix, Saint-Laurent, QC H4L 3X7", "George", true);
        Colis col3 = new Colis("7000 Rue Marie-Victorin, Montréal, QC H1G 2J6", "Sara", false);
        Colis col4 = new Colis("960 Rue Saint-Georges, Drummondville, QC J2C 6A2", "Maryse", false);
        Colis col5 = new Colis("3000 Av. Boullé, Saint-Hyacinthe, QC J2S 1H9", "Maurice", true);
        for (int x = 1; x <= 5; x++)
        {
            if (x == 1) col = col1;
            else if (x == 2) col = col2;
            else if (x == 3) col = col3;
            else if (x == 4) col = col4;
            else col = col5;
            Console.WriteLine("Colis#" + x + " usr=" + col.GetNom() + " add=" + col.GetAdresse());
            if (col.GetClientAbscent() == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" avail=" + col.GetClientAbscent().ToString() + "\talt=:" + srv.GetAdresse());
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

    }
    private static void ConstruireEmployes()
    {
        Employe emp1 = new Employe(1, 35.35, "Divano", "St-Hyacinte.ca");
        Employe emp2 = new Employe(2, 32.24, "Claudius", "Stratburgum.au");
        Employe emp3 = new Employe(3, 28.15, "Jurgie", "Rust.de");
        Employe emp4 = new Employe(4, 28.36, "Lala", "Bassel.ch");
        Console.WriteLine(emp1.GetNoEmploye() + ". " + emp1.GetNom() + "@" + emp1.GetAdresse());
        Console.WriteLine(emp2.GetNoEmploye() + ". " + emp2.GetNom() + "@" + emp2.GetAdresse());
        Console.WriteLine(emp3.GetNoEmploye() + ". " + emp3.GetNom() + "@" + emp3.GetAdresse());
        Console.WriteLine(emp4.GetNoEmploye() + ". " + emp4.GetNom() + "@" + emp4.GetAdresse());
        Console.Write("Entrez votre numéro d'employé: ");
        string saisie = Console.ReadLine();
        if (saisie.Length < 1)
        {
            Exception ex = new Exception("Numero d'identifiant invalide");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ex.Message + "\n" + ex.Source);
            Console.ForegroundColor = ConsoleColor.Green;
            return;
        }
        int idemploye = int.Parse(saisie);
        Console.Clear();
        if (idemploye > 0 && idemploye < 5)
        {
            if (idemploye == 1) emp = emp1;
            else if (idemploye == 2) emp = emp2;
            else if (idemploye == 3) emp = emp3;
            else emp = emp4;
            Console.WriteLine("Ravi de vous revoir " + emp.GetNom() + "@" + emp.GetAdresse());
            punch.SetSalaire(emp.GetSalaire());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            ApplicationException ex =new("Identifiant invalide\nAdieu!");
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}