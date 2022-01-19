#include <iostream>
using namespace std;

int main(){
    int n, i = 3, primeiroTermo = 0, segundoTermo = 1, proximoTermo;
    
    cin >> n;
    
    if (n == 0)
        exit(0);
    if (n == 1)
        cout << primeiroTermo << endl;
    else {
        if (n == 2)
            cout << primeiroTermo << " " << segundoTermo << endl;
        else {
            cout << primeiroTermo << " " << segundoTermo << " ";
            while (i <= n) {
                proximoTermo = primeiroTermo + segundoTermo;
                primeiroTermo = segundoTermo;
                segundoTermo = proximoTermo;
            
                if (i == n)
                    cout << proximoTermo << endl;
                else
                    cout << proximoTermo << " ";
                i++;
            }
        }
    }
    return 0;
}