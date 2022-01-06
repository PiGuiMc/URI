#include <iostream>
#include <stdlib.h>
#include <stdio.h>

int main(){
    int dist;
    double litros, qt_km;

    scanf("%d",&dist);
    scanf("%lf",&litros);

    qt_km = dist / litros;

    printf("%.3f km/l\n",qt_km);

    return 0;
}