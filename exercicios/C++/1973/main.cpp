#include <iostream>
using namespace std;

int main(){
    int n,pos=0,soma=0;
    long long int total=0,ataques=0;
    bool continua = true;

    cin >> n;
    int nums[n];

    for(int i=0;i<n;i++){
        int num;

        cin >> num;

        nums[i] = num;
        total += num;
    }

    for(int j=0; j<n; j++){
        if(nums[j]%2==0 && continua){
            ataques = j+1;
            soma += ((j*2)+1) - pos;
            continua = false;
        }
        if(nums[j] -1 == 0 && continua){
            pos = j + 1;
        }
    }

    if(soma>0){
        total -= soma;
    }else{
        ataques = n;
        total -= ataques;
    }
    cout << ataques << " " << total << endl;
    return 0;
}