var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var valores = lines.shift().split(' ')

var a = parseInt(valores[0])
var b = parseInt(valores[1])
var c = parseInt(valores[2])
var d = parseInt(valores[3])

if(1 <= a && a <= 100 && 1 <= b && b <= 100 && 1 <= c && c <= 100 && 1 <= d && d <= 100){
    if(a + b > c && b + c > a && a + c > b){
        console.log('S')}
    else if(b + c > d && c + d > b && b + d > c){ 
        console.log('S')}
    else if(a + c > d && c + d >a && a + d > c){
        console.log('S')}
    else if(a + b> d && b + d > a && a + d > b){
        console.log('S')}
    else{
        console.log('N')}
    }