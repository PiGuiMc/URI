#include <iostream>
using namespace std;

int main(){
    int n;

    cin >> n;

    for(int i=0;i<n;i++){
        string v;
        int c;

        cin >> v >> c;

        if(v == "Thor"){cout << "Y" << endl;}else{cout << "N" << endl;}
    }
    return 0;
}