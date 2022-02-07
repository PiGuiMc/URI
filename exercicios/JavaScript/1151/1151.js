var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

var fib = [n-1];
fib[0] = 0; fib[1] = 1;
for(let i=2; i<n; i++){
    fib.push(fib[i - 2] + fib[i - 1]);
}
console.log(fib.join(' '));