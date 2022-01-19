#include <iostream>
using namespace std;

int main(){

    int x, z, i=2, s=1, soma;

    cin >> x;

    z = x - 1;

    soma = x;
    while(z <= x){
        cin >> z;
    }
    while(soma <= z){
        soma = soma + x + s;

        if(soma <= z){
            i += 1;
            s += 1;
        }
    }
    cout << i << endl;
    return 0;
}