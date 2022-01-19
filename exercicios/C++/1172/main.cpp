#include <iostream>
using namespace std;

int main(){

    for(int i =0;i<10;i++){
        int num;

        cin >> num;

        if(num <= 0){
            printf("X[%d] = 1\n",i);
        }else{
            printf("X[%d] = %d\n",i,num);
        }

    }
    return 0;
}