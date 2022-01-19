#include <iostream>
#include <vector>
#include <iomanip>
using namespace std;

int main(){
    float vector[100];
    
    for(int i=0;i<100;i++){
        double num;
        
        cin >> num;

        vector[i] = num;
    }

    for(int j=0; j<100;j++){
        if(vector[j] <= 10){
            cout<<setprecision(1)<<fixed;
            cout<< "A[" << j << "] = " << vector[j] << endl;
        }
    }
    return 0;
}