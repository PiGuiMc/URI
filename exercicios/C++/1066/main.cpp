#include <bits/stdc++.h>
using namespace std;

int main(){
    int qt_par =0, qt_impar =0, qt_pos =0, qt_neg =0,v;

    for(int i = 0; i < 5; i++){
        cin >> v;
        if(v%2==0){
            qt_par += 1;
        }else if(v%2!=0){
            qt_impar += 1;
        }
        if(v > 0){
            qt_pos += 1;
        }else if(v < 0){
            qt_neg +=1;
        }
    }
    cout << qt_par << " valor(es) par(es)" << endl;
    cout << qt_impar << " valor(es) impar(es)" << endl;
    cout << qt_pos << " valor(es) positivo(s)" << endl;
    cout << qt_neg << " valor(es) negativo(s)" << endl;
    return 0;
}