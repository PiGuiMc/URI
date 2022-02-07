var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift()), fat=1;

while(n >= 1){
    fat *= n;
    n -= 1;
}
console.log(fat);