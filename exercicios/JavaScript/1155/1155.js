var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

var s = 0;

for(let i=1; i< 101; i++){
    s = parseFloat(s + parseFloat(1) / parseFloat(i));
}
console.log(s.toFixed(2));