var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 =  lines.shift().split(' ');

var a = parseFloat(line1[0])
var b = parseFloat(line1[1])
var c = parseFloat(line1[2])

if ((b-c) < a && a < (b+c) && (a-c) < b && b < (a+c)&&(a-b) < c && c < (a+b)){
    var per = parseFloat(a + b + c);
    console.log("Perimetro = " + per.toFixed(1));
}else{
    var area = parseFloat(((a + b) * c) / 2);
    console.log("Area = " + area.toFixed(1));
}