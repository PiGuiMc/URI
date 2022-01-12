#include <bits/stdc++.h>
using namespace std;

int main(){
    int n, x = 1;

    cin >> n;

    for(int i=1; i<n+1;i++){
        printf("%d %d %d PUM\n", x,x+1,x+2);
        x = x + 4;
    }
    return 0;
}