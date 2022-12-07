using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public interface ICustomer
    {
        double Solde { get; }
        void Depot(double Montant);
        void Retrait(double Montant);
    }
}
