#include <bits/stdc++.h>
using namespace std;

int main(){
    int n, c =0 , r=0, s=0,qt=0;
    string op;
    float pc,pr,ps;
    cin >> n;

    for(int i = 0; i < n; i++){
        cin >> qt >> op;

        if(op =="C"){
            c += qt;
        }else if(op == "R"){
            r += qt;
        }else if(op == "S"){
            s += qt;
        }
    }
    pc = ((c*100.00)/(c+r+s));
    pr = ((r*100.00)/(c+r+s));
    ps = ((s*100.00)/(c+r+s));
    cout << "Total: " << c+r+s << " cobaias" << endl;
    cout << "Total de coelhos: " << c << endl;
    cout << "Total de ratos: " << r << endl;
    cout << "Total de sapos: " << s << endl;
    printf("Percentual de coelhos: %.2f %\n",pc);
    printf("Percentual de ratos: %.2f %\n",pr);
    printf("Percentual de sapos: %.2f %\n",ps);
    return 0;
}
