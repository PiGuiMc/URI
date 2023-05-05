var input = require("fs").readFileSync('stdin','utf8')
var line = input.split('\n');

var n = parseInt(line.shift())
var m = parseInt(line.shift())

var fig = [n]

while(m){
    console.log(m)
    m -= 1
    fig[parseInt(line.shift()) - 1] = 1
}

var falta = fig
console.log(falta)