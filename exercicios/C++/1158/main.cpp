#include <iostream>
using namespace std;

int main(){
    int n;

    cin >> n;

    for(int i =0; i<n;i++){
        int x,y,soma=0,j=1;
        
        cin >> x >> y;

        while(j<=y){
            if(x%2 != 0){
                soma = soma + x;

                x = x +1;
                j = j + 1;
            }else if(x%2 ==0){
                x = x + 1;
            }
        }
        cout << soma << endl;
    }
    return 0;
}