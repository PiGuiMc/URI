#include <iostream>
using namespace std;

int main(){
    int v, count = 0, n;

    int valores[5];

    cin >> v;

    for(int i=0; i<5;i++){
        cin >> n;
        valores[i] = n;
    }

    for(int j=0; j<5; j++){
        if(v ==  valores[j]){
            count += 1;
        }
    }

    cout << count << endl;
    
    return 0;
}