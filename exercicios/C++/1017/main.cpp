#include <iostream>
#include <stdio.h>
#include <stdlib.h>

int main(){
    int hora, km;
    float total,media;
    scanf("%d",&hora);
    scanf("%d",&km);

    media = hora * km;
    total = media / 12;

    printf("%.3lf\n",total);

    return 0;
}