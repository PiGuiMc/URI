var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var t = parseInt(lines.shift());

    if(t == 0){
        break;
    }

    for(let i=0; i<t;i++){
        var v = parseInt(lines.shift())

        if(v%2 == 0){
            console.log(v * 2 - 2)
        }else{
            console.log(v * 2 - 1)
        }
    }
}