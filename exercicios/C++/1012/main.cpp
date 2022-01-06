#include <iostream>
using namespace std;

int main(){

    double a, b, c, tri, cir, trap, qua, ret;

    scanf("%lf %lf %lf", &a, &b, &c);

    tri = (a * c) / 2;

    cir = 3.14159 * (c * c);

    trap = ((a + b) / 2)* c;

    qua = b * b;
    
    ret = a * b;
    
    printf("TRIANGULO: %.3f\n",tri);
    printf("CIRCULO: %.3f\n",cir);
    printf("TRAPEZIO: %.3f\n",trap);
    printf("QUADRADO: %.3f\n",qua);
    printf("RETANGULO: %.3f\n",ret);

    return 0;
}