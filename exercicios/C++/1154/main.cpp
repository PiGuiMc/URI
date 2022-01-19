#include <iostream>
#include <bits/stdc++.h>
using namespace std;

int main(){
    int n,soma = 0;
    double media,  i = 0;
    cin >> n;

    while(n >= 0){
        soma += n;
        i += 1;

        cin >> n;
    }
    media = soma / i;
    printf("%.2lf\n",media);

    return 0;
}