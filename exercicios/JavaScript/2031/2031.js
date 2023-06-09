const { parseArgs } = require("util");

var input = require("fs").readFileSync('stdin','utf-8');
var lines = input.split('\n');

var x = lines.shift();

var sg = "Sem ganhador";
var jg1 = "Jogador 1 venceu";
var jg2 = "Jogador 2 venceu";
var ag = "Ambos venceram";
var am = "Aniquilacao mutua";

for(let i=0; i<x; i++){
    var j = 0
    var op1 = ""
    var op2 = ""

    while(j<2){
        if(j==0){
            op1 = lines.shift().trim();
        }else if(j==1){
            op2 = lines.shift().trim();
        }
        j++
    }
    if(op1 == 'pedra' && op2 == 'pedra'){
        console.log(sg);
    }else if(op1 == 'papel' && op2 == 'papel'){
        console.log(ag)
    }else if(op1 == 'pedra' && op2 == 'pedra'){
        console.log(jg2);
    } else if(op1 == 'ataque' && op2 == 'papel'){
        console.log(jg1);
    } else if(op1 == 'ataque' && op2 == 'pedra'){
            console.log(jg1);
      }else if(op1 == 'pedra' && op2 == 'papel'){
            console.log(jg1);
      }else if(op1 == 'papel' && op2 == 'pedra'){
            console.log(jg2);
        }else if(op1 == 'papel' && op2 == 'ataque'){
            console.log(jg2);
        }else if(op1 == 'ataque' && op2 == 'papel'){
            console.log(jg1);
        }else if(op1 == 'ataque' && op2 == 'ataque'){
            console.log(am);
        }else if(op1 == 'pedra' && op2 == 'ataque'){
            console.log(jg2);}
}
    
