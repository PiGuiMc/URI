var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift())

for(let i=0; i<n; i++){
    var line1 = lines.shift().split(' ')

    var a = parseInt(line1[0]);
    var b = parseInt(line1[1]);

    console.log(a+b)
}