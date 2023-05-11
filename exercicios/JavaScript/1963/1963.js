var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var val = lines.shift().split(' ')
var v1 = parseFloat(val[0]);
var v2 = parseFloat(val[1]);

if(v2 > v1){
    console.log(parseFloat(((v2*100)/v1) - 100).toFixed(2) + '%')
}else if(v2 < v1){
    console.log(parseFloat(((v2*100)/v1)).toFixed(2) + '%')
}else if(v1 == v2){
    console.log(parseFloat((v2-v1)).toFixed(2) + '%')
}