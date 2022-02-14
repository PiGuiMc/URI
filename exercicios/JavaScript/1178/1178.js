var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var v = parseFloat(lines.shift());

for(let i=0; i<100; i++){
    console.log("N["+ i + "] = " + v.toLocaleString('en-US', { minimumFractionDigits: 4 }));
    
    v /= 2;
}