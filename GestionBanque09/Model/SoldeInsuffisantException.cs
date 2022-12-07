using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionBanque.Model
{
    public class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : base("Solde Insuffisant!!")
        {

        }
    }
}
