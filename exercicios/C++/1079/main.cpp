#include <bits/stdc++.h>
using namespace std;

int main(){
    int n;
    float n1, n2, n3,media;

    cin >> n;

    for(int i = 0; i <n;i++){
        cin >> n1;
        cin >> n2;
        cin >> n3;

        media = (n1*2.0 + n2*3.0 + n3*5.0)/10.0;
        printf("%.1f\n",media);
    }
    return 0;
}