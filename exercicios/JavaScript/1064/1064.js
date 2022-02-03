var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var count =0, soma =0;

for(let i=0; i<6; i++){
    var valor = parseFloat(lines.shift())

    if(valor > 0){
        soma += valor;
        count += 1;
    }
}
console.log(count + " valores positivos");
console.log((soma / count).toFixed(1))