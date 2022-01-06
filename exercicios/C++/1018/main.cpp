// arrays example
#include <iostream>
using namespace std;

int cedulas [] = {100,50,20,10,5,2,1};
int i, result=0, qt_cedulas;

int main ()
{
    int valor;

    scanf("%d",&valor);

    printf("%d\n",valor);

    for ( i=0 ; i<7 ; i++ )
    {
        qt_cedulas = int(valor / cedulas[i]);
        printf("%d nota(s) de R$ %d,00\n",qt_cedulas,cedulas[i]);
        valor = valor - (qt_cedulas * cedulas[i]);
    }
    
  return 0;
}