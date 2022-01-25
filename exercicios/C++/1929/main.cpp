#include <iostream>
using namespace std;

int main(){
    int a,b,c,d;

    cin >> a >> b >> c >> d;

    if(a > 0 && a<= 100 && b > 0 && b <= 100 && c > 0 && c <= 100 && d > 0 && d<=100){
                
        if(((a+b)>c) && ((b+c) > a) && ((a+c)>b)){
            cout << "S" << endl;
        }else if(((b + c) > d) && ((c + d) > b) && ((b + d) > c)){
            cout << "S" << endl;
        }else if(((a + c) > d) && ((c + d) >a) && ((a + d > c))){
            cout << "S" << endl;
        }else if(((a + b)> d) && ((b + d) > a) && ((a + d > b))){
            cout << "S" << endl;
        }else{
            cout << "N" << endl;
        }
    }

    return 0;
}