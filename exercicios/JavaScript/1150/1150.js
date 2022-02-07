var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var i=2, s=1, soma, z;

var x = parseInt(lines.shift());

z = x - 1;
soma = x;

while(z <= x){
    z = parseInt(lines.shift());
}
while(soma <= z){
    soma += x + s;

    if(soma <= z){
        i += 1;
        s += 1;
    }
}

console.log(i);