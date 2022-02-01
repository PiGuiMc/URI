var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

const seg = 60;
const min = 60;
const hora = 60 * min;
var h1 = 0, m1=0, s1= 0;

var valor =  parseInt(lines.shift())

if(valor >= hora){
    h1 = parseInt(valor / hora);

    valor = valor - (hora * h1);
}
if(valor >= min && valor < hora){
    m1 =  parseInt(valor / min);

    valor = valor - (m1 * min);
}
if(valor >= 0 && valor < seg){
    s1 = valor;
}

console.log(h1 + ":" + m1 + ":" + s1)