#include <bits/stdc++.h>
using namespace std;

int main(){
    int cod, g=0,e=0,d=0;
    
    while(true){
        cin >> cod;

        if(cod == 1){
            e+=1;
        }else if(cod == 2){
            g+=1;
        }else if(cod == 3){
            d+=1;
        }else if(cod == 4){
            cout << "MUITO OBRIGADO" << endl;
            cout << "Alcool: " << e << endl;
            cout << "Gasolina: " << g << endl;
            cout << "Diesel: " << d << endl;
            break;
        }
    }
    return 0;
}