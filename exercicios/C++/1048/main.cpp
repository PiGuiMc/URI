#include<bits/stdc++.h>
using namespace std;
int main(){
    double valor, reajuste = 0, Nsalario = 0;
    int perc = 0;
    cin >> valor;

    if( valor >= 0.0 && valor <= 400){
        perc = 15;
        reajuste = valor * 0.15;
        Nsalario = valor + reajuste;
    }else if( valor >= 400.0 && valor <= 800){
        perc = 12;
        reajuste = valor * 0.12;
        Nsalario = valor + reajuste;
    }else if(valor >= 800.0 && valor <= 1200){
        perc = 10;
        reajuste = valor * 0.10;
        Nsalario = valor + reajuste;
    }else if(valor >= 1200.0 && valor <= 2000){
        perc = 7;
        reajuste = valor * 0.07;
        Nsalario = valor + reajuste;
    }else if(valor > 2000.00){
        perc = 4;
        reajuste = valor * 0.04;
        Nsalario = valor + reajuste;
    }
    cout << "Novo salario: " << fixed << setprecision(2) << Nsalario << endl;
    cout << "Reajuste ganho: " << fixed << setprecision(2) << reajuste << endl;
    cout << "Em percentual: " << fixed << perc << " %" << endl;
    return 0;
}