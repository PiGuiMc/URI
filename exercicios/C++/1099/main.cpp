#include <bits/stdc++.h>
using namespace std;

int main(){
    int n, x, y, maior, menor,s=0;

    cin >> n;

    for(int i =0; i < n;i++){
        s = 0;
        cin >> x >> y;

        if(x > y){
            maior = x;
            menor = y;
        }else{
            maior = y;
            menor = x;
        }

        for(int k = menor+1; k<maior;k++){
            if(k%2 !=0){
                s = s + k;
            }
        }
        if(menor == maior){
            s = 0;
        }
        cout << s << endl;

    }
    return 0;
}