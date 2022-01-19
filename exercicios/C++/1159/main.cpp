#include <iostream>
using namespace std;

int main(){
    while(true){
        int n,soma=0,i=1;

        cin >> n;

        if(n==0){
            break;
        }else if(n!=0){
            while(i<=5){
                if(n%2==0){
                    soma += n;

                    n += 1;
                    i+=1;
                }else{
                    n +=1;
                }
            }
        }
        cout << soma << endl;
    }
    return 0;
}