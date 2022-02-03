var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
    var media = 0;
    var line1 = lines.shift().split(' ');

    var a = parseFloat(line1[0]);
    var b = parseFloat(line1[1]);
    var c = parseFloat(line1[2]);

    media = ((a*2) + (b*3) + (c*5)) / 10;

    console.log(media.toFixed(1))
}