using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTema2
{
    public class Asignare
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);

            //Console.Read(); //holds the console open until a key is pressed

            //a=2 in final pt ca este definit in linia 14 ca fiind (a=2) iar valoarea initiala 3 este suprascrisa
            //b=5 in final pt ca este definit in linia 15 ca fiind (b=5) iar valoarea initiala 4 din linia 14 este suprascrisa
            //c=20 in final pt ca este definit in linia 15 ca fiind b (=4 din linia 14) * 5 (din linia 15)

            Exercitiul2();
            Exercitiul3();
            Exercitiul4();
            Exercitiul5();
            Exercitiul6();
            Exercitiul7();
            Exercitiul8();
        }
        static void Exercitiul2()
        {
            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);

            //Console.Read(); //holds the console open until a key is pressed

            //este un inline if, se compileaza si returneaza 4 pentru ca d=3.95 care nu este mai > 4 
        }
        static void Exercitiul3()
        {
            int a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);

            //Console.Read(); //holds the console open until a key is pressed

            //Nu se afiseaza nimic pentru ca primul if = false 
        }
        static void Exercitiul4()
        {
            int suma = 0;
            for (int i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma este: " + suma);

            //Console.Read(); //holds the console open until a key is pressed

            //Suma este 45 pentru ca se calculeaza suma de la 1 la 9
        }

        static void Exercitiul5()
        {
            int n = 1;
            for (int i = 1; i < 13; i++)
            {
                n = n * i;
            }
            Console.WriteLine("n! este: " + n);

            //Console.Read(); //holds the console open until a key is pressed
        }

        static void Exercitiul6()
        {
            int x = 10;
            int y = 20;
            int z = 3;

            Console.WriteLine("cel mai mic numar dintre: " + x + " " + y + " " + z + " este: ");

            if (x < y)
            {
                if (x < z)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    if (z < y)
                    {
                        Console.WriteLine(z);
                    }
                    else
                    {
                        Console.WriteLine(y);
                    }
                }
            }
            else
            {
                if (y < z)
                {
                    Console.WriteLine(y);
                }
                else
                {
                    if (z < x)
                    {
                        Console.WriteLine(z);
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                }
            }

            //Console.Read(); //holds the console open until a key is pressed
        }

        static void Exercitiul7()
        {
            int a = 2;
            if (a % 2 == 0)
            {
                Console.WriteLine("numarul " + a + " este par");
            }
            else
            {
                Console.WriteLine("numarul " + a + " este impar");
            }

            //Console.Read(); //holds the console open until a key is pressed
        }
        static void Exercitiul8()
        {
            int a = 3;
            switch (a)
            {
                case 1: 
                    Console.WriteLine("numarul " + a + " corespunde zilei de Luni");
                    break;
                case 2:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Marti");
                    break;
                case 3:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Miercuri");
                    break;
                case 4:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Joi");
                    break;
                case 5:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Vineri");
                    break;
                case 6:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Sambata");
                    break;
                case 7:
                    Console.WriteLine("numarul " + a + " corespunde zilei de Duminica");
                    break;
                default:
                    Console.WriteLine("numarul " + a + " nu corespunde unei zi a saptamanii");
                    break;
            }

            Console.Read(); //holds the console open until a key is pressed
        }
    }

}
