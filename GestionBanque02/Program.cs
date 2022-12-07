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

            Banque b = new Banque();
            b.Nom = "Ma Banque";
            b.Ajouter(c);

            b["0000001"].Depot(500);
            b["0000001"].Retrait(300);

            Console.WriteLine(b["0000001"].Solde);
                        
            Console.ReadLine();
        }
    }    
}
