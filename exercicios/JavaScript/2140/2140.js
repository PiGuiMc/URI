var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){

    var troco = 0;

    var [n,m] = lines.shift().split(' ').map(Number);

    if(n == 0 && m == 0){
        break;
    }
    troco = m - n
    if(troco == 7 || troco == 12 || troco == 22 || troco == 52 || troco == 102 || troco == 15 || troco == 25 || troco == 55 || troco == 105 || troco == 30 || troco == 60 || troco == 110 || troco == 70 || troco == 120 || troco == 150){
    console.log("possible")}
    else{
    console.log("impossible")}   
}
