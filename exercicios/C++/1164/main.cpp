#include <iostream>
using namespace std;

int main(){
    int n;
    cin >> n;

    for(int i=0;i<n;i++){
        int num, s =0, j=1;

        cin >> num;

        while(j<num){
            if(num%j==0){
                s += j;
            }
            j += 1;
        }
        if(s == num){
            cout << num << " eh perfeito" << endl;
        }else{
            cout << num << " nao eh perfeito" << endl;
        }

    }
    return 0;
}