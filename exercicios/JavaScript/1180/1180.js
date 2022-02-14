var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n =  parseInt(lines.shift()), menor=1000, pos=0;
var line1 = lines.shift().split(' ');

for(let i=0; i<n; i++){
    var valor = line1[i];
    console.log(valor)

    if(valor < menor){
        menor = valor;
        pos = i;
    }
}
console.log(`Menor valor: ${menor}`);
console.log(`Posicao: ${pos}`)