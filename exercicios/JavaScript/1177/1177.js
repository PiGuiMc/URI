var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var v = parseInt(lines.shift()), i=0, j=0;

while(i<1000){
    console.log("N[" + i + "] = " + j);

    i += 1;
    j += 1;

    if(j == v){
        j = 0;
    }
}