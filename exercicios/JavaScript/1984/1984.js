var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var str = String(lines.shift()),texto ='';

for(let i=str.length;i>0;i--){
    texto += str[i-1];
}
console.log(texto);