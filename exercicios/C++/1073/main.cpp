#include <bits/stdc++.h>
#include <math.h>
using namespace std;

int main(){
    int n;
    cin >> n;

    for(int i = 1; i < n+1; i++){
        if(i%2==0){
            cout << i << "^" << "2 = " << pow(i,2) << endl;
        }
    }
    return 0;
}