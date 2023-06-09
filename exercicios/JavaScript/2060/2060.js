var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var mult = [2,3,4,5]

var x  = parseInt(lines.shift());

var valores = lines.shift().split(' ');

var qt2 = 0
var qt3 = 0
var qt4 = 0
var qt5 = 0


for(let i=0; i<x; i++){
    
    var v = parseInt(valores[i])

    mult.forEach(valor => {

        valor = parseInt(valor)
        if((v%valor)==0 && valor == 2){
            qt2 = qt2 + 1
        }else if((v%valor) == 0 && valor == 3){
            qt3 = qt3 + 1
        }else if((v%valor) == 0 && valor == 4){
            qt4 = qt4 + 1
        }else if((v%valor) == 0 && valor == 5){
            qt5 = qt5 + 1
        }
    });
}

console.log(`${qt2} Multiplo(s) de 2`)
console.log(`${qt3} Multiplo(s) de 3`)
console.log(`${qt4} Multiplo(s) de 4`)
console.log(`${qt5} Multiplo(s) de 5`)
