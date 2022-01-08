#include <bits/stdc++.h>
using namespace std;

int main(){
    int a=7, b =6, c=5, i=1;

    while(i <=9){
        printf("I=%d J=%d\n",i,a);
        printf("I=%d J=%d\n",i,b);
        printf("I=%d J=%d\n",i,c);

        a+=2;
        b+=2;
        c+=2;
        i+=2;
    }
    return 0;
}