var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var line1 = lines.shift().split(' ');

    var x = parseInt(line1[0]);
    var y = parseInt(line1[1]);

    if(x == y){
        break;
    }
    if(x > y){
        console.log("Decrescente");
    }else{
        console.log("Crescente");
    }
}