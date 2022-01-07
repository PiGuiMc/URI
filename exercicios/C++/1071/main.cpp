#include <bits/stdc++.h>
using namespace std;

int main(){
    int n1, n2, maior = 0, menor = 0, soma = 0;

    cin >> n1;
    cin >> n2;

    if(n1 > n2){
        maior = n1;
        menor = n2;
    }else{
        maior = n2;
        menor = n1;
    }
    menor += 1;

    while(menor < maior){
        if(menor%2!=0){
            soma += menor;
        }
        menor +=1;
    }
    cout << soma << endl;
    return 0;
}