var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var lines1 = lines.shift().split(' ');
var a = parseFloat(lines1[0]);
var b = parseFloat(lines1[1])
var c = parseFloat(lines1[2]);

var pi = 3.14159;

var triang = (a * c) / 2;
var circ = pi * (c*c);
var trap = ((a+b)/2) * c;
var quad = b*b;
var ret = a * b;

console.log("TRIANGULO: " + triang.toFixed(3));
console.log("CIRCULO: " + circ.toFixed(3));
console.log("TRAPEZIO: " + trap.toFixed(3));
console.log("QUADRADO: " + quad.toFixed(3));
console.log("RETANGULO: " + ret.toFixed(3));

