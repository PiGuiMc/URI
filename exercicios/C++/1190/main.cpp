#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    char t;
    double N[12][12];
    double soma = 0.0,media =0.0;
    int col=0,c2=0;
    
    std::cin >> t;    
    
    for(int i = 0; i < 12; i++){
        for(int j = 0; j < 12; j++){
            std::cin >> N[j][i];
        }
   }

    if(t == 'S'){
        col = 11;
        for(int i=1; i<=11;i++){
            for(int j=col;j<12;j++){
                soma = soma + N[j][i];
            }
            if(i<5){
                col = col - 1;
            }else if(i>5){
            col = col + 1;
            }
        }
        printf("%.1f\n", soma);
    }

    if(t == 'M'){
        c2=0;
        col = 11;
        for(int i=1; i<=11;i++){
            for(int j=col;j<12;j++){
                soma = soma + N[j][i];
                c2 +=1;
            }
            if(i<5){
                col = col - 1;
            }else if(i>5){
            col = col + 1;
            }
        }
        media = soma/c2;
        printf("%.1f\n", media);
    }
    return 0;
}