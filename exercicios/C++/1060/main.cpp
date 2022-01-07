#include <bits/stdc++.h>
using namespace std;

int main(){
    double v;
     int count=0;
    for(int i = 0; i < 6; i++){
       
        cin >> v;

        if(v > 0){
            count +=1;
        }
    }
    cout << count << " valores positivos" << endl;
    return 0;
}