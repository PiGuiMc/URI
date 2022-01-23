#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    char t;
    double N[12][12];
    double soma = 0.0,media =0.0;
    int c=0,c2=0;
    
    std::cin >> t;    
    
    for(int i = 0; i < 12; i++){
        for(int j = 0; j < 12; j++){
            std::cin >> N[j][i];
        }
   }

    if(t == 'S'){
        c = 1;
        for(int i=0; i< 11;i++){
            for(int j=c;j<12;j++){
                soma = soma + N[j][i];
            }
            c +=1;
        }
        printf("%.1f\n", soma);
    }

    if(t == 'M'){
        c = 1;
        c2=0;
        for(int i=0;i<11;i++){
            for(int j=c;j<12;j++){
                soma = soma + N[j][i];
                c2 +=1;
            }
            c+=1;
        }
        media = soma/c2;
        printf("%.1f\n", media);
    }
    return 0;
}