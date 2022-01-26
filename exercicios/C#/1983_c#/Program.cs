using System;

namespace _1983_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            double nota, nt_ap=0;
            int n = Convert.ToInt32(Console.ReadLine()), cod,cod_ap=0;

            for(int i=0; i<n; i++){
                string[] valor = Console.ReadLine().Split(' ');

                cod = Convert.ToInt32(valor[0]);

                nota = Convert.ToDouble(valor[1]);

                if(nota >= 8){
                    if(nota > nt_ap){
                        nt_ap = nota;
                        cod_ap = cod;
                    }
                }

            }
            if(cod_ap > 0){
                Console.WriteLine(cod_ap.ToString());
            }else{
                Console.WriteLine("Minimum note not reached");
            }
        }
    }
}
