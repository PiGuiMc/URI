var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');


while(lines.length > 0){
    var total = parseFloat(0);
    var v = parseInt(lines.shift());

    for(let i =0; i< v; i++){
        var line1 = lines.shift().split(' ');
        var op1 = parseFloat(line1[0]);
        var op2 = parseFloat(line1[1]);

        total += ((parseFloat(op1) * parseFloat(op2)) / (parseFloat(op2) * 100));
    }
    

    if(isNaN(v)){
        break;
    }

    console.log(parseFloat(total/v).toFixed(4));
}