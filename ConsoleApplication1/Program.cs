using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Övning 1
            int x = 0;
            while (x++ < 100)
            {
                if (x>0)
                Console.WriteLine(x);
            }

            */

            /* Övning 2
            string text = "Abc";
            string text1 = "";

            while (text1 != text)
            {
                Console.Write("Lösenord: ");
                text1 = Console.ReadLine();
                
            }

            Console.WriteLine("Rätt lösenord! ");
            */

            /* Önving 3
            while (true)
            {
                Console.WriteLine("Skrrrt! ");
            }

            */

            /* Övning 4

            int tal = 17;
            int n = 0;

            while (n++ != tal )
            {
                Console.WriteLine("Gissa ett tal mellan 1 till 100: ");
                string x = Console.ReadLine();
                int svar = int.Parse(x);

                if (svar > tal)
                {
                    Console.WriteLine("För högt!");
                }

                else if (svar < tal)
                {
                    Console.WriteLine("För lågt!");
                }

                else if (svar == tal)
                {
                    Console.WriteLine("Rätt!");
                    Console.WriteLine("Det tog dig {0} försök!", n);
                    break;
                }

                
            }  
            */

            /* Övning 5 (EJ KLAR)
            */

            /* Övning 6 (EJ KLAR)
            Console.WriteLine("Ange saldot på kontot (kr): ");
            string inmatat = Console.ReadLine();
            int saldo = int.Parse(inmatat);

            Console.WriteLine("Ange räntan (%): ");
            string inmatat1 = Console.ReadLine();
            int ränta = int.Parse(inmatat1);

            Console.WriteLine("Ange mål (kr): ");
            string inmatat2 = Console.ReadLine();
            int mål = int.Parse(inmatat2);

            int n = 0;

            int svar = saldo * ((ränta / 100 + 1) ^ mål);

            
            Console.WriteLine(svar);
            */
            
            

        }
    }
}
