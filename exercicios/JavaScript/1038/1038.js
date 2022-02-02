var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var line1 =  lines.shift().split(' ');

var op = {1:4.0, 2:4.5, 3:5.0, 4:2.0, 5:1.5}

var cod = parseInt(line1[0])
var qt = parseInt(line1[1])

var total = parseFloat(op[cod] * qt)

console.log("Total: R$ " + total.toFixed(2))