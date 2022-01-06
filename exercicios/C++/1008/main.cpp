#include <iostream>
using namespace std;

int main(){

    int cod,hora;
    float valor_hora,salario;

    scanf("%d %d %f",&cod,&hora,&valor_hora);

    salario = valor_hora * hora;

    printf("NUMBER = %d\n",cod);
    printf("SALARY = U$ %.2f\n",salario);

    return 0;
}