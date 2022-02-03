var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var imp =0; par = 0, pos = 0, neg = 0;

for(let i=0; i<5; i++){
    var valor = parseInt(lines.shift());

    if(valor > 0){
        pos += 1;
    }else if(valor < 0){
        neg += 1;
    }
    if(valor%2 === 0){
        par += 1;
    }else if( valor%2 !== 0){
        imp += 1;
    }
}

console.log(par + " valor(es) par(es)\n"
            + imp + " valor(es) impar(es)\n"
            + pos + " valor(es) positivo(s)\n"
            + neg + " valor(es) negativo(s)"
);