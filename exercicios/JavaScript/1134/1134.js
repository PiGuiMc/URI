var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var g=0, a=0, d=0;

while(true){
    var op = parseInt(lines.shift());

    if(op == 1){
        a += 1;
    }else if(op == 2){
        g += 1;
    }else if(op == 3){
        d += 1;
    }else if(op == 4){
        console.log("MUITO OBRIGADO\n"
                    + "Alcool: " + a + "\n"
                    + "Gasolina: " + g + "\n"
                    + "Diesel: " + d);
        break;
    }
}