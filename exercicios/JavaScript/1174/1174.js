var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

for(let i=0; i<100; i++){
    var v = parseFloat(lines.shift());

    if(v <= 10){
        console.log("A["+ i + "] = " + v.toFixed(1));
    }
}