#include <iostream>

int main(){
    int cod1, cod2, qt1,qt2;
    float valor1, valor2, total;

    scanf("%d %d %f",&cod1, &qt1, &valor1);
    scanf("%d %d %f",&cod2, &qt2, &valor2);

    total = (qt1 * valor1) + (qt2 * valor2);

    printf("VALOR A PAGAR: R$ %.2f\n",total);

    return 0;
}