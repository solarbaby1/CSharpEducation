using System;

namespace Practice2.Task1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // a. for
            Console.WriteLine("for");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();



            
            
            
            // b. while
            Console.WriteLine("while") ;

            int q = 0;

            while (q <= 10)
            {

                Console.WriteLine(q);
                q++;
            }

            Console.ReadKey();




            
            
            // с. do while
            Console.WriteLine("do while") ;


            int w = 0;
            do
            {
                Console.WriteLine(w);
                w++;
            }
            while (w < 10);

            Console.ReadKey();



            
            
            
            // d. for вывод фразы с пробелами
            
            
            Console.WriteLine("for вывод фразы с пробелами");

            Console.WriteLine("Введите 3 слова:");

            string resul = "";

            for (int i = 0; i < 3; i++)
            {
                string word = Console.ReadLine();
                resul += word + " ";
            }

            Console.WriteLine("Полная фраза:");
            Console.WriteLine(resul);

            Console.ReadKey();

            
            
            
            
            
            
            
            // е. while вывод фразы с пробелами


            Console.WriteLine("while вывод фразы с пробелами");

            Console.WriteLine("Введите 3 слова:");

            string resu = "";

            int r = 0;


            while (r < 3)
               


            {
                string word = Console.ReadLine();
                resu += word + " ";
                r++;

            }

            Console.WriteLine("Полная фраза:");
            Console.WriteLine(resu);

            Console.ReadKey();


            // F. dowhile вывод фразы с пробелами


            Console.WriteLine("dowhile вывод фразы с пробелами");

            Console.WriteLine("Введите 3 слова:");

            string res = "";

            int a = 0;


            do


            {
                string word = Console.ReadLine();
                res += word + " ";
                a++;

            }
            while (a < 3);

            Console.WriteLine("Полная фраза:");
            Console.WriteLine(res);

            Console.ReadKey();






            // Метры в километры


            Console.WriteLine("метры в километры");

            Console.WriteLine("М=");

            int x= 
           
            











        }
    }
    
}













