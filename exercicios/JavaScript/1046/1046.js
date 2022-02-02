var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var a = parseInt(line1[0])
var b = parseInt(line1[1])

if(a == b){
    console.log("O JOGO DUROU 24 HORA(S)");
}else if(a < b){
    var tempo = parseInt(b - a);

    console.log("O JOGO DUROU " + tempo + " HORA(S)");
}else if(a > b){
    var tempo = parseInt(24 - (a - b));

    console.log("O JOGO DUROU " + tempo + " HORA(S)");
}