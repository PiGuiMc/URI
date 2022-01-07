#include<bits/stdc++.h>
using namespace std;

int main(){
    int hi, mi, hf,mf, h=0, m=0;
    cin >>hi>>mi>>hf>>mf;

    if(hi < hf){
        h = hf - hi;
        if(mi < mf){
            m = mf - mi;
        }else if(mi > mf){
            h = h - 1;
            m = (60 - mi) + mf;
        }else if(mi == mf){
            m = 0;
        }
    }
    if(hi > hf){
        h = (24 - hi) + hf;
        if(mi < mf){
            m = mf - mi;
        }else if(mi > mf){
            h = h - 1;
            m = (60 - mi) + mf;
        }else if(mi == mf){
            m = 0;
        }
    }
    if(hi == hf){
        if(mi < mf){
            m = mf - mi;
            h = 0;
        }else if(mi > mf){
            m = (60 - mi ) + mf;
            h = 23;
        }else if(mi == mf){
            h = 24;
            m = 0;
        }
    }
    cout << "O JOGO DUROU " << h << " HORA(S) E " << m << " MINUTO(S)" << endl;
    
return 0;}