using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgalomIranyito
{
    class NegativKesesException: Exception
    {
        public NegativKesesException(int keses) : base("Nincs késés" + keses)
        {
            // Nincs késés
        }
    }
}
