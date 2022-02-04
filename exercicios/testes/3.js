var input = require('fs').readFileSync('stdin','utf8')
let lines = input.split('\n');

let n = parseInt(lines.shift());
//escreva o seu código aqui
console.log(n)
var frase1 = ("LIFE IS NOT A PROBLEM TO BE SOLVED");

console.log(frase1.slice(0,n));