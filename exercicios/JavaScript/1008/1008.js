var input = require('fs').readFileSync('/dev/stdin','utf8');
var lines = input.split('\n');

var cod = parseInt(lines.shift());
var qt = parseInt(lines.shift());
var vl = parseFloat(lines.shift());

var salario = qt * vl;

console.log("NUMBER = " + cod);
console.log("SALARY = U$ " + salario.toFixed(2));