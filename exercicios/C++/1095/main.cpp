#include <bits/stdc++.h>
using namespace std;

int main(){
    int i = -2;
    for(int j = 60; j >= 0; j = j - 5){
        cout << "I=" << i+3 << " J=" << j << endl;
        i += 3;
    }
    return 0;
}