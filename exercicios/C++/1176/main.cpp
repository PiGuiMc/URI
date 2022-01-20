#include <iostream>
using namespace std;

int main(){

    int t;

    cin >> t;

    for(int i=0;i<t;i++){
        int num;

        cin >> num;

        long long int f[num];
        f[0] = 0;
        f[1] = 1;

        if(num>1){
            for(int j=2;j<=num+1;j++){
                f[j] = f[j-2]+f[j-1];
            }
            cout << "Fib(" << num <<") = " << f[num] << endl;
        }else if(num <= 1){
            cout << "Fib(" << num <<") = " << num << endl;
        }
    }
    return 0;
}