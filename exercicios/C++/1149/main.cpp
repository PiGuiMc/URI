#include <iostream>

using namespace std;

int main(){
    
   int a, n, i = 0, r = 0;
    cin >> a;
    while (1) {
        cin >> n;
        if (n > 0)
            break;
    }
    while (i < n) 
        r += (a + i++);
    cout << r << endl;
    return 0;
}