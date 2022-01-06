#include <iostream>

int main(){
    double a,b,c, area = 0.0, per = 0.0;

    scanf("%lf %lf %lf",&a,&b,&c);
    if ((b-c) < a && a < (b+c) && (a-c) < b && b < (a+c)&&(a-b) < c && c < (a+b)){
        per = a + b + c;
        printf("Perimetro = %.1f\n",per);
    }else{
        area = (((a + b) * c) / 2);
        printf("Area = %.1f\n",area);
    }
    return 0;
}