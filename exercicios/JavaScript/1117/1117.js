var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n')

var count=0, soma=0;

while(true){
    var nota = parseFloat(lines.shift());

    if(count == 2){
        console.log("media = " + (soma/2).toFixed(2))
        break
    }
    if(nota > 0 && nota <=10){
        soma += nota;
        count += 1;
    }else{
        console.log("nota invalida")
    }

}