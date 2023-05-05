var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var valores = lines.shift().split(' ')

var p = parseInt(valores[0] * valores[1])

console.log(p)