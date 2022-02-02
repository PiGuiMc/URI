var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var x = parseInt(line1[0])
var y = parseInt(line1[1])

if(x < y){
    if(y % x == 0){console.log("Sao Multiplos");}
    else{console.log("Nao sao Multiplos");}
}else{
    if(x % y == 0){console.log("Sao Multiplos");}
    else{console.log("Nao sao Multiplos");}
}