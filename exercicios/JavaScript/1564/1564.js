var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');
var v;
while(!v.AtEndOfStream){
        v = parseInt(lines.shift());
        if(v == 0){
            console.log("vai ter copa!")
        }else{
            console.log("vai ter duas!")
        }
}