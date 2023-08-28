var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var [x,m] = lines.shift().split(' ').map(Number)

    if(x == 0 && m == 0){
        break;
    }

    console.log(x*m)
}