#include <iostream>

using namespace std;

int main(){
    int n,j=0;

    cin >> n;

    while(j<n){
        int pa, pb, anos=0;
        double g1,g2;

        cin >> pa >> pb >> g1 >> g2;
        g1 = g1/100;
        g2 = g2/100;
        while (true)
        {
            pa += int(pa * g1);
            pb += int(pb * g2);
            anos +=1;

            if(pa > pb || anos > 100){
                break;
            }
        }
        if(anos <=100){
            printf("%d anos.\n",anos);
        }else{
            printf("Mais de 1 seculo.\n");
        }
        j+=1;
    }
    return 0;
}