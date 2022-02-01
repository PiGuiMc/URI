var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var line1 = lines.shift().split(' ')

var a = parseFloat(line1[0]);
var b = parseFloat(line1[1]);
var c = parseFloat(line1[2]);

var delta = parseFloat(Math.pow(b,2) - 4*(a*c))

var div = parseFloat(2 * a)

if(div === 0 || div < 0){
    console.log("Impossivel calcular");
}else if(div > 0){
    var r1 = parseFloat((-b + Math.sqrt(delta)) / div)

    var r2 = parseFloat((-b - Math.sqrt(delta)) / div)

    if(r1 != NaN && r2 != NaN){
        console.log("R1 = " + r1.toFixed(5));
        console.log("R2 = " + r2.toFixed(5));
    }
}