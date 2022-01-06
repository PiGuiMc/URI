#include <iostream>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

int main(){
    double preco [] = {' ', 4.00, 4.50, 5.00, 2.00, 1.50};
    double total = 0;
    int cod, qt;

    scanf("%d %d",&cod, &qt);

    total =  preco[cod] * qt;

    printf("Total: R$ %.2f\n",total);
    return 0;
}