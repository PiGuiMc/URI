var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = parseInt(lines.shift());
var y = parseInt(lines.shift());

var menor = x<y ? x : y;
var maior = x>y ? x : y;

var soma=0;

for(let i=menor; i<=maior; i++){
    if(i % 13 !== 0){
        soma+=i;
    }
}

console.log(soma);