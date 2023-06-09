var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var x = lines.shift().split(' ');

var s = parseInt(x[0])
var t = parseInt(x[1])
var f = parseInt(x[2])

var total = s + t + f

if(total >= 24){
    total = total - 24
}
if(total < 0){
    
    total = total + 24
}
console.log(total)