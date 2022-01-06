#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

int main(){

    int valor, hora, min, seg,h1 = 0,m1 = 0,s1= 0;

    seg = 60;
    min = seg;
    hora = 3600;

    scanf("%d",&valor);

    if(valor >= hora){
       h1 = int(valor / hora);
       valor = valor - (hora * h1);
    }
    if(valor >= min && valor < hora){
        m1 = int(valor / min);
        valor = valor - (min * m1);
    }
    if(valor < seg && valor < min){
        s1 = valor;
    }

    printf("%d:%d:%d\n",h1,m1,s1);
    return 0;
}