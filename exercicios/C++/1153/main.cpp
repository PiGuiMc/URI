#include <iostream>
using namespace std;

int main(){
    int n, fatorial = 1;

    cin >> n;
    while(n>=1){
        fatorial = fatorial * n;
        n = n -1;
    }
    cout << fatorial << endl;
    return 0;
}