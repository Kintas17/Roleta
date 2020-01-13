using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testecxv
{
    class rodar
    {
        
        

        private const string cruz = "X.";
        private int  nnumero = 0;
        private bool[] numeros = new bool[37];
        private List<int> sorteia(int q, int max)
        {
            Random rnd = new Random();
            List<int> s = new List<int>();
            for (int i = 0; i < q; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, max);
                while (s.Contains(tmp));
                s.Add(tmp);
            }
            s.Sort();
            return s;
        }

        private List<int>  ns;
       
        public List<int> nsorteio => ns = sorteia(1,36);

        public string numero(int n)
        {
            if (numeros[n]) { numeros[n] = false; nnumero--; }
            else if (nnumero < 1) { numeros[n] = true; nnumero++; }
            if (numeros[n]) return cruz; else return "";
        }
        

    }
}
