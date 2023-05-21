var input = require("fs").readFileSync("stdin","utf-8");
var lines = input.split("\n");

var tipo_cha = parseInt(lines.shift());
var total = 0;
var voto = lines.shift().split(" ");

voto.forEach(voto => {
    if(voto == tipo_cha){
        total ++
    }
});

console.log(total)