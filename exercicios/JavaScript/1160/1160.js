var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){

    var anos=0;

    var line1 = lines.shift().split(' ');
    var pa = parseInt(line1[0]), pb = parseInt(line1[1]), 
        g1 = parseFloat(line1[2]), g2 = parseFloat(line1[3]);
    
    g1 = g1/100;
    g2 = g2/100;
    
    while(true){

        pa = pa + (parseInt(pa * g1))
        pb = pb + (parseInt(pb * g2))

        anos = anos + 1

        if(pa > pb || anos > 100){
            break;
        }
    }

    if(anos <= 100){
        console.log(anos + " anos.")
    }else{
        console.log("Mais de 1 seculo.")
    }
}