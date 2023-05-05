var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var cartas = lines.shift().split(' ')

var c1 = parseInt(cartas[0])
var c2 = parseInt(cartas[1])

if(c1>= 1 && c1<= 13 &&c2 >= 1 &&c2 <= 13){
    if(c1==c2){
        console.log(c1)
    }else if( c1>c2){
        console.log(c1)
    }else if( c1<c2){
        console.log(c2)}
}