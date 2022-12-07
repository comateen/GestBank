using GestionBanque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne()
            {
                Nom = "John",
                Prenom = "Doe",
                DateNaiss = new DateTime(2000, 1, 1)
            };

            Courant c = new Courant();
            c.Numero = "0000001";
            c.Titulaire = p;

            Epargne c2 = new Epargne();            
            c2.Numero = "0000002";
            c2.Titulaire = p;

            Banque b = new Banque();
            b.Nom = "Ma Banque";
            b.Ajouter(c);
            b.Ajouter(c2);

            b["0000001"].Depot(500);
            b["0000001"].Retrait(200);
            b["0000002"].Depot(5000);
            b["0000002"].Retrait(200);

            Console.WriteLine(b["0000001"].Solde);
            Console.WriteLine(b["0000002"].Solde);
            Console.WriteLine(b.AvoirDesComptes(p));

            Console.ReadLine();
        }
    }
}
