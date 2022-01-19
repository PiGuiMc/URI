#include <iostream>
using namespace std;

int main(){
    double s = 0;

    for(int i = 1; i < 101;i++){
        s = s + double(1)/double(i);
    }
    printf("%.2lf\n",s);
    return 0;
}