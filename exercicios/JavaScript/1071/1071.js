var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var menor = 0, maior = 0, soma = 0;

var n1 = parseInt(lines.shift());
var n2 = parseInt(lines.shift());

if(n1 > n2){
    maior = n1;
    menor = n2;
}else{
    maior = n2;
    menor = n1;
}

menor += 1;

while(menor < maior){
    if(menor % 2 !== 0 ){
        soma += menor;
    }
    menor += 1;
}

console.log(soma);