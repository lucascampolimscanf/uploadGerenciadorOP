using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = { "Lucas", "Jefersom", "Ganso" };
            {
            foreach (String nome in nomes)
                Console.WriteLine(nome);
                Console.ReadKey();
            }
        }
    }
}
