#include <iostream>
using namespace std;

int main(){
    char nome;
    double salario, venda, aumento;

    scanf("%s %lf %lf",&nome, &salario, &venda);

    aumento = ((venda * 15)/100) + salario;

    printf("TOTAL = R$ %.2f\n",aumento);

    return 0;
}