#include <bits/stdc++.h>
using namespace std;

int main(){
    int x,y,count=1;
    
    cin >> x >> y;

    for(int i=1;i<=y;i++){
        cout << i;

        if(x==count){
            cout << "" << endl;
            count = 1;
        }
        else if(count < x){
            cout << " ";
            count ++;
        }
    }
    
    return 0;
}