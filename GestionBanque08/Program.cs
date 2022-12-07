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
            Personne p = new Personne("Doe", "John", new DateTime(2000, 1, 1));

            Courant c = new Courant("0000001", p);

            Epargne c2 = new Epargne("0000002", p);

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
            Console.WriteLine();
            foreach(KeyValuePair<string, Compte> kvp in b.Comptes)
            {
                kvp.Value.AppliquerInteret();
            }
            
            Console.WriteLine(b["0000001"].Solde);
            Console.WriteLine(b["0000002"].Solde);
            Console.WriteLine();

            //Utilisations des interfaces
            ICustomer Cu = b["0000001"];
            Cu.Depot(40);
            Cu.Retrait(20);
            Console.WriteLine(Cu.Solde);

            IBanker Ba = b["0000001"];
            Ba.AppliquerInteret();

            Console.WriteLine(b.AvoirDesComptes(p));

            Console.ReadLine();
        }
    }
}
