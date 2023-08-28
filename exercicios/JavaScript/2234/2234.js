var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var [h,p] = lines.shift().split(' ').map(Number);

console.log(parseFloat(h/p).toFixed(2));