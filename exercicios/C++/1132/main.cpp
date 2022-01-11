#include <bits/stdc++.h>
using namespace std;

int main(){
    int x, y,soma=0,maior,menor;
    cin >> x;
    cin >> y;

    if(x > y){
        maior = x;
        menor = y;
    }else{
        maior = y;
        menor = x;
    }
    for(int i = menor; i<=maior;i++){
        if(i%13!=0){
            soma +=i;
        }
    }
    cout << soma << endl;
    return 0;
}