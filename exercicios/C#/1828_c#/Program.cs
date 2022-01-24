using System;

namespace _1828_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()),i=1;

            while(i<=n){
                String[] line = Console.ReadLine().Split(' ');
                string s1 = Convert.ToString(line[0]);
                string s2 = Convert.ToString(line[1]);

                if(s1 == s2){Console.WriteLine("Caso #{0}: De novo!",i);}
                else if(s1 == "tesoura" && s2 == "papel"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if(s2 == "tesoura" && s1 == "papel"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "papel" && s2 == "pedra"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "papel" && s1 == "pedra"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "pedra" && s2 == "lagarto"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "pedra" && s1 == "lagarto"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "lagarto" && s2 == "Spock"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "lagarto" && s1 == "Spock"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "Spock" && s2 == "tesoura"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "Spock" && s1 == "tesoura"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "tesoura" && s2 == "lagarto"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "tesoura" && s1 == "lagarto"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "lagarto" && s2 == "papel"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "lagarto" && s1 == "papel"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "papel" && s2 == "Spock"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "papel" && s1 == "Spock"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "Spock" && s2 == "pedra"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "Spock" && s1 == "pedra"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}
                else if (s1 == "pedra" && s2 == "tesoura"){Console.WriteLine("Caso #{0}: Bazinga!",i);}
                else if (s2 == "pedra" && s1 == "tesoura"){Console.WriteLine("Caso #{0}: Raj trapaceou!",i);}

                i+=1;
            }
        }
    }
}
