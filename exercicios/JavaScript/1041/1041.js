var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var x = parseFloat(line1[0])
var y = parseFloat(line1[1])

if( x > 0 && y > 0){
    console.log("Q1");
}else if(x < 0 && y > 0){
    console.log("Q2");
}else if(x < 0 && y < 0){
    console.log("Q3");
}else if(x > 0 && y < 0){
    console.log("Q4");
}else if(y == 0 && x > 0 || x < 0){
    console.log("Eixo X");
}else if( x == 0 && y > 0 || y < 0){
    console.log("Eixo Y");
}else if(x == 0 && y == 0){
    console.log("Origem");
}