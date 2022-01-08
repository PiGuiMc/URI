#include <bits/stdc++.h>
using namespace std;

int main() {
    int n[100], i, pos = 0, maior;
    
    cin >> n[0];
    maior = n[0];
    
    for (i = 1; i < 100; i++){
        cin >> n[i];
        
        if (n[i] > maior) {
            maior = n[i];
            pos = i;
        }
    }
    cout << maior << endl << pos + 1 << endl;
    return 0;
}