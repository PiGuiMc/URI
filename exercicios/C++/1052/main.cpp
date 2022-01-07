#include <bits/stdc++.h>
using namespace std;

int main(){
    string Meses [] =  {" ","January","February","March","April","May","June","July","August","September","October","November","December"};

            int valor;
            cin >> valor;
            if(valor >= 1 && valor <= 12)
            {
                cout << Meses[valor] << endl;
            }
    return 0;
}