var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

n = parseFloat(lines.shift())
var op1 = parseFloat(((1 + Math.sqrt(5))/2)**n)
var op2 = parseFloat(((1 - Math.sqrt(5))/2)**n)

var fib = parseFloat(op1 - op2)/Math.sqrt(5)

console.log(fib.toFixed(1))