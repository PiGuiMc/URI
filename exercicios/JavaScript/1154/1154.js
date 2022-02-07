var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var soma=0, count=0;

while(true){
    var n = parseInt(lines.shift());

    if(n >= 0){
        soma += n;
        count += 1;
    }

    if(n < 0){
        console.log((soma/count).toFixed(2));
        break;
    }
}