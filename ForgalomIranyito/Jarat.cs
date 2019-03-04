using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgalomIranyito
{
    public class JaratKezelo
    {
        public class Jarat
        {

            public string jaratSzam;
            public string repterHonnan;
            public string repterHova;
            public DateTime indulas;
            public int keses;

            public Jarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                this.jaratSzam = jaratSzam;
                this.repterHonnan = repterHonnan;
                this.repterHova = repterHova;
                this.indulas = indulas;
                keses = 0;
            }

        }

        List<Jarat> jaratok = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            var y = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
            jaratok.Add(y);

        }

        public void Keses(string jaratSzam, int keses)
        {
            foreach (var e in jaratok)
            {
                if (jaratSzam.Equals(e.jaratSzam))
                {
                    if ((e.keses + keses) < 0)
                    {
                        throw new NegativKesesException(keses);
                    }
                    else
                    {
                        e.keses = keses;
                    }

                }

            }

        }
        //negativ exception


        private DateTime MikorIndul(string jaratSzam)
        {
            foreach (var e in jaratok)
            {
                if (jaratSzam.Equals(e.jaratSzam))
                {
                    return e.indulas.AddMinutes(e.keses);

                }
            }
            throw new ArgumentException(" Hiba :C ");
        }


        private List<string> JaratokRepuloterrol(string repter)
        {
            List<string> jaratokSzama = new List<string>();
            foreach (var e in jaratok)
            {
                if (jaratokSzama.Equals(e.repterHonnan))
                {
                    if (jaratokSzama.Equals(e.jaratSzam))
                    {
                        jaratokSzama.Add(e.repterHonnan);
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }

            }
            return jaratokSzama;

        }
    }


}
    


        
    

