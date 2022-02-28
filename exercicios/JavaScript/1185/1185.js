var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var op = String(lines.shift())

var matriz = Array(12).fill(null).map(() => Array(12).fill(0));

var c=0, c2=0, soma=0, media=0;

for(let i=0; i<12; i++){
    for(let j=0; j<12; j++){
        var v = parseFloat(lines.shift())
        matriz[i][j] = v
    }
}

if(op == 'S\r' || op == 'S'){
    c = 11;
    for(let i=0; i<11; i++){
        for(let j=0;j<c; j++){
            soma += matriz[i][j]
        }
        c -=1;
    }
    console.log(soma.toFixed(1))
}else if(op == 'M\r' || op == 'M'){
    c = 11;
    for(let i=0; i<11; i++){
        for(let j=0;j<c; j++){
            soma += matriz[i][j]
            c2 += 1;
        }
        c -=1;
    }
    media = soma/c2;
    console.log(media.toFixed(1))
}