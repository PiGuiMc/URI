var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var a = parseFloat(line1[0]);
var b = parseFloat(line1[1]);
var c = parseFloat(line1[2]);

if(a >= (b+c) || b >= (a+c) || c >= (a+b)){
    console.log("NAO FORMA TRIANGULO");
}else if(a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b)){
    console.log("TRIANGULO RETANGULO");
}else if(a*a > (b*b + c*c) || b*b > (a*a + c*c) || c*c > (a*a + b*b)){
    console.log("TRIANGULO OBTUSANGULO");
}else if(a*a < (b*b + c*c) || b*b < (a*a + c*c) || c*c < (a*a + b*b)){
    console.log("TRIANGULO ACUTANGULO");}
if(a == b && a == c){
    console.log("TRIANGULO EQUILATERO");
}
if((a == b && a != c)  || (a == c && a != b) || (b == c && b != a)){
    console.log("TRIANGULO ISOSCELES");}
