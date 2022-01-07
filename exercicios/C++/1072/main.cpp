#include <bits/stdc++.h>
using namespace std;

int main(){
    int qt_in = 0, qt_out = 0, x,v;
    cin >> x;

    for(int i = 0; i < x; i++){
        cin >> v;

        if(v >= 10 && v <= 20){
            qt_in +=1;
        }else{
            qt_out +=1;
        }
    }
    cout << qt_in << " in" << endl;
    cout << qt_out << " out" << endl;
    return 0;
}