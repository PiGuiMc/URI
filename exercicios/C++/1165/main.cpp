#include <iostream>
using namespace std;

int main(){
    int n;
    
    cin >> n;

    for(int i=0;i<n;i++){
        int num,j=1,s=0;
        
        cin >> num;

        while(j<=num){
            if(num%j==0){
                s+=1;
            }
            j+=1;
        }
        if(s > 2){
            cout << num << " nao eh primo" << endl;
        }else{
            cout << num << " eh primo" << endl;
        }
    }
    return 0;
}