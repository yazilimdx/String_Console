using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumle giriniz(Bolsuk Olmayacak bicimde > xxxxx,yyyyy):");
            string str = Console.ReadLine();
           

            char[] array = str.ToCharArray();

            int kelimesayi=0;
            //int sayitut=0;
          
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]==',')
                    {
                    kelimesayi = i;
                    break;
                    }
                }
          
           string kelimeal = str.Substring(0, kelimesayi);
           int sayial = Convert.ToInt32(str.Substring(kelimesayi+1,str.Length-kelimesayi-1));

            Console.WriteLine(kelimeal);
          
            array = kelimeal.ToCharArray();
          

            array[sayial - 1] = ' ';

            char[] array1 = new char[array.Length];

            int say = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array[i]!=' ')
                {
                    array1[say] = array[i];
                    say++;
                }

                
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i]);
            }

            

           // array[sayial-1] =' ';

            
          
               
        

           

          

           


            Console.ReadKey();
        }
    }
}
