#include <iostream>
using namespace std;

int main(){
    int n;

    cin >> n;

    for(int i=0; i<n; i++){
        int t,anos=0;

        cin >> t;

        if(t > 2015){
            anos = (t - 2015) + 1;
            cout << anos << " A.C." << endl;
        }else if( t < 2015){
            anos = (2015 - t);
            cout << anos << " D.C." << endl;
        }else if(t == 2015){
            cout << "1 A.C." << endl;
        }

    }
    return 0;
}