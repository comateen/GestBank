using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque.Model
{
    public class Epargne : Compte
    {
        private DateTime _DernierRetrait;
        
        public DateTime DernierRetrait
        {
            get { return _DernierRetrait; }
            private set
            {                
                _DernierRetrait = value;
            }
        }
        
        public override void Retrait(double Montant)
        {
            double AncientSolde = Solde;
            base.Retrait(Montant);

            if (Solde != AncientSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }
    }
}
