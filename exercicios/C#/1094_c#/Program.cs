using System;

namespace _1094_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c =0 , r=0, s=0,qt=0;
            string op;
           
            n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++){
                String entrada = Console.ReadLine();
                String[] line = entrada.Split(' ');
                qt = Convert.ToInt32(line[0]);
                op = Convert.ToString(line[1]);

                if(op =="C"){
                    c += qt;
                }else if(op == "R"){
                     r += qt;
                }else if(op == "S"){
                    s += qt;
                }

            }
            double pc = (((c*100.00)/(c+r+s)));
            double pr = (((r*100.00)/(c+r+s)));
            double ps = (((s*100.00)/(c+r+s)));
            Console.WriteLine( "Total: {0} cobaias",c+r+s);
            Console.WriteLine("Total de coelhos: {0}",c);
            Console.WriteLine("Total de ratos: {0}", r);
            Console.WriteLine("Total de sapos: {0}",s);
            Console.WriteLine("Percentual de coelhos: {0} %",pc.ToString("0.00"));
            Console.WriteLine("Percentual de ratos: {0} %",pr.ToString("0.00"));
            Console.WriteLine("Percentual de sapos: {0} %",ps.ToString("0.00"));
        }
    }
}
