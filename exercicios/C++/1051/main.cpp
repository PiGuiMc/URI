#include <bits/stdc++.h>
using namespace std;

int main(){

    double  Valor ,i8 = 0, i18 = 0, i28 = 0, vimp = 0;
    cin >> Valor;

            if(Valor >= 0 && Valor <= 2000)
            {
                cout << "Isento" << endl;
            }

            else if(Valor >= 2000.01 && Valor <= 3000)
            {
                vimp = (Valor - 2000) * 0.08;
                 cout << "R$ " << fixed << setprecision(2) << vimp << endl;
            }
            else if(Valor >= 3000.01 && Valor <= 4500)
            {
                i8 = 0.08 * 1000;
                i18 = (Valor - 3000);
                vimp = (i18 * 0.18) + i8;
                cout << "R$ " << fixed << setprecision(2) << vimp << endl;
            }
            else if(Valor >= 4500.01)
            {
                i8 = 0.08* 1000;
                i18 = 0.18 * 1500;
                i28 = Valor - 4500;
                vimp = i18 + i8 + (i28 * 0.28);
                cout << "R$ " << fixed << setprecision(2) << vimp << endl;
            }
    return 0;
}