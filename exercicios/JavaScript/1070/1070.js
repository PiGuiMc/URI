var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var n = parseInt(lines.shift());

for(let i=n; i<n + 12; i++){
    if(i%2 !== 0){
        console.log(i);
    }
}