#include <iostream>
#include <stdlib.h>
#include <stdio.h>
using namespace std;

    int valores [] = {365,30,1};
    char *texto[3] = {"ano(s)", "mes(es)", "dia(s)"};
    int i, result=0, qt = 0;
int main(){

    int valor;

    scanf("%d",&valor);

    for(i = 0; i < 3; i++){
        qt = int(valor / valores[i]);

        printf("%d %s\n",qt,texto[i]);
        valor -= qt * valores[i];
    }
    return 0;
}