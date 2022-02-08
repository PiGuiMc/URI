var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<10; i++){
    console.log("N[%d] = %d",i,n);

    n *= 2;
}