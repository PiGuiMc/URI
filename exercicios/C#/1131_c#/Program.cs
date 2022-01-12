using System;

namespace _1131_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int g_gremio=0,g_inter=0,emp=0,cont=0;

            while(true){
                string[] line = Console.ReadLine().Split(' ');

                int g_i = Convert.ToInt32(line[0]);
                int g_g = Convert.ToInt32(line[1]);

                if(g_i > g_g){
                    g_inter +=1;
                }else if(g_i < g_g){
                    g_gremio +=1;
                }else{
                    emp +=1;
                }
                cont += 1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int op = Convert.ToInt32(Console.ReadLine());
                if(op == 2){
                    Console.WriteLine("{0} grenais", cont.ToString());
                    Console.WriteLine("Inter:{0}", g_inter.ToString());
                    Console.WriteLine("Gremio:{0}",g_gremio.ToString());
                    Console.WriteLine("Empates:{0}", emp.ToString());
                    
                    if(g_inter > g_gremio) Console.WriteLine("Inter venceu mais");
                    if(g_inter < g_gremio) Console.WriteLine("Gremio venceu mais");
                    if(g_inter == g_gremio) Console.WriteLine("Nao houve vencedor");
                    break;
                }
                
            }
        }
    }
}
