var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

var menor = n / Math.log(n);
var maior = 1.25506 * (n / Math.log(n))

console.log((`${menor.toFixed(1)} ${maior.toFixed(1)}`))