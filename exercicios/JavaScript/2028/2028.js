var input = require("fs").readFileSync("stdin","utf-8");
var lines = input.split('\n');

var n = 0;

while(lines.length >= 1){
    n++

    var x = parseInt(lines.shift());

    if(x == 0){
        console.log(`Caso ${n}: 1 numero`)
    }else{
        console.log(`Caso ${n}: ${x + 1} numeros`)
    }

    if(x == 0){
        console.log(0);
    }
    for(let i=0;i<x;i++){
        for(let b=0;b<i;b++){
            if(i == x && b == x -1){
                console.log(i)
            }else{
                console.log(i + ' ')
            }
        }
    }
}
//falta concluir