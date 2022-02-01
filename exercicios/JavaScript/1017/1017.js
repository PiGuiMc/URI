var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var tempo = parseInt(lines.shift());
var km = parseInt(lines.shift());

var litros = parseFloat((tempo * km) / 12);

console.log(litros.toFixed(3));