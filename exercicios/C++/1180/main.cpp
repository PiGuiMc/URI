#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    int n,aux=1000,pos=0;
    
    cin >> n;

    int vector[n];

    for(int i=0; i<n;i++){
        cin >> vector[i];
        if(vector[i]<aux){
            aux = vector[i];
            pos = i;
        }
    }

    cout << "Menor valor: " << aux << endl;
    cout << "Posicao: " << pos << endl;
    return 0;
}