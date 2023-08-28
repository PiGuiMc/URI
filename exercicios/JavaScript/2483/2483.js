var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var qt = lines.shift()
var a = ''
for(let i=0; i<qt; i++){
    a += 'a'
}

console.log('Feliz nat' + a + 'l!')