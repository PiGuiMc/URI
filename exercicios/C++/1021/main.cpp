#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
using namespace std;

int cedulas [] = {100,50,20,10,5,2};
float moedas [] = {1.00,0.50,0.25,0.10,0.05,0.01};
int main(){
    int i = 0, qt =0, qt_m=0;
    double valor = 0.00,v =0.00;

    scanf("%lf",&valor);

    printf("NOTAS:\n");

    for(i = 0; i < 6; i++){
        qt = int(valor / cedulas[i]);

        printf("%d nota(s) de R$ %d.00\n",qt,cedulas[i]);
        valor -= qt* cedulas[i];
    }

    printf("MOEDAS:\n");

    for(i = 0; i < 6; i++){
        v = (valor + 0.0001);
        qt_m = int(  v / moedas[i]);

        printf("%d moeda(s) de R$ %.2f\n",qt_m,moedas[i]);
        valor -= qt_m * moedas[i];
    }
    return 0;
}