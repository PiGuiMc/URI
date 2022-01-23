#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    char t;
    double N[12][12];
    double soma = 0.0,media =0.0;
    int inf=0,c2=0,sup=0;
    
    std::cin >> t;    
    
    for(int i = 0; i < 12; i++){
        for(int j = 0; j < 12; j++){
            std::cin >> N[j][i];
        }
   }

    if(t == 'S'){
        inf = 1;
        sup = 11;
        for(int i=0; i<6;i++){
            for(int j=inf;j<sup;j++){
                soma = soma + N[j][i];
            }
            inf +=1;
            sup -=1;
        }
        printf("%.1f\n", soma);
    }

    if(t == 'M'){
        c2=0;
        inf = 1;
        sup = 11;
        for(int i=0;i<6;i++){
            for(int j=inf;j<sup;j++){
                soma = soma + N[j][i];
                c2 +=1;
            }
            inf +=1;
            sup -=1;
        }
        media = soma/c2;
        printf("%.1f\n", media);
    }
    return 0;
}