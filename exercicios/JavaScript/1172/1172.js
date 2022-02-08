var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

for(let i=0; i<10; i++){
    var v = parseInt(lines.shift());

    if(v <= 0){
        console.log("X[" + i + "] = 1");
    }else{
        console.log("X[%d] = %d", i,v);
    }
}