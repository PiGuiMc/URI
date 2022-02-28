var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n')

var matriz = Array(12).fill(null).map(() => Array(12).fill(0));
var soma = 0

var linha = parseInt(lines.shift())

var op = String(lines.shift())

for(let i=0; i<12; i++){
    for(let j=0; j<12; j++){
        var v = parseFloat(lines.shift())
        matriz[i][j] = v
    }
}

for(let k=0; k<12; k++){
    soma += matriz[linha][k]
    //console.log(matriz[linha][k])
}
if(op == 'S\r' || op == 'S'){
    console.log(soma.toFixed(2))
}else if(op == 'M\r' || op == 'M'){
    var media = soma / 12
    console.log(media.toFixed(1))
}

//console.table(matriz)