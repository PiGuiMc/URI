#include <bits/stdc++.h>
using namespace std;

int main(){

    int n, v;
    
    cin >> n;

    for(int i =0; i<n;i++){

        cin >> v;

        if(v % 2 == 0 && v > 0){
            cout << "EVEN POSITIVE" << endl;
        }else if(v % 2 != 0 && v > 0){
            cout << "ODD POSITIVE" << endl;
        }
        if(v % 2 == 0 && v < 0){
            cout << "EVEN NEGATIVE" << endl;
        }else if(v % 2 != 0 && v < 0){
            cout << "ODD NEGATIVE" << endl;
        }
        if(v == 0){
            cout << "NULL" << endl;
        }
    }
    return 0;
}