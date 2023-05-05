var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var x = parseInt(lines.shift())

for(let i=0; i<x; i++){
    var v = parseInt(lines.shift())

    if(v % 2 == 0){
        console.log(0)
    }else{
        console.log(1)
    }
}