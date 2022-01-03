using System;

namespace _1049_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Entrada = Console.ReadLine();
            String Entrada1 = Console.ReadLine();
            String Entrada2 = Console.ReadLine();

            if(Entrada == "vertebrado")
            {
                if (Entrada1 == "ave")
                {
                    if (Entrada2 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (Entrada2 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (Entrada1 == "mamifero")
                {
                    if (Entrada2 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if( Entrada2 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if(Entrada == "invertebrado")
            {
                if (Entrada1 == "inseto")
                {
                    if (Entrada2 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (Entrada2 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (Entrada1 == "anelideo")
                {
                    if (Entrada2 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if( Entrada2 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
