#include <iostream>
using namespace std;

int main(){
    int n,cod, cod_ap=0;
    double nota, nt_ap=0;

    cin >> n;

    for(int i=0; i<n; i++){
        cin >> cod >> nota;

        if(nota >= 8){
            if(nota > nt_ap){
                nt_ap = nota;
                cod_ap = cod;
            }
        }
    }
    if(cod_ap > 0){
        cout << cod_ap << endl;
    }else{
        cout << "Minimum note not reached" << endl;
    }
    
    return 0;
}