#include <bits/stdc++.h>
using namespace std;

int main(){
    int x, i = 1;
    cin >> x;
    
    while(i <= x){
        if(i % 2 != 0){
            cout << i << endl;
        }
        i +=1;
    }
    return 0;
}