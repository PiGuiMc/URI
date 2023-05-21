var input = require("fs").readFileSync("stdin",'utf8');
var lines = input.split('\n')

var x = lines.shift()
console.log(x)
while(lines.length > 1){
    var v = lines.shift().split(":")

    console.log(v[0])
}
//falta concluir