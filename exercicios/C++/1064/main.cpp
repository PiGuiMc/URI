#include <bits/stdc++.h>
using namespace std;

int main(){
    double media =0,soma = 0,v;
    int count =0;

    for(int i = 0; i < 6; i++){
        cin >> v;

        if(v > 0){
            soma += v;
            count +=1;
        }
    }
    media = soma / count;
    cout << count << " valores positivos" << endl;
    cout << fixed << setprecision(1) << media << endl;
    return 0;
}