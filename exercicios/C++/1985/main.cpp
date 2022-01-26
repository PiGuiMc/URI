#include <iostream>
#include <bits/stdc++.h>
using namespace std;

int main(){
    int n;
    double vl;

    cin >> n;

    for(int i=0; i<n; i++){
        int cod,qt;

        cin >> cod >> qt;

        if(cod == 1001){
            vl += qt * 1.5;
        }else if(cod == 1002){
            vl += qt * 2.5;
        }else if(cod == 1003){
            vl += qt * 3.5;
        }else if(cod == 1004){
            vl += qt * 4.5;
        }else if(cod == 1005){
            vl += qt * 5.5;
        }
    }
    cout << fixed << setprecision(2) << vl << endl;
    return 0;
}