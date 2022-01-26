using System;

namespace _1960_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()),unidade,dezena,centena;
            string roma="";

            unidade = n%10;

            n /= 10;

            dezena = n%10;

            n /=10;

            centena = n %10;
    
            if(centena>0){
                if(centena <= 3){
                    if(centena == 1){
                        roma += "C";
                    }else if(centena == 2){
                        roma += "CC";
                    }else if(centena == 3){
                        roma += "CCC";
                    }           
                }else if(centena == 4){
                    roma += "CD";
                }else if(centena == 5){
                    roma += "D";
                }else if(centena > 5 && centena < 9){
                    if(centena == 6){
                        roma += "DC";
                    }else if(centena == 7){
                        roma += "DCC";
                    }else if(centena == 8){
                        roma += "DCCC";
                    }
                }else if(centena == 9){
                    roma += "CM";
                }
            }
            if(dezena > 0){
                if(dezena <= 3){
                    if(dezena == 1){
                        roma += "X";
                    }else if(dezena == 2){
                        roma += "XX";
                    }else if(dezena == 3){
                        roma += "XXX";
                    } 
                }else if(dezena == 4){
                    roma += "XL";
                }else if(dezena == 5){
                    roma += "L";
                }else if(dezena > 5 && dezena < 9){
                    if(dezena == 6){
                        roma += "LX";
                    }else if(dezena == 7){
                        roma += "LXX";
                    }else if(dezena == 8){
                        roma += "LXXX";
                    }
                }else if(dezena == 9){
                    roma += "XC";
                }
            }
            if(unidade > 0){
                if(unidade <= 3){
                    if(unidade == 1){
                        roma += "I";
                    }else if(unidade == 2){
                        roma += "II";
                    }else if(unidade == 3){
                        roma += "III";
                    } 
                }else if(unidade == 4){
                    roma += "IV";
                }else if(unidade == 5){
                    roma += "V";
                }else if(unidade > 5 && unidade < 9){
                    if(unidade == 6){
                        roma += "VI";
                    }else if(unidade == 7){
                        roma += "VII";
                    }else if(unidade == 8){
                        roma += "VIII";
                    }
                }else if(unidade == 9){
                    roma += "IX";
                }
            }
            Console.WriteLine(roma.ToString());
        }
    }
}
