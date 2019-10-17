using System;


namespace programaProva
{
    
class Program
{
        static void Main(string[] args)
        {
            string text, n;
            int number, count;

            Console.WriteLine("digite quantas palavras ou frases serão testadas: \n");
            n = Console.ReadLine();

            number = int.Parse(n);
            count = 0;


            // Loop com os textos
            while (count < number)
            {
               
                count = count + 1;

                Console.WriteLine("\n \n Qual a frase ou palavra {0} a ser testada? \n", (count));
                text = Console.ReadLine();



                //Printa o resultado
                if (IsPalindrome(text))
                {
                    //Console.WriteLine(test);
                    Console.WriteLine("\n {0} É PALÍNDROMO", text);
                }
                else
                {
                   // Console.WriteLine(test);
                    Console.WriteLine("\n {0} NÃO É PALÍNDROMO", text);
                }
            }
           
        }

        private static bool IsPalindrome(string text)
        {
            //Separa em caracteres e inverte.
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);

            //Transforma os caracteres em palavras
            string reverseWord = new string(letters);

            //Transforma tudo para minúsculas e testa
            if (RemoveOthers(text.ToLower()) == RemoveOthers(reverseWord.ToLower()))
                return true;
            else
                return false;
        }

        //Remove acentuação
        private static string RemoveOthers(string text)
        {
            text = text.Replace("À", "a");
            text = text.Replace("Â", "a");
            text = text.Replace("Á", "a");
            text = text.Replace("Ã", "a");
            
            text = text.Replace("à", "a");
            text = text.Replace("â", "a");
            text = text.Replace("á", "a");
            text = text.Replace("ã", "a");
            
            text = text.Replace("Ê", "e");
            text = text.Replace("É", "e");
            
            text = text.Replace("ê", "e");
            text = text.Replace("é", "e");

            text = text.Replace("I", "i");

            text = text.Replace("Ó", "o");
            text = text.Replace("Ô", "o");
            
            text = text.Replace("ó", "o");
            text = text.Replace("ô", "o");

            text = text.Replace("U", "u");
            text = text.Replace("Ú", "u");

            text = text.Replace("ú", "u");

            text = text.Replace(" ", "");
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(";", "");


            return text;
        }
    }
}