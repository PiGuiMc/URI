var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var n = parseInt(lines.shift());

for(let i=2; i<=n; i+=2){
    if(i%2 === 0){
        console.log(i + "^2 = " + Math.pow(i,2));
    }
}