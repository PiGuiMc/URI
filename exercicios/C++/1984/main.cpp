#include <iostream>
using namespace std;

int main(){
    string teste="",teste2="",ent;

    cin >> ent;

    teste = ent;

    for(int i=teste.length(); i>=0; i--){
        teste2 = teste2 + teste[i];
    }
    
    cout << teste2 << endl;
    return 0;
}