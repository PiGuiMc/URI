var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(lines.length > 0){
    var v = parseInt(lines.shift());

    if(isNaN(v)){
        break
    }
    console.log(v - 1)
}