var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var list = [20];

for(let i=19; i>=0; i--){
    var num = parseInt(lines.shift());

    list[i] = num;
}
for(let j=0; j<20; j++){
    console.log("N[%d] = %d", j,list[j]);
}