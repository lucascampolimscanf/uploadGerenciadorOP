using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CalculadoraDeCambio
{
    class Program
    {
        public struct Lista
        {
            public int id;
            public String moeda;
            public float cambio;

        }
        static int Main(string[] xuxa)
        {
            Lista[] lista = new Lista[3];
            lista[0].id = 1;
            lista[0].moeda = "USD";
            lista[0].cambio = 1.0f;
            lista[1].id = 2;
            lista[1].moeda = "BRL";
            lista[1].cambio = 5.227f;
            lista[2].id = 3;
            lista[2].moeda = "EUR";
            lista[2].cambio = 0.823f;
            int id_para, id_de;
            int op = -1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("CASA DE CÂMBIO MUITO DINHEIRO\n");
                Console.WriteLine("Qual moeda deseja converter? \n");
                foreach (Lista p in lista)
                {
                    Console.WriteLine("[" + p.id + "] " + p.moeda);
                }
                Console.WriteLine("[0] Fechar programa!\n");
                Console.Write(" > ");
                ConsoleKeyInfo UserInput = Console.ReadKey();
                try
                {
                    op = int.Parse(UserInput.KeyChar.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\nOpção inválida! :(");
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                if (op == 0)
                {
                    break;
                }
                if (op < 0 || op > lista.Length)
                {
                    Console.WriteLine("\n\nOpção inválida! :(\n");
                    Thread.Sleep(2000);
                    continue;
                }
                id_de = op - 1;
                Console.WriteLine("\n\nPara qual moeda deseja fazer o câmbio? \n");
                foreach (Lista p in lista)
                {
                    Console.WriteLine("[" + p.id + "] " + p.moeda);
                }
                Console.WriteLine("[0] Fechar programa!\n");
                Console.Write(" > ");
                UserInput = Console.ReadKey();
                try
                {
                    op = int.Parse(UserInput.KeyChar.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\nOpção inválida! :(");
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                if (op == 0)
                {
                    break;
                }
                if (op < 0 || op > lista.Length)
                {
                    Console.WriteLine("\n\nOpção inválida! :(\n");
                    Thread.Sleep(2000);
                    continue;
                }
                id_para = op -1;
                Console.WriteLine("\n\nQual o valor do câmbio? \n");
                Console.Write(" > ");
                float bolso = 0;
                try
                {
                    bolso = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\nOpção inválida! :(");
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                float recebeCambio = lista[id_para].cambio / lista[id_de].cambio * bolso;
                Console.WriteLine("\nResultado: " + recebeCambio + "\n");
                Console.WriteLine("Pressione alguma tecla para continuar.. ");
                Console.ReadKey();
            }
            Console.WriteLine("\n\nFechando programa! ");
            Thread.Sleep(1500);
            return 0;
        }
    }
}
