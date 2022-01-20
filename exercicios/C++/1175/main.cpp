#include <iostream>
using namespace std;

int main(){
    int vector [20];

    for(int i=19;i>=0;i--){
        int num;

        cin >> num;

        vector[i] = num;
    }
    for(int j=0;j<20;j++){
        cout << "N[" << j << "] = " << vector[j] << endl;
    }
    return 0;
}