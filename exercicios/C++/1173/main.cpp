#include <iostream>
using namespace std;

int main(){
    int num;

    cin >> num;

    for(int i=0;i<10;i++){
        printf("N[%d] = %d\n",i,num);
        num*=2;
    }
    return 0;
}