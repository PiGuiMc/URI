var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var x = parseInt(lines.shift());

    if(x == -1){
        break;
    }

    if(x == 0){
        console.log(x)
    }else{
        t = x - 1
        console.log(t);
    }
    
}