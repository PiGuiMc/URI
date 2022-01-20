#include <iostream>
using namespace std;

int main(){
    int num,i=0,j=0;

    cin >> num;

    while(i<1000){
        
        printf("N[%d] = %d\n",i,j);
        j+=1;
        i+=1;

        if(j== num){
            j = 0;
        } 
    }
    return 0;
}