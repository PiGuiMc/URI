#include <bits/stdc++.h>
using namespace std;

int main(){
    int i=0;
    float med,nota;

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
    return 0;
}