#include <iostream>
using namespace std;

int main(){

    double raio, volume;

    scanf("%lf",&raio);

    volume = (4.0/3) * (3.14159 * (raio * raio * raio));

    printf("VOLUME = %.3f\n",volume);

    return 0;
}