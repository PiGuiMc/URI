var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var val = lines.shift().split(' ')

var t1 = parseInt(val[0])
var t2 = parseInt(val[1])
var t3 = parseInt(val[2])
var t4 = parseInt(val[3])

var total = 0

total = (t1 - 1) + (t2 - 1) + (t3 - 1) + t4
console.log(total)