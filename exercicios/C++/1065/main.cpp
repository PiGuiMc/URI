#include <bits/stdc++.h>
using namespace std;

int main(){
    int count =0,v;
    
    for(int i =0; i < 5; i++){
        cin >> v;

        if(v%2==0){
            count +=1;
        }
    }
    cout << count << " valores pares" << endl;
    return 0;
}