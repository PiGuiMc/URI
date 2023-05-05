var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

let triste = ':('
let feliz = ':)'

var valores = lines.shift().split(' ')

var temp1 = parseInt(valores[0]);
var temp2 = parseInt(valores[1]);
var temp3 = parseInt(valores[2]);

if(temp2 < temp1 && temp3>= temp2){
        console.log(feliz)
    }else if (temp2 > temp1 && temp3 <= temp2){
        console.log(triste)
    }else if (temp2 > temp1 && temp3 > temp2 && (temp3 - temp2) < (temp2 - temp1)){
        console.log(triste)
    }  else if (temp2 > temp1 && temp3 > temp2 && (temp3 - temp2) >= (temp2 - temp1)) {
        console.log(feliz)
    }else if (temp2 < temp1 && temp3 < temp2 && (temp2 - temp3) < (temp1 - temp2)) {
        console.log(feliz)
    }else if (temp2 < temp1 && temp3 < temp2 && (temp2 - temp3) >= (temp1 - temp2)){
        console.log(triste)
    }else if (temp2 < temp1 && temp3 < temp2 && (temp2 - temp3) >= (temp1 - temp2)){
        console.log(triste)
    }else if (temp2 == temp1 && temp3 > temp2){
        console.log(feliz)
    }else if (temp2 == temp1 && temp3 < temp2){
        console.log(triste)
}
else{
    console.log(triste)
}