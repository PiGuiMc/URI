var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n =  parseInt(lines.shift());
var line1 = lines.shift().split(' ');
var list = [n];
var aList = [n];
for(let i=0; i<n; i++){
    var valor = line1[i];
    list[i] = valor;
    aList[i] = valor;
}

var nList = list.sort();

console.log(`Menor valor: ${nList[0]}`);
console.log(`Posicao: ${aList.indexOf(nList[0])}`);