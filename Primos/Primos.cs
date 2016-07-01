using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Primos
    {
        public int limiteDaLista = 20000;
        public int currentPosition = 0;

        public List<int> numeros = new List<int>();

        public void escreveLista()
        {
            int count = 2;
            while (count <= limiteDaLista)
            {
                numeros.Add(count);
                count++;
            }
        }

        public void marcaDeleta() {
            int currentValue = numeros.ElementAt(currentPosition);
            for (int i = currentPosition + 1; i < numeros.Count; i++)
            {
                if (numeros.ElementAt(i) % currentValue == 0)
                {
                    numeros.RemoveAt(i);
                }
            }
            currentPosition++;
            if (currentPosition < numeros.Count)
            {
                marcaDeleta();
            }
        }


        public void printNumeros()
        {
            foreach (var item in numeros)
            {
                Console.Write(item.ToString() + "; ");
            }
        }
    }
}
