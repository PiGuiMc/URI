#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){
    double a,b,c, div, delta,r1,r2;

    scanf("%lf %lf %lf",&a,&b,&c);

    delta = b*b - 4*(a*c);

    div = 2 * a;
    
    if ((div == 0) || (delta < 0)){
    printf("Impossivel calcular\n");
    }
    else{
    r1 = double((-b + sqrt(delta)) / (div));

    r2 = double((-b - sqrt(delta)) / (div));

    printf("R1 = %.5f\n",r1);
    printf("R2 = %.5f\n",r2);
    }
    return 0;
}