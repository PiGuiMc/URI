var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n')

while(x!=0){

    var x = lines.shift().split(' ');

    var a = parseInt(x[0]);
    var b = parseInt(x[1]);
    var c = parseInt(x[2]);

    if(x == 0){
        break;
    }

    //console.log(`A = ${a}, b = ${b}, c = ${c}`);
    var A = a * b;
    var t = A * 100 / c;
    t = (t) ** (1/2);

    console.log(parseInt(t));
}