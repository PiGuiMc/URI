var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var count = 0;

for(let i=0; i<5; i++){
    var valor = parseInt(lines.shift())

    if(valor % 2 === 0){
        count +=1;
    }
}
console.log(count + " valores pares")