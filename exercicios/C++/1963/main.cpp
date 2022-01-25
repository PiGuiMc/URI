#include <iostream>
#include<bits/stdc++.h>
using namespace std;

int main(){
    double precoA, precoN;

    cin >> precoA >> precoN;

    cout << fixed << setprecision(2) << (precoN * 100 / precoA) - 100 << "%" << endl;
    return 0;
}