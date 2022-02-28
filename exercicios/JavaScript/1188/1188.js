var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var op = String(lines.shift())

var matriz = Array(12).fill(null).map(() => Array(12).fill(0));

var c2=0, soma=0, media=0, inf=0, sup=0;

for(let i=0; i<12; i++){
    for(let j=0; j<12; j++){
        var v = parseFloat(lines.shift())
        matriz[i][j] = v
    }
}

if(op == 'S\r' || op == 'S'){
    inf = 5;
    sup = 7;
    for(let i=7; i<12; i++){
        for(let j=inf;j<sup; j++){
            soma += matriz[i][j]
        }
        inf -= 1;
        sup +=1;
    }
    console.log(soma.toFixed(1))
}else if(op == 'M\r' || op == 'M'){
    inf = 1;
    sup = 11;
    for(let i=7; i<12; i++){
        for(let j=inf;j<sup; j++){
            soma += matriz[i][j]
            c2 += 1;
        }
        inf -= 1;
        sup +=1;
    }
    media = soma/c2;
    console.log(media.toFixed(1))
}