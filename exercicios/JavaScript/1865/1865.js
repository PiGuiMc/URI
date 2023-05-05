var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var x = lines.shift()

for(let i=0; i<x;i++){
    var td = lines.shift().split(' ')
    var st = td[0]

    if(st == 'Thor'){
        console.log('Y')
    }else{
        console.log('N')
    }
}