var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var line1 =  lines.shift().split(' ');

    var x = parseInt(line1[0]);
    var y = parseInt(line1[1]);

    if(y == 0){
        console.log("divisao impossivel");
    }else{
        console.log(parseFloat(x/y).toFixed(1));
    }
}