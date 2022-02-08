var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var op1 = lines.shift().toString()
var op2 = lines.shift().toString()
var op3 = lines.shift().toString()


if(op1 = "vertebrado"){
    if(op2 = "ave"){
        if(op3 = "carnivoro"){
            console.log("aguia");
        }else if(op3 = "onivoro"){
            console.log("pomba");
        }
    }else if(op2 = "mamifero"){
        if(op3 = "onivoro"){
            console.log("homem");
        }else if(op3 = "herbivoro"){
            console.log("vaca");
        }
    }
}else if(op1 = 'invertebrado'){
    if(op2 = "inseto"){
        if(op3 = "hematofago"){
            console.log("pulga");
        }else if(op3 = "herbivoro"){
            console.log("largata");
        }
    }else if(op2 = 'anelideo'){
        if(op3 = "hematofago"){
            console.log("sanguessuga");
        }else if(op3 = 'onivoro'){
            console.log("minhoca");
        }
    }
}