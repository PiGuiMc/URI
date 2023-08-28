var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = lines.shift()
var bits = 0

for(let i=0;i<x.length;i++){
    if(x[i] == '1'){
        bits += 1
    }
}
if(bits %2 == 1){
    x+='1'
}else{
    x+='0'
}

console.log(x)