using System;

namespace _2003_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                string input = Console.ReadLine();
                string[] valor = input.Split(':');
                
                if (string.IsNullOrEmpty(input)){
                    break;
                    }

                    int hmax = Convert.ToInt32(valor[0]), mmax = Convert.ToInt32(valor[1]);

                        int hh = (hmax + 1) - 8;

                        if(hh < 0){
                            Console.WriteLine("Atraso maximo: 0");
                        }else{
                            mmax += 60 * hh;
                            Console.WriteLine("Atraso maximo: {0}",mmax.ToString());
                        }
                }
                
            }
        }
    }

