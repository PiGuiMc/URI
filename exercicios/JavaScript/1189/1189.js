var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var op = String(lines.shift())

var matriz = Array(12).fill(null).map(() => Array(12).fill(0));

var c2=0, soma=0, media=0, col=0;

for(let i=0; i<12; i++){
    for(let j=0; j<12; j++){
        var v = parseFloat(lines.shift())
        matriz[i][j] = v
    }
}

if(op == 'S\r' || op == 'S'){
    col = 1;
    for(let i=1; i<=11; i++){
        for(let j=0;j<col; j++){
            soma += matriz[i][j]
        }
        if(i < 5){
            col += 1;
        }else if(i > 5){
            col -= 1;
        }
    }
    console.log(soma.toFixed(1))
}else if(op == 'M\r' || op == 'M'){
    col = 1;
    for(let i=1; i<=11; i++){
        for(let j=0;j<col; j++){
            soma += matriz[i][j]
            c2 += 1;
        }
        if(i < 5){
            col += 1;
        }else if(i > 5){
            col -= 1;
        }
    }
    media = soma/c2;
    console.log(media.toFixed(1))
}