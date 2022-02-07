var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var num = parseInt(lines.shift()),s=0, j=0;

    while(j<num){
        if(num%j==0){
            s = s + j;
        }
        j += 1;
    }
    if(s==num){
        console.log(num + " eh perfeito");
    }else{
        console.log(num + " nao eh perfeito");
    }
}