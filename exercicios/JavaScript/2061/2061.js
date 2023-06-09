var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var x = lines.shift().split(' ');

var aba = parseInt(x[0])
var qt = parseInt([x[1]])

for(let i=0; i<qt; i++){
    var o = lines.shift()

    if(o == 'fechou'){
        aba += 1 
    }
    if(o == 'clicou'){
        aba -= 1
    }
}
console.log(aba)