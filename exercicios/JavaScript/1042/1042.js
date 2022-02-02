var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var a = parseInt(line1[0])
var b = parseInt(line1[1])
var c = parseInt(line1[2])

if(a < b && a < c){
    console.log(a)
    if(b < c){
        console.log(b)
        console.log(c)
    }else{
        console.log(c)
        console.log(b)
    }
}else if(b < c){
    console.log(b)
    if(a < c){
        console.log(a)
        console.log(c)
    }else{
        console.log(c)
        console.log(a)
    }
}else{
    console.log(c)
    if(a < b){
        console.log(a)
        console.log(b)
    }else{
        console.log(b)
        console.log(a)
    }
}

console.log("")
console.log(a)
console.log(b)
console.log(c)