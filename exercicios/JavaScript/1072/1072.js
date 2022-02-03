var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var  bet = 0, out = 0;

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var valor = parseInt(lines.shift());
    
    if(valor >= 10 && valor <= 20){
        bet += 1;
    }else{
        out += 1;
    }
}
console.log(bet + " in\n" + out + " out");