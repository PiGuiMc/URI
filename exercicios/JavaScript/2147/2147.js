var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = parseInt(lines.shift());

for(let i=0; i<x; i++){
    
    var txt = lines.shift().trim()
    console.log((txt.length * 0.01).toFixed(2))
   
}