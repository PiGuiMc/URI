var input = require('fs').readFileSync('/dev/stdin','utf8');
var lines = input.split('\n');

var name = string(lines.shift());
var salario = parseFloat(lines.shift());
var totalvenda =  parseFloat(lines.shift());

var newSalary = salario + (totalvenda * 0.15);

console.log("TOTAL = R$ " + newSalary.toFixed(2));