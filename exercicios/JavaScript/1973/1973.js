var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = lines.shift();
var qtx = n
var v = lines.shift().split(' ')


var continua = true;
var nums = [];
var total = 0;
var ataques = 0;
var soma = 0;
var pos = 0;
var pJ = 0
for(let i=0;i<n;i++){
    nums[i] = parseInt(v[i]);
    total += parseInt(v[i]);
}

for(let j=0; j<n; j++){
    if((parseInt(nums[j])%2==0) && continua){
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
    ataques = qtx;
    total -= ataques;
}
console.log(parseInt(ataques),parseInt(total));