var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = lines.shift()

for(let i=0; i<x; i++){
    var anos =0;
    var v = parseInt(lines.shift())

    if(v > 2015){
        anos = (v-2015)+1
        console.log(anos + ' A.C')
    }else if(v < 2015){
        anos = (2015 - v)
        console.log(anos + ' D.C')
    }
    else if(v == 2015){
        console.log('1 A.C')
    }
}