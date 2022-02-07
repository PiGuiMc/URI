var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift()), x=1;

for(let i=0; i<n; i++){
    console.log(x + " " + (x+1) + " " + (x+2) + " PUM");
    x += 4;
}