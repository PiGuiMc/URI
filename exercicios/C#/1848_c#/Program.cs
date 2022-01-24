using System;

namespace _1848_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0,s=0;

            while(s != 3){
                for(int i=0;i<1000;i++){
                    string n = Convert.ToString(Console.ReadLine());

                    if(n == "caw caw"){
                        s=s+1;
                        Console.WriteLine(c);
                        c = 0;
                    }
                    if(n == "---"){
                        c += 0;
                    }else if(n == "--*"){
                        c += 1;
                    }else if(n == "-*-"){
                        c +=2;
                    }else if(n == "-**"){
                        c += 3;
                    }else if(n == "*--"){
                        c +=4;
                    }else if(n == "*-*"){
                        c +=5;
                    }else if(n == "**-"){
                        c +=6;
                    }else if(n == "***"){
                        c +=7;
                    }

                    if(s==3){
                        break;
                    }
                }
            }
        }
    }
}
