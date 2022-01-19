#include <iostream>

using namespace std;

int main(){
    double s =0, j =1;

    for(int i =1; i<40;i += 2){
        s = s + double(i) / j;
        j *= 2;
    }
    printf("%.2f\n",s);
    return 0;
}