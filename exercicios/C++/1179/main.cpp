#include <iostream>
#include <stdio.h>
using namespace std;

int main(){
    int p=0, im=0, j=0;
    int par[5];
    int impar[5];

    for(int i=0;i<15;i++){
        int valor;

        cin >> valor;

        if(valor %2 ==0){
            par[p] = valor;
            p +=1;
        }else if(valor%2 !=0){
            impar[im] = valor;
            im +=1;
        }
        if(sizeof(par)/sizeof(par[0]) == 5 && p==5){
            while(j<5){
                printf("par[%d] = %d\n",j,par[j]);
                j += 1;
            }
            j = 0;
            p = 0;
            int par[5];
        }else if(sizeof(impar)/sizeof(impar[0]) == 5 && im==5){
            while(j<5){
                printf("impar[%d] = %d\n",j,impar[j]);
                j += 1;
            }
            j = 0;
            im = 0;
            int impar[5];
        }
    }
    for (int i = 0; i < im; i++)
        {
            printf("impar[%d] = %d\n",i,impar[i]);
        }
        for (int i = 0; i < p; i++)
        {
            printf("par[%d] = %d\n",i,par[i]);
        }
    return 0;
}