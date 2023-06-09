var input = require('fs').readFileSync('stdin','utf-8');
var lines = input.split('\n');

var v = lines.shift().split(' ');

var p = parseInt(v[0]);
var j1 = parseInt(v[1]);
var j2 = parseInt(v[2]);
var r = parseInt(v[3]);
var a = parseInt(v[4]);

var v = 0

var jg1 = 'Jogador 1 ganha!';
var jg2 = 'Jogador 2 ganha!';

if((j1 + j2)%2 == 0){
    if(p == 1){
        v = 1
    }else{
        v = 2
    }
}else{
    if(p == 0){
        v = 1
    }else{
        v = 2
    }
}

if(r == 1 && a == 1){
    console.log(jg2)
}else if(r == 1 && a == 0){
    console.log(jg1)
}else if(r == 0 && a == 1){
    console.log(jg1)
}else if(r == 0 && a == 0){
    if(v == 1){
        console.log(jg1)
    }else if(v == 2){
        console.log(jg2)
    }
}