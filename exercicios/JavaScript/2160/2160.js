var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var txt = lines.shift();

if(txt.length <= 80){
    console.log('YES');
}else{
    console.log("NO")
}
