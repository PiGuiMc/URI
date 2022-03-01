var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n')

var n = parseInt(lines.shift())
var r = []

for(let i=0; i<n; i++){
    r[i] = ('Ho')
}

console.log(r.join(' ') + '!');