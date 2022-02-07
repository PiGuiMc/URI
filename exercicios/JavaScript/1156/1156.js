var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var s = 0, j=1;

for(let i=1; i<40;i+=2){
    s += parseFloat(i / j);
    j *= 2;
}
console.log(s.toFixed(2));