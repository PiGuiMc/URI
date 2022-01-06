#include <iostream>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

int main(){
    double a,b,c,d, media,n_exa,n_media;

    scanf("%lf %lf %lf %lf",&a,&b,&c,&d);

    media = ((a*2) + (b*3) + (c*4) + (d*1))/10;

    printf("Media: %.1f\n",media);

    if(media >= 7){
        printf("Aluno aprovado.\n");
    }
    else if(media >= 5){
        printf("Aluno em exame.\n");
        scanf("%lf",&n_exa);
        printf("Nota do exame: %.1f\n",n_exa);

        n_media = (media + n_exa)/2;
        if(n_media >= 5){
            printf("Aluno Aprovado.\n");
        }else{
            printf("Aluno reprovado.\n");
        }
        printf("Media final: %.1f\n",n_media);
    }
    else{
        printf("Aluno reprovado.\n");
    }
    return 0;
}