using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, n;
            int number, count, lentext, lentext4, numeroas, palavrasas;

            Console.WriteLine("digite quantas palavras serão testadas: \n");
            n = Console.ReadLine();

            number = int.Parse(n);
            count = 0;
            numeroas = 0;
            lentext = 0;
            lentext4 = 0;
            palavrasas = 0;

            List<string> palavras;
            palavras = new List<string>();


            // Loop com os textos
            while (count < number)
            {

                count = count + 1;

                Console.WriteLine("\n \n Qual a palavra {0} a ser testada? \n", (count));
                text = Console.ReadLine();

                //Passando pra minusculas
                text = text.ToLower();

                //Contando a quantidade de as
                numeroas = text.Length - text.Replace("a", "").Length;
                if (numeroas >= 3)
                {
                    palavrasas += 1;
                }


                //Verificando o tamanho
                lentext = text.Length;

                if (lentext >= 4)
                {
                    lentext4 += 1;
                }


                //Adicionando pra lista
                palavras.Add(text);
            }

            //Ordenando alfabeticamente
            palavras.Sort();

            
            //Printando tudo e gg
            Console.WriteLine("\n \n A quantidade de palavras com a letra 'a' é: {0} \n", palavrasas );
            Console.WriteLine("\n \n A quantidade de palavras com mais de 4 letras é: {0} \n", lentext4);
            Console.WriteLine("\n \n A lista de palavras em ordem alfabética: \n ");
            foreach (var item in palavras)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

