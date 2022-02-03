var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var valor = parseInt(lines.shift());

    if(valor % 2 !==0 && valor < 0){
        console.log("ODD NEGATIVE");
    }else if(valor % 2 === 0 && valor < 0){
        console.log("EVEN NEGATIVE");
    }else if(valor % 2 === 0 && valor > 0){
        console.log("EVEN POSITIVE");
    }else if(valor % 2 !== 0 && valor > 0){
        console.log("ODD POSITIVE");
    }else if( valor === 0){
        console.log("NULL");
    }
}