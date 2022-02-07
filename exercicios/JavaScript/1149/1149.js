var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var x = parseInt(line1[0]), n = parseInt(line1[1]), soma=0, count =1;

while(n<=0){
    count += 1;
    n = parseInt(line1[count]);
}

for(let i=0; i<=n -1; i++){
    soma += x + i;
}
console.log(soma);