#include <iostream>
using namespace std;

int main(){

    float a,b,c, med;

    scanf("%f %f %f", &a,&b,&c);

    med = ((2*a) + (3*b) + (c*5))/10;

    printf("MEDIA = %.1f\n",med);

    return 0;
}