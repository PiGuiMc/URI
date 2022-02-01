var input = require('fs').readFileSync('/dev/stdin','utf8')
var lines = input.split('\n')

var a = parseInt(lines.shift());

var pi = parseFloat(3.14159);
var volume = (4/3) * pi * (a * a * a);

console.log("VOLUME = " + volume.toFixed(3));