#include <bits/stdc++.h>
using namespace std;

int main(){
    int i=0,op;
    float med,nota;
    while(true){
        while(i < 2){
            cin >> nota;
            if(nota >=0 && nota <= 10){
                i = i + 1;
                med = med + nota;
            }else if(nota < 0 || nota > 10){
                cout << "nota invalida" << endl;
            }
        }
        med = med / 2;
        printf("media = %.2f\n",med);
        printf("novo calculo (1-sim 2-nao)\n");
        cin >> op;
        if(op == 1){
            i = 0;
            med = 0.0;
        }else if(op==2){
            i = 2;
            break;
        }else{
            printf("novo calculo (1-sim 2-nao)\n");
            cin >> op;
        }
    }
    return 0;
}