var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var line = input.split(" ");

var a = parseInt(line.shift());
var b = parseInt(line.shift());
var c = parseInt(line.shift());

var maiorAB = (a+b + Math.abs(a-b)) / 2;

var maiorABC =  (c+maiorAB + Math.abs(maiorAB-c)) / 2;

console.log(maiorABC + ' eh o maior')
