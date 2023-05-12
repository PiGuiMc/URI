var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = parseInt(lines.shift())

var notaMax = 0;
var matMax = 0;

for(let i=0; i<x;i++){
    var v = lines.shift().split(' ');
    matricula = v[0];
    nota = parseFloat(v[1]).toFixed(2)

    if(nota > 8){
        if(nota > notaMax){
            notaMax = nota
            matMax = matricula
        }
    }
}

if(matMax > 0){
    console.log(matMax)
}else{
    console.log("Minimum note not reached");
}
