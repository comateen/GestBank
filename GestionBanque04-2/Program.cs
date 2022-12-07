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

            c.Depot(500);
            c.Retrait(300);
            c2.Depot(100);
            c2.Retrait(5000);

            Console.WriteLine(c.Solde);
            Console.WriteLine(c2.Solde);

            Console.ReadLine();
        }
    }
}
