#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    int c;
    char t;
    double N[12][12];
    double soma = 0.0;
    
    std::cin >> c;
    std::cin >> t;    
    
    for(int i = 0; i < 12; i++){
            for(int j = 0; j < 12; j++){
                   std::cin >> N[j][i];
                   if(j == c){
                        soma += N[j][i];
                   }
            }
   }
   
   if(t == 'S')
         printf("%.1f\n", soma);
    else
         printf("%.1f\n", soma/12.0);
    return 0;
}