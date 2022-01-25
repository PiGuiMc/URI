#include <iostream>
using namespace std;

int main(){
    int n;
    
    cin >> n;

    for(int i =0; i<n; i++){
        string p1, op1, p2, op2;
        int v1,v2;

        cin >> p1 >> op1 >> p2 >> op2;

        cin >> v1 >> v2;

        if((v1+v2)%2==0){
            if(op1 == "PAR"){cout << p1 << endl;} else{cout << p2 << endl;}
        }
        else if((v1+v2)%2!=0){
            if(op1 =="IMPAR"){cout << p1 << endl;}else{cout << p2 << endl;}
        }

    }
    return 0;
}